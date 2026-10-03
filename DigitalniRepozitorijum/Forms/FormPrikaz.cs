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

    public partial class FormPrikaz : Form
    {
        private List<IstrazivackiRezultat> _rezultatList;
        private List<Angazovanje> _angazovanjeList;
        private ISession _session;

        public FormPrikaz()
        {
            InitializeComponent();
            _session = null;
            CreateSession();
            this.Icon = Resources.View;
            this.BackColor = System.Drawing.Color.Lavender;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Prikaz podataka";
        }

        private void CreateSession()
        {
            try
            {
                _session = DataLayer.GetSession();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private class InstitucijaRow
        {
            public string Naziv { get; set; }
            public string Adresa { get; set; }
            public string NaucneOblasti { get; set; }
            public string Telefoni { get; set; }
            public string Mailovi { get; set; }
        }

        private class IstrazivacRow
        {

            public string Ime { get; set; }
            public string Prezime { get; set; }
            public DateTime DatumRodjenja { get; set; }
            public string Drzava { get; set; }
            public string NaucnaOblast { get; set; }
            public string NaucnoZvanje { get; set; }
            public string StatusNaucnika { get; set; }
            public string Mailovi { get; set; }
            public string Telefoni { get; set; }
        }

        private class IstrazivackiRezultatRow
        {
            public string Naslov { get; set; }
            public string Apstrakt { get; set; }
            public DateTime DatumKreiranja { get; set; }
            public DateTime DatumObjavljivanja { get; set; }
            public string StatusIR { get; set; }
            public string Vidljivost { get; set; }
            public string KljucneReci { get; set; }
            public string Verzije { get; set; }
        }

        private class AngazovanjeRow
        {
            public string Istrazivac { get; set; }
            public string Institucija { get; set; }
            public DateTime DatumAngazovanja { get; set; }
            public DateTime? DatumZavrsetka { get; set; }
            public string OrganizacionaJedinica { get; set; }
            public string NazivPozicije { get; set; }
            public string TipAngazovanja { get; set; }
        }


        private void btnPrikaziNII_Click(object sender, EventArgs e)
        {
            try 
            {
                dgvPodaci.Refresh();
                List<NaucnoIstrazivackaInstitucija> institucije = _session.Query<NaucnoIstrazivackaInstitucija>().ToList();
                var prikaz = institucije.Select(i => new InstitucijaRow
                {
                    Naziv = i.Naziv,
                    Adresa = i.Adresa,
                    NaucneOblasti = string.Join("\n", i.NaucneOblasti?.Select(n => n.Oblast) ?? Enumerable.Empty<string>()),
                    Telefoni = string.Join("\n", i.Telefoni?.Select(t => t.Broj) ?? Enumerable.Empty<string>()),
                    Mailovi = string.Join("\n", i.Mailovi?.Select(m => m.MailAdresa) ?? Enumerable.Empty<string>())
                }).ToList();
                dgvPodaci.DataSource = prikaz;
                dgvPodaci.Columns["Telefoni"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvPodaci.Columns["Mailovi"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvPodaci.Columns["NaucneOblasti"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvPodaci.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                dgvPodaci.Columns["NaucneOblasti"].HeaderText = "Naucne oblasti";
                dgvPodaci.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString()+"Neuspesno prikazivanje institucija");
            }

        }

        private void btnPrikaziIstrazivace_Click(object sender, EventArgs e)
        {
            

        
            try
            {
                dgvPodaci.Refresh();
                List<Istrazivac> istrazivaci = _session.Query<Istrazivac>().ToList();

                var prikaz = istrazivaci.Select(i => new IstrazivacRow
                {
                    //ID_I = i.ID_I,
                    Ime = i.Ime,
                    Prezime = i.Prezime,
                    DatumRodjenja = i.DatumRodjenja,
                    Drzava = i.Drzava,
                    NaucnaOblast = i.NaucnaOblast,
                    NaucnoZvanje = i.NaucnoZvanje,
                    StatusNaucnika = i.StatusNaucnika,
                    Mailovi = string.Join("\n", i.Mailovi?.Select(m => m.MailAdresa) ?? Enumerable.Empty<string>()),
                    Telefoni = string.Join("\n", i.Telefoni?.Select(t => t.Broj) ?? Enumerable.Empty<string>())
                }).ToList();


                dgvPodaci.DataSource = prikaz;
                
                dgvPodaci.Columns["Mailovi"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvPodaci.Columns["Telefoni"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                
              
                dgvPodaci.Columns["DatumRodjenja"].HeaderText = "Datum rođenja";
                dgvPodaci.Columns["NaucnaOblast"].HeaderText = "Naučna oblast";
                dgvPodaci.Columns["NaucnoZvanje"].HeaderText = "Naučno zvanje";
                dgvPodaci.Columns["StatusNaucnika"].HeaderText = "Status";
                dgvPodaci.Columns["DatumRodjenja"].DefaultCellStyle.Format = "dd.MM.yyyy.";

                dgvPodaci.AutoResizeColumns();
                dgvPodaci.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Neuspesno prikazivanje istraživača");
            }
        }

        private void btnPrikaziIR_Click(object sender, EventArgs e)
        {
            try
            {             
                Form f = new FormPrikaziIR();
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Neuspesno popunjavanje tabele rezultata");
            }
        }
        
        
        private void btnPrikaziPublikacije_Click(object sender, EventArgs e)
        {
            
            Form f = new FormPrikaziPublikacije();
            f.ShowDialog();
        }

        private void btnPrikaziAngazovanja_Click(object sender, EventArgs e)
        {
            try
            {
                _angazovanjeList = _session.Query<Angazovanje>().ToList();

                var prikaz = _angazovanjeList.Select(a => new AngazovanjeRow
                {
                    Istrazivac = a.ID_I != null ? a.ID_I.Ime + " " + a.ID_I.Prezime : "-",
                    Institucija = a.ID_NII != null ? a.ID_NII.Naziv : "-",
                    DatumAngazovanja = a.DatumAngazovanja,
                    DatumZavrsetka = a.DatumZavrsetka,
                    OrganizacionaJedinica = a.OrganizacionaJedinica,
                    NazivPozicije = a.NazivPozicije,
                    TipAngazovanja = a.TipAngazovanja
                }).ToList();

                dgvPodaci.AutoGenerateColumns = true;
                dgvPodaci.DataSource = prikaz;

                dgvPodaci.Columns["DatumAngazovanja"].HeaderText = "Datum angažovanja";
                dgvPodaci.Columns["DatumZavrsetka"].HeaderText = "Datum završetka";
                dgvPodaci.Columns["OrganizacionaJedinica"].HeaderText = "Organizaciona jedinica";
                dgvPodaci.Columns["NazivPozicije"].HeaderText = "Pozicija";
                dgvPodaci.Columns["TipAngazovanja"].HeaderText = "Tip angažovanja";

                dgvPodaci.Columns["DatumAngazovanja"].DefaultCellStyle.Format = "dd.MM.yyyy.";
                dgvPodaci.Columns["DatumZavrsetka"].DefaultCellStyle.Format = "dd.MM.yyyy.";
                dgvPodaci.Columns["DatumZavrsetka"].DefaultCellStyle.NullValue = "u toku";

                dgvPodaci.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Neuspešno popunjavanje tabele angažovanja");
            }
        }

        private void FormPrikaz_FormClosing(object sender, FormClosingEventArgs e)
        {
            _session.Close();
        }
    }
    
}
