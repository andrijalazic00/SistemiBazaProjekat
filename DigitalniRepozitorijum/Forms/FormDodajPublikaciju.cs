using DigitalniRepozitorijum.Entities;
using NHibernate;
using NHibernate.Exceptions;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forms
{
    public partial class FormDodajPublikaciju : Form
    {
        private Publikacija _publikacija;
        private ISession _session;
        private bool _izmena;
        private Dictionary<string, Autor> _autorDict;
        private Dictionary<string, Dataset> _datasetDict;
        private Dictionary<string, TehnickiIzvestaj> _tehnickiIzvestajDict;
        private Dictionary<string, SoftverskiArtifakt> _softverskiArtifaktDict;

        public FormDodajPublikaciju()
        {
            InitializeComponent();
            nudRedniBrojAutora.Minimum = 1;
            _publikacija=new Publikacija();
            _session = null;
            _izmena = false;
            PopuniComboBox();
        }
        public FormDodajPublikaciju(Publikacija p, ISession s)
        {
            InitializeComponent();
            nudRedniBrojAutora.Minimum = 1;
            _publikacija = p; 
            _session = s;
            _izmena = true;
            PopuniComboBox();
        }
        public void PopuniComboBoxIzmena()
        {

        }

        public void PopuniComboBox()
        {
            try
            {
                if(_session==null)
                    _session = DataLayer.GetSession();
                else 
                {
                    comboBKoriscen.Text = _publikacija.TehnickiIzvestajID?.Naslov;
                    //comboBKoriscen.SelectedValue
                }

                List<Autor> autorList = _session.Query<Autor>().ToList();
                List<Dataset> datasetList=_session.Query<Dataset>().ToList();
                List<SoftverskiArtifakt> softverskiArtifaktList= _session.Query<SoftverskiArtifakt>().ToList();
                List<TehnickiIzvestaj> tehnickiIzvestajList = _session.Query<TehnickiIzvestaj>().ToList();

                //_session.Clear();
                /*
                datasetList =_session.Query<Dataset>().ToList();
                softverskiArtifaktList = _session.Query<SoftverskiArtifakt>().ToList();               
                tehnickiIzvestajList = _session.Query<TehnickiIzvestaj>().ToList();*/

                _autorDict = autorList.ToDictionary(i => i.ID_I != null ? i.ID_I.Ime + " " + i.ID_I.Prezime + " " + i.ID_U : i.ID_U.ToString());
                _datasetDict = datasetList.ToDictionary(i => i.ID_IR+" "+ i.Naslov + " " + i.DatumKreiranja);
                _softverskiArtifaktDict = softverskiArtifaktList.ToDictionary(i => i.ID_IR + " " + i.Naslov + " " + i.DatumKreiranja);
                _tehnickiIzvestajDict = tehnickiIzvestajList.ToDictionary(i => i.ID_IR + " " + i.Naslov + " " + i.DatumKreiranja);

                comboBNastalaIz.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBAutor.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBZasnivaSeNa.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBKoriscen.DropDownStyle = ComboBoxStyle.DropDownList;

                if (_autorDict.Count>0)
                {
                    comboBAutor.DataSource = new BindingSource(_autorDict, null);
                    comboBAutor.DisplayMember = "Key";
                    comboBAutor.ValueMember = "Value";
                    
                }
                else
                {

                    MessageBox.Show("Nema autora u bazi, dodajte autora pre dodavanje publikacije");
                    _session.Close();
                    this.Close();

                }

                if (_datasetDict.Count > 0)
                {
                    comboBZasnivaSeNa.DataSource = new BindingSource(_datasetDict, null);
                    comboBZasnivaSeNa.DisplayMember = "Key";
                    comboBZasnivaSeNa.ValueMember = "Value";
                    
                    comboBZasnivaSeNa.SelectedIndex = -1;
                }
                

                if (_softverskiArtifaktDict.Count > 0)
                {
                    comboBKoriscen.DataSource = new BindingSource(_softverskiArtifaktDict, null);
                    comboBKoriscen.DisplayMember = "Key";
                    comboBKoriscen.ValueMember = "Value";
                    
                    comboBKoriscen.SelectedIndex = -1;
                }
                

                if (_tehnickiIzvestajDict.Count > 0)
                {
                    comboBNastalaIz.DataSource = new BindingSource(_tehnickiIzvestajDict, null);
                    comboBNastalaIz.DisplayMember = "Key";
                    comboBNastalaIz.ValueMember = "Value";
                    
                    comboBNastalaIz.SelectedIndex = -1;

                }

                if(_izmena)
                {
                    if(_publikacija.DatasetID!=null)
                        comboBZasnivaSeNa.SelectedValue =  _publikacija.DatasetID ;
                    if (_publikacija.SoftverskiArtifaktID != null)
                        comboBKoriscen.SelectedValue = _publikacija.SoftverskiArtifaktID;
                    if (_publikacija.TehnickiIzvestajID != null)
                        comboBNastalaIz.SelectedValue = _publikacija.TehnickiIzvestajID;
                }
                else 
                {
                    btnObrisiAutora.Visible = false;
                    btnObrisiAutora.Enabled = false;
                }
               




            }
            catch (Exception ex)
            {
                MessageBox.Show("Neuspesno pribavljanje entiteta" + ex.Message.ToString());
                this.Close();
            }
        }


        private void btnSacuvajPublikaciju_Click(object sender, EventArgs e)
        {

            try 
            {
       
                if (comboBZasnivaSeNa.SelectedValue != null)
                    _publikacija.DatasetID = (Dataset)comboBZasnivaSeNa.SelectedValue;
                if (comboBKoriscen.SelectedValue != null)
                    _publikacija.SoftverskiArtifaktID = (SoftverskiArtifakt)comboBKoriscen.SelectedValue;
                if (comboBNastalaIz.SelectedValue != null)
                    _publikacija.TehnickiIzvestajID = (TehnickiIzvestaj)comboBNastalaIz.SelectedValue;

                _session.SaveOrUpdate(_publikacija);
                _session.Flush();
                _session.Close();
                MessageBox.Show("Unos uspesan");
                this.Close();

                
            }
            catch (GenericADOException ex) when (ex.InnerException is OracleException oraEx && oraEx.Number == 1)
            {
                 MessageBox.Show("Vec postoji publikacija bazirana na izabranim istrazivackim rezultatima");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
               
                _session.Close();
            }
            
                
        }

        private void btnDodajAutora_Click(object sender, EventArgs e)
        {
            try {
                if (tbTipDoprinosa.Text.Length > 0 && tbUlogaUPublikaciji.Text.Length > 0)
                {
                    Autor autor = (Autor)comboBAutor.SelectedValue;
                    Autorstvo autrostvo = new Autorstvo(autor, _publikacija);
                    autrostvo.TipDoprinosa = tbTipDoprinosa.Text;
                    autrostvo.RedniBrojAutora = (int)nudRedniBrojAutora.Value;
                    autrostvo.UlogaUPublikaciji = tbUlogaUPublikaciji.Text;
                    _publikacija.Autorstva.Add(autrostvo);
                    autor.Autorstva.Add(autrostvo);
                    MessageBox.Show("Autor dodat");
                    tbTipDoprinosa.Clear();
                    tbUlogaUPublikaciji.Clear();
                    nudRedniBrojAutora.Value += 1;
                }
                else
                {
                    MessageBox.Show("Popunite prazna polja");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void btnObrisiAutora_Click(object sender, EventArgs e)
        {
            try 
            {
               
                Autor autor = (Autor)comboBAutor.SelectedValue;
                if(_publikacija.Autorstva.Count>1)
                {
                    Autorstvo autorstvo = _publikacija.Autorstva.FirstOrDefault(a => a.ID_P == _publikacija && a.ID_U == autor);
                    if (autorstvo != null)
                    {
                        _publikacija.Autorstva.Remove(autorstvo);
                        autor.Autorstva.Remove(autorstvo);
                        _session.Delete(autorstvo);
                        _session.Flush();
                        _session.Close();
                        MessageBox.Show("Autor publikacije obrisan");
                    }
                    else 
                    {
                        MessageBox.Show("Izabrani autor nije autor publikacije cije azuriranje ste zahtevali");
                    }
                }
                else 
                {
                    MessageBox.Show("Publikacija ima samo jednog autora. Brisanje nije moguce");
                }

                
            }
            catch(Exception ex)
            {  
                MessageBox.Show(ex.Message.ToString());
            }
            
        }
    }
}
