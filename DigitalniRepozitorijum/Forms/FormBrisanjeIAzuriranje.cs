using DigitalniRepozitorijum.Properties;
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
            this.Icon = Resources.Edit;
            this.BackColor = System.Drawing.Color.Honeydew;
        }

        private void btnIzmeniIstrazivaca_Click(object sender, EventArgs e)
        {
            try {
                Form form = new FormIzmeniIstrazivaca();
                form.ShowDialog();
            }
            catch(Exception ex) { Console.WriteLine(ex.Message.ToString()); }
            
        }

        private void btnIzmeniNII_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = new FormIzmeniNII();
                form.ShowDialog();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString()); }
           
        }

        private void btnIzmeniIstrazivackiRezultat_Click(object sender, EventArgs e)
        {
            try {
                Form form = new FormIzmeniIR();
                form.ShowDialog();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString()); }
            
        }

        private void btnIzmeniPublikaciju_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = new FormIzmeniPublikaciju();
                form.ShowDialog();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString()); }
        }

        private void btnIzmeniAngazovanje_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = new FormIzmeniAngazovanje();
                form.ShowDialog();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString()); }
            

        }

        private void btnObrisiUlogu_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = new FormObrisiUlogu();
                form.ShowDialog();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString()); }
        }

        private void btnIzmeniCitat_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = new FormIzmeniCitat();
                form.ShowDialog();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString()); }
        }

        private void btnIzmeniRunduRecenzije_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = new FormIzmeniRunduRecenzije();
                form.ShowDialog();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString()); }
        }
    }
}
