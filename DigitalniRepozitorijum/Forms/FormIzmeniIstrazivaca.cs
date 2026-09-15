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
    public partial class FormIzmeniIstrazivaca : Form
    {
        private Istrazivac _istrazivac;

        private Dictionary<int, Istrazivac> _istrazivacDict;
        private ISession _session;

        private static readonly string[] _opcije = { "Rukovodilac projekta", "Administrator repozitorijuma", "Urednik", "Recezent", "Autor" };
        public FormIzmeniIstrazivaca()
        {
            InitializeComponent();
            _istrazivac = new Istrazivac();


            cBoxUloga.Items.AddRange(_opcije);

            //cBoxInstitucija.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxUloga.DropDownStyle = ComboBoxStyle.DropDownList;
            PopuniComboBox();
           
        }

        private void PopuniComboBox()
        {
            try
            {
                _session=DataLayer.GetSession();
                List<Istrazivac> istrazivaciList = _session.Query<Istrazivac>().ToList();
                _istrazivacDict = istrazivaciList.ToDictionary(i => i.ID_I);
                Dictionary<int, String> istrazivacDictKeyName = istrazivaciList.ToDictionary(i => i.ID_I, i => i.Ime + " " + i.Prezime + " " + i.DatumRodjenja.ToString());
                if (istrazivacDictKeyName.Count == 0)
                {

                    _session.Close();
                    MessageBox.Show("Nema istrazivaca u bazi");
                    this.Close();
                }
                comboBIstrazivac.DataSource = new BindingSource(istrazivacDictKeyName, null);
                comboBIstrazivac.DisplayMember = "Value";
                comboBIstrazivac.ValueMember = "Key";
            }
            catch (Exception ex){ MessageBox.Show(ex.Message.ToString()); }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBIstrazivac.Text.Length > 0)
                {
                    int id_i = (int)comboBIstrazivac.SelectedValue;
                    _istrazivac = _istrazivacDict[id_i];
                    _session.Delete(_istrazivac);
                    _session.Flush();
                    _session.Close();
                    this.Close();
                    //a.ID_NII = comboBInstitucija.Text;
                }
                else
                {
                    MessageBox.Show("Nije izabran istrazivac");
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBIstrazivac.Text.Length > 0)
                {
                    int id_i = (int)comboBIstrazivac.SelectedValue;
                    _istrazivac = _istrazivacDict[id_i];
                    gbAzuriranje.Enabled = true;
                    gbObrisi.Enabled = false;
                    tbIme.Text = _istrazivac.Ime;
                    tbPrezime.Text=_istrazivac.Prezime;
                    tbNaucnaOblast.Text = _istrazivac.NaucnaOblast;
                    tbNaucnoZvanje.Text = _istrazivac.NaucnoZvanje;
                    dtpDatumRodjenja.Value=_istrazivac.DatumRodjenja;
                    tbDrzava.Text=_istrazivac.Drzava;
                    cbAktivan.Checked=_istrazivac.StatusNaucnika=="AKTIVAN"?true:false;

                }
                else
                {
                    MessageBox.Show("Nije izabran istrazivac");
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

        private void btnSacuvajIzmene_Click(object sender, EventArgs e)
        {
            try
            {
                

                _istrazivac.DatumRodjenja = dtpDatumRodjenja.Value;
                _istrazivac.Ime = tbIme.Text;
                _istrazivac.Prezime = tbPrezime.Text;
                _istrazivac.Drzava = tbDrzava.Text;
                _istrazivac.NaucnaOblast = tbNaucnaOblast.Text;
                _istrazivac.NaucnoZvanje = tbNaucnoZvanje.Text;
                _istrazivac.StatusNaucnika = cbAktivan.Checked ? "AKTIVAN" : "NEAKTIVAN";




                _session.SaveOrUpdate(_istrazivac);


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

        private void btnObrisiMail_Click(object sender, EventArgs e)
        {
            Form form = new FormObrisiMail(_istrazivac);
            form.ShowDialog();
        }

        private void btnObrisiTelefon_Click(object sender, EventArgs e)
        {
            Form form = new FormObrisiTelefon(_istrazivac);
            form.ShowDialog();
        }

        private void btnObrisiUlogu_Click(object sender, EventArgs e)
        {
            Form form = new FormObrisiUlogu(_istrazivac);
            form.ShowDialog();
        }
    }
}
