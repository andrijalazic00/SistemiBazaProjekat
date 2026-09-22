using DigitalniRepozitorijum.Entities;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.ServiceModel.Channels;
//using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forms
{
    public partial class FormDodajCitat : Form
    {
        private ISession _session;
        private Citat _citat;
        public FormDodajCitat()
        {
            InitializeComponent();
            _citat = null;
            PopuniComboBox();
        }

        public FormDodajCitat(Citat c)
        {
            InitializeComponent();
            _citat= c;
            PopuniPolja();
            //PopuniComboBox();
        }
        private void PopuniPolja()
        {
            try 
            {
                _session = DataLayer.GetSession();

                comboBCitirajucaPublikacija.Visible = false;
                comboBCitiranaPublikacija.Visible = false;
                lblCitirajucaPublikacija.Visible = false;
                lblCitiranaPublikacija.Visible=false;

                tbKontekstCitiranja.Text = _citat.KontekstCitiranja;
                tbMestoCitiranja.Text = _citat.MestoCitiranja;
                cbTipCitata.Checked = _citat.TipCitata == "DIREKTAN" ? true : false;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void PopuniComboBox()
        {
            try
            {
                _session = DataLayer.GetSession();
                List<Publikacija> publikacijaList = _session.Query<Publikacija>().ToList();
                List<Publikacija> publikacijaList2 = _session.Query<Publikacija>().ToList();

                if (publikacijaList.Count > 1)
                {
                    comboBCitirajucaPublikacija.DataSource = publikacijaList;
                    comboBCitirajucaPublikacija.DisplayMember = "ID_P";
                    
                    comboBCitiranaPublikacija.DataSource = publikacijaList2;
                    comboBCitiranaPublikacija.DisplayMember = "ID_P";
                   
                }
                else
                {
                    MessageBox.Show("Nema dovoljno publikacija u bazi. Kreirajte makar 2 publikacije.");

                    _session.Close();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Neuspesno popounjavanje combo box-ova" + ex.Message.ToString());
                _session.Close();
                this.Close();

            }
        }

        private void btnSacuvajCitat_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBCitirajucaPublikacija.SelectedValue==comboBCitiranaPublikacija.SelectedValue&&_citat==null)
                {
                    MessageBox.Show("Izaberite dve razlicite publikacije");
                    return;
                }
                if(tbKontekstCitiranja.Text.Length<1 || tbMestoCitiranja.Text.Length<1)
                {
                    MessageBox.Show("Popunite polja kontekst citiranja i mesto citiranja");
                    return;
                }
                if (_citat == null)
                {
                    Publikacija citirana = (Publikacija)comboBCitiranaPublikacija.SelectedValue;
                    Publikacija citirajuca = (Publikacija)comboBCitirajucaPublikacija.SelectedValue;
                    _citat = new Citat(citirajuca, citirana);
                    citirana.CitirajucePublikacije.Add(_citat);
                    citirajuca.CitiranePublikacije.Add(_citat);
                }

               
                _citat.TipCitata = cbTipCitata.Checked ? "DIREKTAN" : "INDIREKTAN";
                _citat.MestoCitiranja = tbMestoCitiranja.Text;
                _citat.KontekstCitiranja=tbKontekstCitiranja.Text;



                //_session.SaveOrUpdate(citirana);
                //_session.SaveOrUpdate(citirajuca);
                _session.SaveOrUpdate(_citat);
                _session.Flush();
                _session.Close();
                this.Close();
                MessageBox.Show("Citat sacuvan");



            }
            catch(Exception ex) 
            {
                MessageBox.Show("Neuspesan upis" + ex.Message.ToString());
            }
        }
    }
}
