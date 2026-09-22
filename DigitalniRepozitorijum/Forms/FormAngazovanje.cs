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
    public partial class FormAngazovanje : Form
    {
        private Angazovanje _angazovanje;
        private NaucnoIstrazivackaInstitucija _institucija;
        private Istrazivac _istrazivac;
        //private List<Istrazivac> _istrazivaciList;
        private Dictionary<int, Istrazivac> _istrazivacDict;
        private List<NaucnoIstrazivackaInstitucija> _institucijeList;
        private bool _fromIstrazivac;
        public FormAngazovanje()
        {
            InitializeComponent();
            _angazovanje = null;
            _fromIstrazivac = false;
            comboBTip.Items.Add("STALNI");
            comboBTip.Items.Add("PRIVREMEN");
            PopuniComboBoxove();

        }

        public FormAngazovanje(Istrazivac i, NaucnoIstrazivackaInstitucija nii)
        {
            InitializeComponent();
            _istrazivac = i;
            _institucija = nii;
            _angazovanje = null;
            _fromIstrazivac = true;
            comboBInstitucija.Hide();
            comboBIstrazivac.Hide();
            lblIstrazivac.Hide();
            lblInstitucija.Hide();
            comboBTip.Items.Add("STALNI");
            comboBTip.Items.Add("PRIVREMEN");
        }

        public FormAngazovanje(Angazovanje a)
        {
            InitializeComponent();
            _angazovanje = a;
            _fromIstrazivac = true;
            comboBInstitucija.Hide();
            comboBIstrazivac.Hide();
            lblIstrazivac.Hide();
            lblInstitucija.Hide();
            comboBTip.Items.Add("STALNI");
            comboBTip.Items.Add("PRIVREMEN");
            comboBTip.DropDownStyle = ComboBoxStyle.DropDownList;
            PopuniPolja();
        }

        public void PopuniPolja()
        {
            try 
            {
                tbNazivPozicije.Text = _angazovanje.NazivPozicije;
                tbOrganizacionaJedinica.Text = _angazovanje.TipAngazovanja;
                comboBTip.Text = _angazovanje.TipAngazovanja;
                dtpDatumPocetka.Value = _angazovanje.DatumAngazovanja;
                dtpDatumZavrsetka.Value=(DateTime)_angazovanje.DatumZavrsetka;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void PopuniComboBoxove()
        {
            try 
            {
                ISession s = DataLayer.GetSession();

                _institucijeList = s.Query<NaucnoIstrazivackaInstitucija>().ToList();

                foreach (NaucnoIstrazivackaInstitucija nii in _institucijeList)
                {
                    comboBInstitucija.Items.Add(nii.Naziv);
                }


                List<Istrazivac> istrazivaciList= s.Query<Istrazivac>().ToList();
                _istrazivacDict = istrazivaciList.ToDictionary(i => i.ID_I);
                Dictionary<int, String> istrazivacDictKeyName = istrazivaciList.ToDictionary(i => i.ID_I, i=>i.Ime+" "+i.Prezime+" "+i.DatumRodjenja.ToString());
                if(istrazivacDictKeyName.Count==0)
                {
                    
                    s.Close();
                    MessageBox.Show("Nema istrazivaca u bazi");
                    this.Close();
                }
                comboBIstrazivac.DataSource = new BindingSource(istrazivacDictKeyName, null);
                comboBIstrazivac.DisplayMember= "Value";
                comboBIstrazivac.ValueMember = "Key";

                comboBInstitucija.DropDownStyle=ComboBoxStyle.DropDownList;
                comboBIstrazivac.DropDownStyle=ComboBoxStyle.DropDownList;
                comboBTip.DropDownStyle=ComboBoxStyle.DropDownList;

                s.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Neuspesno prpbavljanje entiteta"+ex.Message.ToString());
                this.Close();
            } 
        }

        private void btnDodajAngazovanje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Angazovanje a =new Angazovanje();
                if (_angazovanje != null)
                    a = _angazovanje;
                if(tbNazivPozicije.Text.Length >0
                    &&tbOrganizacionaJedinica.Text.Length>0
                    &&comboBTip.Text.Length>0)
                {
                    a.NazivPozicije = tbNazivPozicije.Text;
                    a.OrganizacionaJedinica = tbOrganizacionaJedinica.Text;
                    a.TipAngazovanja= comboBTip.Text;
                    if (dtpDatumPocetka.Value < dtpDatumZavrsetka.Value)
                    {
                        a.DatumAngazovanja = dtpDatumPocetka.Value;
                        a.DatumZavrsetka=dtpDatumZavrsetka.Value;
                    }
                    else
                    {
                        MessageBox.Show("Datum angazovanje kasniji od datuma zavrsetka");
                    }
                    if(!_fromIstrazivac)
                    {
                        if (comboBInstitucija.Text.Length > 0 && comboBIstrazivac.Text.Length > 0)
                        {
                            int id_i = (int)comboBIstrazivac.SelectedValue;
                            //string  id_nii= comboBInstitucija.Text;
                            
                            //_institucija= _institucijeList.First(i => i.Naziv == comboBInstitucija.Text);
                            a.ID_NII = _institucijeList.First(i => i.Naziv == comboBInstitucija.Text);
                            a.ID_I = _istrazivacDict[id_i];

                            //a.ID_NII = comboBInstitucija.Text;
                        }
                        else 
                        {
                            MessageBox.Show("Nije izabran istrazivac ili institucija");
                        }
                    }
                    else if(_angazovanje==null)
                    {
                        a.ID_I = _istrazivac;
                        a.ID_NII = _institucija;
                       // s.Save(_istrazivac);
                    }


                }
                else
                {
                    MessageBox.Show("Nije izabran naziv, organizaciona jedinica ili tip angazovanja");

                }
                
                s.SaveOrUpdate(a);
                s.Flush();
                s.Close();
                if (_fromIstrazivac)
                    this.Close();
                
                MessageBox.Show("Angazovanje sacuvano");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
