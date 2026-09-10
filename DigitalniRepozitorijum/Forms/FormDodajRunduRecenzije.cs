using DigitalniRepozitorijum.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;

namespace DigitalniRepozitorijum.Forms
{
    public partial class FormDodajRunduRecenzije : Form
    {
        private ISession _session;
        private Publikacija _publikacija;
        private RundaRecenzije _rundaRecenzije;
        private AngazovanjeRecenzent _angazovanjeRecenzent;
        private Urednik _urednik;
        private Recenzent _recenzent;
        
        private List<Publikacija> _publikacijaList;
        private Dictionary<string,Urednik> _urednikDict;
        private Dictionary<string, Recenzent> _recenzentDict;
        private static readonly string[] _opcijeOdluka = { "PRIHVACENA", "ODBIJENA","POTREBNA_REVIZIJA" };

        public FormDodajRunduRecenzije()
        {
            InitializeComponent();
            PopuniComboBox();
            _rundaRecenzije=new RundaRecenzije();
            _angazovanjeRecenzent = new AngazovanjeRecenzent();
            _recenzent = new Recenzent();
            _urednik=new Urednik();

            
        }

        private void PopuniComboBox()
        {
            try 
            {
                comboBKonacnaOdluka.Items.AddRange(_opcijeOdluka);
                comboBKonacnaOdluka.DropDownStyle=ComboBoxStyle.DropDownList;
                comboBKonacnaOdluka.SelectedIndex = 0;

                _session = DataLayer.GetSession();

                _publikacijaList=_session.Query<Publikacija>().ToList();
                List<Urednik> urednikList=_session.Query<Urednik>().ToList();
                List<Recenzent> recenzentList=_session.Query<Recenzent>().ToList();
                
               
                
                //_publikacijaDict = publikacijaList.ToDictionary(i => i.ID_P);
                _urednikDict = urednikList.ToDictionary(i => i.ID_U + " " + i.ID_I.Ime + " " + i.ID_I.Prezime);
                _recenzentDict=recenzentList.ToDictionary(i => i.ID_U + " " + i.ID_I.Ime + " " + i.ID_I.Prezime);

                //Dictionary<int,string> urednikKeyDict = urednikList.ToDictionary(i => i.ID_U,i=>i.ID_U+" "+i.ID_I.Ime+" "+i.ID_I.Prezime);
                //Dictionary<int, string> recenzentKeyDict = recenzentList.ToDictionary(i => i.ID_U, i => i.ID_U + " " + i.ID_I.Ime + " " + i.ID_I.Prezime);
                if(_publikacijaList.Count>0)
                {
                    comboBPublikacija.DataSource = _publikacijaList;
                    comboBPublikacija.DisplayMember = "ID_P";
                }
                else 
                {
                    MessageBox.Show("Ne postoji ni jedna publikacija u bazi. Kreirajte publikaciju pre kreiranja runde recenzije");
                    _session.Close();
                    this.Close();
                }


                if (_urednikDict.Count > 0)
                {
                    comboBAngazovanUrednik.DataSource = new BindingSource(_urednikDict, null);
                    comboBAngazovanUrednik.DisplayMember = "Key";
                    comboBAngazovanUrednik.ValueMember = "Value";
                    comboBAngazovanUrednik.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                else
                {
                    MessageBox.Show("Ne postoji ni jedan urednik u bazi, dodajte urednika pre nego sto predjete na dodavanje rundi recenzije");
                    _session.Close();
                    this.Close();
                }
                
                if(_recenzentDict.Count>0)
                {
                    comboBAngazovanRecenzent.DataSource = new BindingSource(_recenzentDict, null);
                    comboBAngazovanRecenzent.DisplayMember = "Key";
                    comboBAngazovanRecenzent.ValueMember = "Value";
                    comboBAngazovanRecenzent.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                else
                {
                    MessageBox.Show("Ne postoji ni jedan recenzent u bazi, dodajte recenzenta pre nego sto predjete na dodavanje rundi recenzije");
                    _session.Close();
                    this.Close();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message + " Neuspesno popunjavanje kombo boxeve");
                _session.Close();
                this.Close();

            }
        }

        private void btnDodajOcenu_Click(object sender, EventArgs e)
        {
            comboBAngazovanRecenzent.Enabled = false;
            
            OcenaRecenzenta ocena=new OcenaRecenzenta();
            ocena.Ocena = (int)nudOcena.Value;
            ocena.AngazovanjeRecenzent=_angazovanjeRecenzent;
            _angazovanjeRecenzent.Ocene.Add(ocena);

            btnDodajRecenzenta.Enabled = true;

        }

        private void btnDodajRecenzenta_Click(object sender, EventArgs e)
        {
            //comboBAngazovanRecenzent.Items.(comboBAngazovanRecenzent.SelectedItem);
            
            _recenzent = (Recenzent)comboBAngazovanRecenzent.SelectedValue;
            
            _angazovanjeRecenzent.ID_Recenzenta = _recenzent;
            _angazovanjeRecenzent.ID_P=_publikacija;
            _angazovanjeRecenzent.Preporuka = cbPreporuka.Checked ? "DA" : "NE";
            _angazovanjeRecenzent.BrojRunde = (int)nudBrojRunde.Value;
            
            _recenzent.RundeRecenzije.Add(_angazovanjeRecenzent);
            _rundaRecenzije.Recenzenti.Add(_angazovanjeRecenzent);

            comboBAngazovanRecenzent.Enabled = true;
            btnSacuvajRunduRecenzije.Enabled = true;
        }

        private void btnSacuvajRunduRecenzije_Click(object sender, EventArgs e)
        {
            try
            {
                _urednik = (Urednik)comboBAngazovanUrednik.SelectedValue;

                _rundaRecenzije.BrojRunde = (int)nudBrojRunde.Value;
                _rundaRecenzije.DatumOdluke = dtpDatumOdluke.Value;
                _rundaRecenzije.KonacnaOdluka = comboBKonacnaOdluka.Text;
                _rundaRecenzije.ID_Urednika = _urednik;
                _rundaRecenzije.ID_P = _publikacija;
                _publikacija.RundeRecenzije.Add(_rundaRecenzije);
                _urednik.RundeRecenzije.Add(_rundaRecenzije);

                _session.SaveOrUpdate(_urednik);
                _session.SaveOrUpdate(_recenzent);
                _session.Save(_rundaRecenzije);
                _session.Flush();
                _session.Close();
                this.Close();
                MessageBox.Show("Uspesan upis");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Neuspesan upis");
                _session.Close();
                this.Close();
            }


        }

        private void btnIzaberiPublikaciju_Click(object sender, EventArgs e)
        {
            //_publikacija = _publikacijaDict[(int)comboBPublikacija.SelectedValue];
            _publikacija=(Publikacija)comboBPublikacija.SelectedValue;
            gbKontrole.Enabled = true;
            btnSacuvajRunduRecenzije.Enabled = false;
            btnDodajRecenzenta.Enabled = false;
            comboBPublikacija.Enabled = false;
            btnIzaberiPublikaciju.Enabled = false;

        }
    }
}
