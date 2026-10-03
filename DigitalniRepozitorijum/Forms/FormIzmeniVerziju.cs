using DigitalniRepozitorijum.Entities;
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
    public partial class FormIzmeniVerziju : Form
    {
        private IstrazivackiRezultat _istrazivackiRezultat;
        private Verzija _verzija;

        public FormIzmeniVerziju()
        {
            InitializeComponent();
        }
        public FormIzmeniVerziju(Verzija v, IstrazivackiRezultat i)
        {
            InitializeComponent();
            _verzija = v;
            _istrazivackiRezultat = i;
            dtpDatumPostavljanja.Value = _verzija.DatumPostavljanja;
            tbOdgovornaOsoba.Text=_verzija.OdgovornaOsoba;
            tbOpisIzmena.Text = _verzija.OpisIzmena;

            this.Icon = Resources.Edit;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private async void btnDodajFajl_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNazivFajla.Text.Length > 0)
                {
                    PripadajuciFajl f = new PripadajuciFajl();
                    f.NazivFajla = tbNazivFajla.Text;
                    f.BrojVerzije = _verzija.BrojVerzije;
                    f.ID_IR = _istrazivackiRezultat;
                    _istrazivackiRezultat.PripadajuciFajlovi.Add(f);

                    tbNazivFajla.Clear();
                    tbNazivFajla.Text = "Fajl dodat";
                    await Task.Delay(1000);
                    tbNazivFajla.Clear();
                }
                else
                {
                    tbNazivFajla.Clear();
                    tbNazivFajla.Text = "Upisite naziv";
                    await Task.Delay(1000);
                    tbNazivFajla.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private async void btnSacuvajVerziju_Click(object sender, EventArgs e)
        {
            try
            {
                _verzija = new Verzija();
                if (tbOdgovornaOsoba.Text.Length > 0 && tbOpisIzmena.Text.Length > 0)
                {

                    
                    _verzija.DatumPostavljanja = dtpDatumPostavljanja.Value;
                    _verzija.OdgovornaOsoba = tbOdgovornaOsoba.Text;
                    _verzija.OpisIzmena = tbOpisIzmena.Text;
                    _verzija.ID_IR = _istrazivackiRezultat;
                    MessageBox.Show("Verzija izmenjena");
                    this.Close();

                }
                else
                {
                    tbOdgovornaOsoba.Text = "Upisite osobu";
                    tbOpisIzmena.Text = "Upisite izmene";
                    await Task.Delay(1000);
                    tbOpisIzmena.Clear();
                    tbOdgovornaOsoba.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        
        }

        private void btnObrisiFajl_Click(object sender, EventArgs e)
        {
            try 
            {
                Form f = new FormObrisiFajl(_verzija, _istrazivackiRezultat);
                f.ShowDialog();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString()); 
            }
            
        }
    }
}
