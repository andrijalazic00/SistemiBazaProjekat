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
    public partial class FormDataset : Form
    {
        private Dataset _dataset;

        public FormDataset()
        {
            InitializeComponent();
        }

        public FormDataset(Dataset set)
        {
            InitializeComponent();
            _dataset = set;
            nudBrojZapisa.Maximum=int.MaxValue;
            nudVelicina.Maximum=int.MaxValue;
            
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
                    session.Save(_dataset);

                }
                else
                {
                    MessageBox.Show("Popunite sva polja");
                }
                session.Flush();
                session.Close();
                this.Close();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
