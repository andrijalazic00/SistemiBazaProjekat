using DigitalniRepozitorijum.Entities;
using DigitalniRepozitorijum.Properties;
using NHibernate;
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

namespace DigitalniRepozitorijum.Forms
{
    public partial class FormDodajDataset : Form
    {
        private Dataset _dataset;

        public FormDodajDataset()
        {
            InitializeComponent();
        }

        public FormDodajDataset(Dataset set)
        {
            InitializeComponent();
            _dataset = set;
            nudBrojZapisa.Maximum=int.MaxValue;
            nudVelicina.Maximum=int.MaxValue;

            this.Icon = Resources.Plus;
            this.BackColor = System.Drawing.Color.Azure;

        }

        public FormDodajDataset(Dataset set, bool b) //b postoji samo da bi se konstruktor razlikovao od prethodnog 
        {
            InitializeComponent();
            _dataset = set;
            nudBrojZapisa.Maximum = int.MaxValue;
            nudVelicina.Maximum = int.MaxValue;
            tbFormat.Text=_dataset.Format;
            tbLicencaKoriscenja.Text=_dataset.LicencaKoriscenja;
            tbOgranicanjaPristupa.Text = _dataset.OgranicenjaPristupa;
            tbOpisStrukture.Text= _dataset.OpisStrukture;
            tbPeriodObuhvatanja.Text = _dataset.PeriodObuhvataPodataka;
            nudBrojZapisa.Value= _dataset.BrojZapisa;
            nudVelicina.Value= _dataset.Velicina;

            this.Text = "Izmena dataset-a";
            this.Icon = Resources.Edit;
            this.BackColor = System.Drawing.Color.Honeydew;
        }

        private void btnSacuvajDataset_Click(object sender, EventArgs e)
        {
            try 
            {
                ISession session = DataLayer.GetSession();
                if (tbFormat.Text.Length > 0 && nudBrojZapisa.Value > 0 && nudVelicina.Value > 0 && 
                    tbLicencaKoriscenja.Text.Length > 0 && tbOgranicanjaPristupa.Text.Length > 0 && 
                    tbOpisStrukture.Text.Length > 0 && tbPeriodObuhvatanja.Text.Length > 0)
                {
                    _dataset.Format = tbFormat.Text;
                    _dataset.Velicina = (int)nudVelicina.Value;
                    _dataset.BrojZapisa = (int)nudBrojZapisa.Value;
                    _dataset.OpisStrukture = tbOpisStrukture.Text;
                    _dataset.PeriodObuhvataPodataka = tbPeriodObuhvatanja.Text;
                    _dataset.LicencaKoriscenja = tbLicencaKoriscenja.Text;
                    _dataset.OgranicenjaPristupa=tbOgranicanjaPristupa.Text;
                    session.SaveOrUpdate(_dataset);
                    session.Flush();
                    session.Close();
                    this.Close();
                    MessageBox.Show("Dataset sacuvan");

                }
                else
                {
                    MessageBox.Show("Popunite sva polja");
                }
               
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
