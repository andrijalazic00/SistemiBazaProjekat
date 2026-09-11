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
        //private Publikacija _publikacija;
        private ISession _session;
        private Dictionary<string, Autor> _autorDict;
        private Dictionary<string, Dataset> _datasetDict;
        private Dictionary<string, TehnickiIzvestaj> _tehnickiIzvestajDict;
        private Dictionary<string, SoftverskiArtifakt> _softverskiArtifaktDict;

        public FormDodajPublikaciju()
        {
            InitializeComponent();
            nudRedniBrojAutora.Minimum = 1;
            PopuniComboBox();
        }

        public void PopuniComboBox()
        {
            try
            {
                _session = DataLayer.GetSession();

                List<Autor> autorList = _session.Query<Autor>().ToList();
                List<Dataset> datasetList;//=_session.Query<Dataset>().ToList();
                List<SoftverskiArtifakt> softverskiArtifaktList;//= _session.Query<SoftverskiArtifakt>().ToList();
                List<TehnickiIzvestaj> tehnickiIzvestajList;// = _session.Query<TehnickiIzvestaj>().ToList();

                //_session.Clear();
                datasetList =_session.Query<Dataset>().ToList();
                softverskiArtifaktList = _session.Query<SoftverskiArtifakt>().ToList();               
                tehnickiIzvestajList = _session.Query<TehnickiIzvestaj>().ToList();

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
       
                if (tbTipDoprinosa.Text.Length>0 &&tbUlogaUPublikaciji.Text.Length>0)
                {
                    Publikacija publikacija=new Publikacija();
                    Autor autor =(Autor)comboBAutor.SelectedValue;
                    Autorstvo autrostvo=new Autorstvo(autor,publikacija);
                    autrostvo.TipDoprinosa=tbTipDoprinosa.Text;
                    autrostvo.RedniBrojAutora = (int)nudRedniBrojAutora.Value;
                    autrostvo.UlogaUPublikaciji = tbUlogaUPublikaciji.Text;

                    if (comboBZasnivaSeNa.SelectedValue != null)
                        publikacija.DatasetID = (Dataset)comboBZasnivaSeNa.SelectedValue;
                    if (comboBKoriscen.SelectedValue != null)
                        publikacija.SoftverskiArtifaktID = (SoftverskiArtifakt)comboBKoriscen.SelectedValue;
                    if (comboBNastalaIz.SelectedValue != null)
                        publikacija.TehnickiIzvestajID = (TehnickiIzvestaj)comboBNastalaIz.SelectedValue;

                    publikacija.Autorstva.Add(autrostvo);
                    autor.Autorstva.Add(autrostvo);

                    
                    _session.Save(publikacija);
                    _session.SaveOrUpdate(autor);
                    _session.Flush();
                    _session.Close();
                    MessageBox.Show("Unos uspesan");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Popunite prazna polja");
                    

                }
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
    }
}
