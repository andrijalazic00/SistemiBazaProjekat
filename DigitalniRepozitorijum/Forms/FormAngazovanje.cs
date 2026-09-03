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
        private NaucnoIstrazivackaInstitucija _institucija;
        private Istrazivac _istrazivac;
        public FormAngazovanje()
        {
            InitializeComponent();
        }

        public FormAngazovanje(Istrazivac i, NaucnoIstrazivackaInstitucija nii)
        {
            InitializeComponent();
            _istrazivac = i;
            _institucija = nii;
            comboBInstitucija.Hide();
            comboBIstrazivac.Hide();
            lblIstrazivac.Hide();
            lblInstitucija.Hide();
        }

        private void btnDodajAngazovanje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
