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
    public partial class FormBrisanjeIAzuriranje : Form
    {
        public FormBrisanjeIAzuriranje()
        {
            InitializeComponent();
        }

        private void btnIzmeniIstrazivaca_Click(object sender, EventArgs e)
        {
            try {
                Form form = new FormIzmeniIstrazivaca();
                form.ShowDialog();
            }
            catch(Exception ex) { }
            
        }

        private void btnIzmeniNII_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = new FormIzmeniNII();
                form.ShowDialog();
            }
            catch (Exception ex) { }
           
        }

        private void btnIzmeniIstrazivackiRezultat_Click(object sender, EventArgs e)
        {
            try {
                Form form = new FormIzmeniIR();
                form.ShowDialog();
            }
            catch (Exception ex) { }
            
        }
    }
}
