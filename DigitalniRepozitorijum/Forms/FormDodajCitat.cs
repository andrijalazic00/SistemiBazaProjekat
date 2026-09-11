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
        public FormDodajCitat()
        {
            InitializeComponent();
            PopuniComboBox();
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
                if(comboBCitirajucaPublikacija.SelectedValue==comboBCitiranaPublikacija.SelectedValue)
                {
                    MessageBox.Show("Izaberite dve razlicite publikacije");
                    return;
                }
                if(tbKontekstCitiranja.Text.Length<1 || tbMestoCitiranja.Text.Length<1)
                {
                    MessageBox.Show("Popunite polja kontekst citiranja i mesto citiranja");
                    return;
                }

                Publikacija citirana = (Publikacija)comboBCitiranaPublikacija.SelectedValue;
                Publikacija citirajuca= (Publikacija)comboBCitirajucaPublikacija .SelectedValue;

                Citat citat= new Citat(citirajuca,citirana);
                citat.TipCitata = cbTipCitata.Checked ? "DIREKTAN" : "INDIREKTAN";
                citat.MestoCitiranja = tbMestoCitiranja.Text;
                citat.KontekstCitiranja=tbKontekstCitiranja.Text;
                
                citirana.CitirajucePublikacije.Add(citat);
                citirajuca.CitiranePublikacije.Add(citat);

                _session.SaveOrUpdate(citirana);
                _session.SaveOrUpdate(citirajuca);
                _session.Flush();
                _session.Close();
                this.Close();
                MessageBox.Show("Uspesan upis");



            }
            catch(Exception ex) 
            {
                MessageBox.Show("Neuspesan upis" + ex.Message.ToString());
            }
        }
    }
}
