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

namespace DigitalniRepozitorijum
{
    public partial class FormDodajNII : Form
    {
        private NaucnoIstrazivackaInstitucija _nii;

        public FormDodajNII()
        {
            InitializeComponent();
            _nii =new NaucnoIstrazivackaInstitucija();

            this.Icon = Properties.Resources.Plus;
            this.BackColor = System.Drawing.Color.Azure;
        }

        private void btnDodajNII_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                _nii.Naziv=tbNaziv.Text;
                _nii.Adresa=tbAdresa.Text;
                

                s.Save(_nii);
                s.Flush();
                s.Close();
                MessageBox.Show("Istitucija dodata");
                this.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private async void btnDodajTelefon_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbTelefon.Text.Length > 8 && tbTelefon.Text.Length<16)
                {
                    TelefonInstitucija t = new TelefonInstitucija();
                    t.ID_NII = _nii;
                    _nii.Telefoni.Add(t);
                    t.Broj = tbTelefon.Text;
                    
                    tbTelefon.Clear();
                    tbTelefon.Text = "Telefon dodat";
                    await Task.Delay(1000);
                    tbTelefon.Clear();
                }
                else
                {
                    tbTelefon.Text = "telefon mora imati od 9-15 cifara";
                    await Task.Delay(1500);
                    tbTelefon.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private async void btnDodajMail_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbMail.Text.Length > 0)
                {
                    MailInstitucija m = new MailInstitucija();
                    m.ID_NII = _nii;
                    _nii.Mailovi.Add(m);
                    m.MailAdresa = tbMail.Text;
                    //_mailovi.Add(m);
                    tbMail.Clear();
                    tbMail.Text = "Mail dodat";
                    await Task.Delay(1000);
                    tbMail.Clear();
                }
                else
                {
                    tbMail.Text = "Unesite mail";
                    await Task.Delay(1000);
                    tbMail.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private async void btnDodajNaucnuOblast_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbNaucnaOblast.Text.Length > 0)
                {
                    NaucnaOblast n=new NaucnaOblast();
                    n.ID_NII = _nii;
                    _nii.NaucneOblasti.Add(n);
                    n.Oblast=tbNaucnaOblast.Text;
                    tbNaucnaOblast.Clear();
                    tbNaucnaOblast.Text = "Oblast dodata";
                    await Task.Delay(1000);
                    tbNaucnaOblast.Clear();
                }
                else
                {
                    tbNaucnaOblast.Text = "Unesite oblast";
                    await Task.Delay(1000);
                    tbNaucnaOblast.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
