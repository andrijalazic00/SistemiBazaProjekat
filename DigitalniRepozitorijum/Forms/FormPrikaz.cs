using DigitalniRepozitorijum.Entities;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.ServiceModel.Channels;

//using System.ServiceModel.Channels;

//using System.ServiceModel.Channels;
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
        }
        private class InstitucijaRow
        {
            //public int ID_NII { get; set; }
            public string Naziv { get; set; }
            public string Adresa { get; set; }
            public string NaucneOblasti { get; set; }
            public string Telefoni { get; set; }
            public string Mailovi { get; set; }
        }

        private class IstrazivacRow
        {
            //public int ID_I { get; set; }
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
            //public int ID_IR { get; set; }
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
                if(_session==null)
                    _session = DataLayer.GetSession();
                List<NaucnoIstrazivackaInstitucija> institucije = _session.Query<NaucnoIstrazivackaInstitucija>().ToList();
                var prikaz = institucije.Select(i => new InstitucijaRow
                {
                    //ID_NII = i.ID_NII,
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
                //dgvPodaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvPodaci.AutoResizeColumns();
                //session.Close();
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
                if (_session == null)
                    _session = DataLayer.GetSession();
                //ISession _session = DataLayer.GetSession();
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

                //dgvPodaci.AutoGenerateColumns = true;
                dgvPodaci.DataSource = prikaz;
                /*
                dgvPodaci.ReadOnly = true;
                dgvPodaci.AllowUserToAddRows = false;
                dgvPodaci.AllowUserToDeleteRows = false;
                */
                dgvPodaci.Columns["Mailovi"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvPodaci.Columns["Telefoni"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvPodaci.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //dgvPodaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                
                //dgvPodaci.Columns["ID_I"].HeaderText = "ID";
                dgvPodaci.Columns["DatumRodjenja"].HeaderText = "Datum rođenja";
                dgvPodaci.Columns["NaucnaOblast"].HeaderText = "Naučna oblast";
                dgvPodaci.Columns["NaucnoZvanje"].HeaderText = "Naučno zvanje";
                dgvPodaci.Columns["StatusNaucnika"].HeaderText = "Status";
                dgvPodaci.Columns["DatumRodjenja"].DefaultCellStyle.Format = "dd.MM.yyyy.";

                dgvPodaci.AutoResizeColumns();
                //session.Close();
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
                if (_session == null)
                    _session = DataLayer.GetSession();
                //ISession session = DataLayer.GetSession();
                _rezultatList = _session.Query<IstrazivackiRezultat>().ToList();

                var prikaz = _rezultatList.Select(r => new IstrazivackiRezultatRow
                {
                    //ID_IR = r.ID_IR,
                    Naslov = r.Naslov,
                    Apstrakt = r.Apstrakt,
                    DatumKreiranja = r.DatumKreiranja,
                    DatumObjavljivanja = r.DatumObjavljivanja,
                    StatusIR = r.StatusIR,
                    Vidljivost = r.Vidljivost==1?"Vidljiv":"Sakriven",

                    KljucneReci = string.Join(Environment.NewLine,
                        r.KljucneReci?.Select(k => k.Rec) ?? Enumerable.Empty<string>()),

                    Verzije = string.Join(Environment.NewLine,
                        r.Verzije?.Select(v => $"v{v.BrojVerzije} ({v.DatumPostavljanja:dd.MM.yyyy.}) - {v.OdgovornaOsoba}-Izmene: {v.OpisIzmena}")
                                  ?? Enumerable.Empty<string>())
                }).ToList();

                dgvPodaci.AutoGenerateColumns = true;
                dgvPodaci.DataSource = prikaz;

                dgvPodaci.ReadOnly = true;
                dgvPodaci.AllowUserToAddRows = false;
                dgvPodaci.AllowUserToDeleteRows = false;

                dgvPodaci.Columns["KljucneReci"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvPodaci.Columns["Verzije"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvPodaci.Columns["Apstrakt"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvPodaci.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                //dgvPodaci.Columns["ID_IR"].HeaderText = "ID";
                dgvPodaci.Columns["DatumKreiranja"].HeaderText = "Datum kreiranja";
                dgvPodaci.Columns["DatumObjavljivanja"].HeaderText = "Datum objavljivanja";
                dgvPodaci.Columns["StatusIR"].HeaderText = "Status";
                //dgvPodaci.Columns["Vidljivost"].HeaderText = "Vidljivost";
                dgvPodaci.Columns["KljucneReci"].HeaderText = "Ključne reči";
                //dgvPodaci.Columns["Verzije"].HeaderText = "Verzije";
                dgvPodaci.Columns["DatumKreiranja"].DefaultCellStyle.Format = "dd.MM.yyyy.";
                dgvPodaci.Columns["DatumObjavljivanja"].DefaultCellStyle.Format = "dd.MM.yyyy.";

                dgvPodaci.AutoResizeColumns();
                //session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Neuspesno popunjavanje tabele rezultata");
            }
        }

        private void btnPrikaziPodklasu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPodaci.CurrentRow == null)
                {
                    //dgvDodatnaSvojstva.DataSource = null;
                    lblTipRezultata.Text = "";
                    return;
                }
                var entitet = _rezultatList[dgvPodaci.CurrentRow.Index];
                if (entitet is IstrazivackiRezultat)
                    PrikaziDodatneInfo(entitet);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        

        private void PrikaziDodatneInfo(IstrazivackiRezultat entitet)
        {
            var svojstva = new List<KeyValuePair<string, string>>();

            switch (entitet)
            {
                case Dataset ds:
                    lblTipRezultata.Text = "Tip: Dataset";
                    svojstva.Add(new KeyValuePair<string, string>("Format", ds.Format));
                    svojstva.Add(new KeyValuePair<string, string>("Veličina", ds.Velicina.ToString()));
                    svojstva.Add(new KeyValuePair<string, string>("Broj zapisa", ds.BrojZapisa.ToString()));
                    svojstva.Add(new KeyValuePair<string, string>("Opis strukture", ds.OpisStrukture));
                    svojstva.Add(new KeyValuePair<string, string>("Period obuhvata podataka", ds.PeriodObuhvataPodataka));
                    svojstva.Add(new KeyValuePair<string, string>("Licenca korišćenja", ds.LicencaKoriscenja));
                    svojstva.Add(new KeyValuePair<string, string>("Ograničenja pristupa", ds.OgranicenjaPristupa));
                    break;

                case SoftverskiArtifakt sa:
                    lblTipRezultata.Text = "Tip: Softverski artifakt";
                    svojstva.Add(new KeyValuePair<string, string>("Programski jezik", sa.ProgramskiJezik));
                    svojstva.Add(new KeyValuePair<string, string>("Repo link", sa.RepoLink));
                    svojstva.Add(new KeyValuePair<string, string>("Način licenciranja", sa.NacinLicenciranja));
                    svojstva.Add(new KeyValuePair<string, string>("Dokumentacija", sa.Dokumentacija));
                    svojstva.Add(new KeyValuePair<string, string>("Podržane platforme",
                        string.Join(", ", sa.PodrzanePlatforme?.Select(p=>p.Platforma) ?? new List<string>())));
                    //Mailovi = string.Join("\n", i.Mailovi?.Select(m => m.MailAdresa) ?? Enumerable.Empty<string>()),
                    break;

                case NaucniRad nr:
                    lblTipRezultata.Text = "Tip: Naučni rad";
                    svojstva.Add(new KeyValuePair<string, string>("Tip rada", nr.TipRada));
                    svojstva.Add(new KeyValuePair<string, string>("Naziv časopisa/konferencije", nr.NazivCasKon));
                    svojstva.Add(new KeyValuePair<string, string>("DOI", nr.Doi));
                    svojstva.Add(new KeyValuePair<string, string>("ISSN/ISBN", nr.IssnIliIsbn));
                    svojstva.Add(new KeyValuePair<string, string>("Broj sveske", nr.BrojSveske.ToString()));
                    svojstva.Add(new KeyValuePair<string, string>("Broj izdanja", nr.BrojIzdanja.ToString()));
                    svojstva.Add(new KeyValuePair<string, string>("Broj stranice", nr.BrojStranice.ToString()));
                    break;

                case KnjigaIliPoglavlja kp:
                    lblTipRezultata.Text = "Tip: Knjiga ili poglavlje";
                    svojstva.Add(new KeyValuePair<string, string>("Izdavač", kp.Izdavac));
                    svojstva.Add(new KeyValuePair<string, string>("Mesto izdavanja", kp.MestoIzdavanja));
                    break;

                case OstaliDokumenti od:
                    lblTipRezultata.Text = "Tip: Ostali dokumenti("+od.Opcije+")";
                    svojstva.Add(new KeyValuePair<string, string>("Tip:", od.Opcije));
                    break;

                case TehnickiIzvestaj ti:
                    lblTipRezultata.Text = "Tip: Tehnički izveštaj";
                    svojstva.Add(new KeyValuePair<string, string>("Dodatna polja", "(nema dodatnih polja)"));
                    break;

                default:
                    lblTipRezultata.Text = "Tip: " + entitet.GetType().Name;
                    break;
            }

            dgvDodatnaSvojstva.AutoGenerateColumns = false;
            dgvDodatnaSvojstva.Columns.Clear();
            dgvDodatnaSvojstva.Columns.Add("Svojstvo", "Svojstvo");
            dgvDodatnaSvojstva.Columns.Add("Vrednost", "Vrednost");
            dgvDodatnaSvojstva.Columns["Svojstvo"].ReadOnly = true;
            dgvDodatnaSvojstva.Columns["Vrednost"].ReadOnly = true;
            dgvDodatnaSvojstva.RowHeadersVisible = false;

            foreach (var kv in svojstva)
                dgvDodatnaSvojstva.Rows.Add(kv.Key, kv.Value);

            dgvDodatnaSvojstva.AutoResizeColumns();
        }

        private void btnPrikaziPublikacije_Click(object sender, EventArgs e)
        {
            if(_session!=null)
                _session.Close();
            Form f = new FormPrikaziPublikacije();
            f.ShowDialog();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                _session = DataLayer.GetSession();
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
                /*
                dgvPodaci.ReadOnly = true;
                dgvPodaci.AllowUserToAddRows = false;
                dgvPodaci.AllowUserToDeleteRows = false;*/

               
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
    }
    
}
