using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using DigitalniRepozitorijum.Entities;

namespace DigitalniRepozitorijum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DodajNII_Click(object sender, EventArgs e)
        {
            try 
            {
                ISession s = DataLayer.GetSession();

                NaucnoIstrazivackaInstitucija n2 = s.Load<NaucnoIstrazivackaInstitucija>(1);
                NaucnoIstrazivackaInstitucija n = new NaucnoIstrazivackaInstitucija();
                n.Naziv = "Institut Podvodnih Istrazivanja";
                n.Adresa = "Nikole Tesle 32";
                s.SaveOrUpdate(n);
                s.Flush();

                s.Close();
                
            }
            catch(Exception ec) 
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
