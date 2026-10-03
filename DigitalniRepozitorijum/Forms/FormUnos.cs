using DigitalniRepozitorijum.Entities;
using DigitalniRepozitorijum.Forms;
using DigitalniRepozitorijum.Properties;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalniRepozitorijum
{
    public partial class FormUnos : Form
    {
        public FormUnos()
        {

            InitializeComponent();
            this.Icon = Resources.Plus;
            this.BackColor = System.Drawing.Color.Azure;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Unos podataka";
        }

       

        private void btnDodajIstrazivaca_Click(object sender, EventArgs e)
        {
            try
            {

                Form form = new FormDodajIstrazivaca();
                form.ShowDialog();
                                                         
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void btnDodajNII_Click(object sender, EventArgs e)
        {
            try
            {

                Form form = new FormDodajNII();
                form.ShowDialog();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnDodajUlogu_Click(object sender, EventArgs e)
        {
            try
            {
                Form dodajUlogu=new FormDodajUlogu();
                dodajUlogu.ShowDialog();
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString() ); 
            }
        }

        private void btnDodajIR_Click(object sender, EventArgs e)
        {
            try
            {
                Form f = new FormDodajIstrazivackiRezultat();
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnPoveziIstrazivacNII_Click(object sender, EventArgs e)
        {
            try
            {
               

                Form angazovanje = new FormDodajAngazovanje();
                angazovanje.ShowDialog();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void btnDodajPublikaciju_Click(object sender, EventArgs e)
        {
            try
            {
                Form publikacija = new FormDodajPublikaciju();
                publikacija.ShowDialog();                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnDodajCitat_Click(object sender, EventArgs e)
        {
            try
            {
                Form dodajICitat = new FormDodajCitat();
                dodajICitat.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        private void btnDodajRundu_Click(object sender, EventArgs e)
        {
            try 
            {
                Form rundaRecenzije = new FormDodajRunduRecenzije();
                rundaRecenzije.ShowDialog();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        
    }
}
