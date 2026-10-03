using DigitalniRepozitorijum.Entities;
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

namespace DigitalniRepozitorijum.Forms
{
    public partial class FormIzmeniNII : Form
    {
        private NaucnoIstrazivackaInstitucija _institucija;
        private Dictionary<string, NaucnoIstrazivackaInstitucija> _institucijaDict;
        private ISession _session;

        public FormIzmeniNII()
        {
            InitializeComponent();
            PopuniComboBox();
            this.Icon = Resources.Edit;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void PopuniComboBox()
        {
            try
            {
                _session = DataLayer.GetSession();
                List<NaucnoIstrazivackaInstitucija> institucijaList = _session.Query<NaucnoIstrazivackaInstitucija>().ToList();
                _institucijaDict = institucijaList.ToDictionary(i => i.Naziv);
                
                if (_institucijaDict.Count == 0)
                {

                    _session.Close();
                    MessageBox.Show("Nema institucija u bazi");
                    this.Close();
                }
                comboBInstitucija.DataSource = new BindingSource(_institucijaDict, null);
                comboBInstitucija.DisplayMember = "Key";
                comboBInstitucija.ValueMember = "Value";
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message.ToString()); 
            }
        }

        private async void btnDodajTelefon_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbTelefon.Text.Length > 8 && tbTelefon.Text.Length < 16)
                {
                    TelefonInstitucija t = new TelefonInstitucija();
                    t.ID_NII = _institucija;
                    _institucija.Telefoni.Add(t);
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
                Console.WriteLine(ex.ToString());
            }
        }

        private async void btnDodajMail_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbMail.Text.Length > 0)
                {
                    MailInstitucija m = new MailInstitucija();
                    m.ID_NII = _institucija;
                    _institucija.Mailovi.Add(m);
                    m.MailAdresa = tbMail.Text;
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

        private async void btnDodajNaucnuOblast_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNaucnaOblast.Text.Length > 0)
                {
                    NaucnaOblast n = new NaucnaOblast();
                    n.ID_NII = _institucija;
                    _institucija.NaucneOblasti.Add(n);
                    n.Oblast = tbNaucnaOblast.Text;
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
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnObrisiMail_Click(object sender, EventArgs e)
        {
            try 
            {
                Form form = new FormObrisiMail(_institucija);
                form.ShowDialog();
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message.ToString());
            }
            
        }

        private void btnObrisiTelefon_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = new FormObrisiTelefon(_institucija);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            
        }

        private void btnObrisiNaucnuOblast_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = new FormObrisiNaucnuOblast(_institucija);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBInstitucija.Text.Length > 0)
                {
                    _institucija = (NaucnoIstrazivackaInstitucija)comboBInstitucija.SelectedValue;
                    
                    _session.Delete(_institucija);
                    _session.Flush();
                    _session.Close();
                    MessageBox.Show("Naucno istrazivacka institucija obrisana");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nije izabrana institucija");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBInstitucija.Text.Length > 0)
                {
                    _institucija = (NaucnoIstrazivackaInstitucija)comboBInstitucija.SelectedValue;
                    
                    gbAzuriranje.Enabled = true;
                    gbObrisi.Enabled = false;
                    tbNaziv.Text = _institucija.Naziv;
                    tbAdresa.Text = _institucija.Adresa;
                }
                else
                {
                    MessageBox.Show("Nije izabrana institucija");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnSacuvajPromene_Click(object sender, EventArgs e)
        {
            try
            {


                _institucija.Naziv =tbNaziv.Text;
                _institucija.Adresa =tbAdresa.Text;

                _session.SaveOrUpdate(_institucija);
                _session.Flush();
                _session.Close();
                MessageBox.Show("Promene sacuvane");
                this.Close();
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
