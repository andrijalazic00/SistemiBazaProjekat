using DigitalniRepozitorijum.Entities;
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
    public partial class FormVerzija : Form
    {
        private IstrazivackiRezultat _istrazivackiRezultat;
        private Verzija _verzija;

        public FormVerzija()
        {
            InitializeComponent();
        }

        public FormVerzija(IstrazivackiRezultat istrazivackiRezultat)
        {
            InitializeComponent();
            _istrazivackiRezultat = istrazivackiRezultat;
           
            //_istrazivackiRezultat.PripadajuciFajlovi.Add(new PripadajuciFajl());

        }

        private async void btnDodajFajl_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbNazivFajla.Text.Length>0)
                {
                    PripadajuciFajl f=new PripadajuciFajl();
                    f.NazivFajla=tbNazivFajla.Text;
                    f.BrojVerzije = (int)nudBrojVerzije.Value;
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
                if (tbOdgovornaOsoba.Text.Length>0 && tbOpisIzmena.Text.Length>0)
                {
                    _verzija.BrojVerzije = (int)nudBrojVerzije.Value;
                    _verzija.DatumPostavljanja=dtpDatumPostavljanja.Value;
                    _verzija.OdgovornaOsoba = tbOdgovornaOsoba.Text;
                    _verzija.OpisIzmena = tbOpisIzmena.Text;
                    _verzija.ID_IR = _istrazivackiRezultat;
                    _istrazivackiRezultat.Verzije.Add(_verzija);
                    MessageBox.Show("Verzija dodata");
                    //this.Close();

                }
                else
                {
                    tbOdgovornaOsoba.Text="Upisite osobu";
                    tbOpisIzmena.Text = "Upisite izmene";
                    await Task.Delay (1000);
                    tbOpisIzmena.Clear ();
                    tbOdgovornaOsoba.Clear();

                }
            }
            catch(Exception ex)
            {  
                MessageBox.Show(ex.Message.ToString()); 
            }
        }
    }
}
