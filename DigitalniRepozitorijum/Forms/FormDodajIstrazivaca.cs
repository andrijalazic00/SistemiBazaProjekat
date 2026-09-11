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
using NHibernate;
using System.Xml.Serialization;
using DigitalniRepozitorijum.Forms;

namespace DigitalniRepozitorijum
{
    public partial class FormDodajIstrazivaca : Form
    {
        private Istrazivac _istrazivac;
        private IList<NaucnoIstrazivackaInstitucija> _institucije;

        private static readonly string[] _opcije = { "Rukovodilac projekta", "Administrator repozitorijuma", "Urednik", "Recezent", "Autor" };
        //private List<Mail> _mailovi;
        //private List<Telefon> _telefoni;
        public FormDodajIstrazivaca()
        {
            InitializeComponent();
            _istrazivac = new Istrazivac();

            
            cBoxUloga.Items.AddRange(_opcije);
            
            cBoxInstitucija.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxUloga.DropDownStyle = ComboBoxStyle.DropDownList;
            
            PopuniComboBox();
            
          
        }

        private void PopuniComboBox()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                _institucije = s.Query<NaucnoIstrazivackaInstitucija>().ToList();

                foreach (NaucnoIstrazivackaInstitucija nii in _institucije)
                {
                    cBoxInstitucija.Items.Add(nii.Naziv);
                }
                s.Close();
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
                this.Close();
            }
           
            
        }

        private void btnDodajIstrazivaca_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                _istrazivac.DatumRodjenja = dtpDatumRodjenja.Value;
                _istrazivac.Ime = tbIme.Text;
                _istrazivac.Prezime = tbPrezime.Text;
                _istrazivac.Drzava = tbDrzava.Text;
                _istrazivac.NaucnaOblast = tbNaucnaOblast.Text;
                _istrazivac.NaucnoZvanje = tbNaucnoZvanje.Text;
                _istrazivac.StatusNaucnika = cbAktivan.Checked?"AKTIVAN":"NEAKTIVAN";


               

                s.SaveOrUpdate(_istrazivac);
                

                s.Flush();
                s.Close();


                PoveziAngazovanje();

                this.Close();
            }
            
        
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void PoveziAngazovanje()
        {
            Form f;
            if (cBoxInstitucija.Text.Length > 0)
            {
                NaucnoIstrazivackaInstitucija nii = _institucije.First(i => i.Naziv == cBoxInstitucija.Text);

                f = new FormAngazovanje(_istrazivac, nii);
                f.ShowDialog();
            }
        }

        private async void btnDodajMail_Click(object sender, EventArgs e)
        {
            try 
            {
                if (tbMail.Text.Length > 0)
                {
                    Mail m = new Mail();
                    m.ID_I = _istrazivac;
                    _istrazivac.Mailovi.Add(m);
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
                Console.WriteLine(ex.ToString()); 
            }
        }

        private async void btnDodajTelefon_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbTelefon.Text.Length > 8 && tbTelefon.Text.Length < 16)
                {
                    Telefon t = new Telefon();
                    t.ID_I = _istrazivac;
                    _istrazivac.Telefoni.Add(t);
                    t.Broj = tbTelefon.Text;
                    //_telefoni.Add(t);
                    tbTelefon.Clear();
                    tbTelefon.Text = "Telefon dodat";
                    await Task.Delay(1000);
                    tbTelefon.Clear();
                }
                else
                {
                    tbTelefon.Text = "Telefon mora imati od 9-15 cifara";
                    await Task.Delay(1500);
                    tbTelefon.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void btnDodajUlogu_Click(object sender, EventArgs e)
        {
            if (cBoxUloga.Text.Length > 0)
            {
                
                Form f;
                switch (cBoxUloga.Text) 
                {
                    case "Administrator repozitorijuma":
                        AdministratorRepozitorijuma a = new AdministratorRepozitorijuma();
                        _istrazivac.Uloge.Add(a);
                        a.ID_I = _istrazivac;
                        f = new FormDodajAdministratora(a);
                        f.ShowDialog();
                        MessageBox.Show("Uloga dodata");

                        break;
                    case "Urednik":
                        Urednik u = new Urednik();
                        _istrazivac.Uloge.Add(u);
                        u.ID_I = _istrazivac;
                        f = new FormDodajUrednika(u);
                        f.ShowDialog();
                        MessageBox.Show("Uloga dodata");
                        break;

                    case "Recezent":
                        Recenzent r = new Recenzent();
                        _istrazivac.Uloge.Add(r);
                        r.ID_I = _istrazivac;
                        f = new FormDodajRecezenta(r);
                        f.ShowDialog();
                        MessageBox.Show("Uloga dodata");
                        break;
                    case "Autor":
                        Autor autor = new Autor();
                        _istrazivac.Uloge.Add(autor);
                        autor.ID_I = _istrazivac;
                        f = new FormDodajAutora(autor);
                        f.ShowDialog();
                        MessageBox.Show("Uloga dodata");
                        break;
                    case "Rukovodilac projekta":

                        RukovodilacProjekta rukovodilac = new RukovodilacProjekta();
                        _istrazivac.Uloge.Add(rukovodilac);
                        rukovodilac.ID_I = _istrazivac;
                        MessageBox.Show("Uloga dodata");
                        break;

                }
            }
            else
            {
                MessageBox.Show("Izaberite ulogu");
            }
        }

    }
}
