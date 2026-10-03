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
using NHibernate;

namespace DigitalniRepozitorijum.Forms
{
    public partial class FormPrikaziIR : Form
    {
        private List<IstrazivackiRezultat> _rezultatList;
        private ISession _session;

        public FormPrikaziIR()
        {
            InitializeComponent();
            CreateSession();
            this.Icon = Resources.View;
            this.BackColor = System.Drawing.Color.Lavender;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Prikaz istrazivackih rezultata";
            PrikaziIR();
        }

        private void CreateSession()
        {
            try
            {
                _session = DataLayer.GetSession();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
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

        private void PrikaziIR()
        {
            try
            {
                _rezultatList = _session.Query<IstrazivackiRezultat>().ToList();

                var prikaz = _rezultatList.Select(r => new IstrazivackiRezultatRow
                {
                    Naslov = r.Naslov,
                    Apstrakt = r.Apstrakt,
                    DatumKreiranja = r.DatumKreiranja,
                    DatumObjavljivanja = r.DatumObjavljivanja,
                    StatusIR = r.StatusIR,
                    Vidljivost = r.Vidljivost == 1 ? "Vidljiv" : "Sakriven",

                    KljucneReci = string.Join(Environment.NewLine,
                        r.KljucneReci?.Select(k => k.Rec) ?? Enumerable.Empty<string>()),

                    Verzije = string.Join("\n\n",
                        r.Verzije?.Select(v => $"v{v.BrojVerzije} ({v.DatumPostavljanja:dd.MM.yyyy.}); {v.OdgovornaOsoba}; Izmene: {v.OpisIzmena}")
                                  ?? Enumerable.Empty<string>())
                }).ToList();

                dgvIstrazivackiRezultati.AutoGenerateColumns = true;
                dgvIstrazivackiRezultati.DataSource = prikaz;

                dgvIstrazivackiRezultati.ReadOnly = true;
                dgvIstrazivackiRezultati.AllowUserToAddRows = false;
                dgvIstrazivackiRezultati.AllowUserToDeleteRows = false;

                dgvIstrazivackiRezultati.Columns["KljucneReci"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvIstrazivackiRezultati.Columns["Verzije"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvIstrazivackiRezultati.Columns["Apstrakt"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvIstrazivackiRezultati.Columns["DatumKreiranja"].HeaderText = "Datum kreiranja";
                dgvIstrazivackiRezultati.Columns["DatumObjavljivanja"].HeaderText = "Datum objavljivanja";
                dgvIstrazivackiRezultati.Columns["StatusIR"].HeaderText = "Status";    
                dgvIstrazivackiRezultati.Columns["KljucneReci"].HeaderText = "Ključne reči";
                dgvIstrazivackiRezultati.Columns["DatumKreiranja"].DefaultCellStyle.Format = "dd.MM.yyyy.";
                dgvIstrazivackiRezultati.Columns["DatumObjavljivanja"].DefaultCellStyle.Format = "dd.MM.yyyy.";

                dgvIstrazivackiRezultati.AutoResizeColumns();
                dgvIstrazivackiRezultati.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
         
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Neuspesno popunjavanje tabele rezultata");
            }
        }

        private void onSelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvIstrazivackiRezultati.CurrentRow == null)            
                    return;
                
                var entitet = _rezultatList[dgvIstrazivackiRezultati.CurrentRow.Index];
          
                PrikaziDodatneInfo(entitet);
            }
            catch (Exception ex)
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
                    lblTipRezultata.Text = "Tip selektovanog istrazivackog rezultata: Dataset";
                    svojstva.Add(new KeyValuePair<string, string>("Format", ds.Format));
                    svojstva.Add(new KeyValuePair<string, string>("Veličina", ds.Velicina.ToString()));
                    svojstva.Add(new KeyValuePair<string, string>("Broj zapisa", ds.BrojZapisa.ToString()));
                    svojstva.Add(new KeyValuePair<string, string>("Opis strukture", ds.OpisStrukture));
                    svojstva.Add(new KeyValuePair<string, string>("Period obuhvata podataka", ds.PeriodObuhvataPodataka));
                    svojstva.Add(new KeyValuePair<string, string>("Licenca korišćenja", ds.LicencaKoriscenja));
                    svojstva.Add(new KeyValuePair<string, string>("Ograničenja pristupa", ds.OgranicenjaPristupa));
                    break;

                case SoftverskiArtifakt sa:
                    lblTipRezultata.Text = "Tip selektovanog istrazivackog rezultata: Softverski artifakt";
                    svojstva.Add(new KeyValuePair<string, string>("Programski jezik", sa.ProgramskiJezik));
                    svojstva.Add(new KeyValuePair<string, string>("Repo link", sa.RepoLink));
                    svojstva.Add(new KeyValuePair<string, string>("Način licenciranja", sa.NacinLicenciranja));
                    svojstva.Add(new KeyValuePair<string, string>("Dokumentacija", sa.Dokumentacija));
                    svojstva.Add(new KeyValuePair<string, string>("Podržane platforme",
                    string.Join(", ", sa.PodrzanePlatforme?.Select(p => p.Platforma) ?? new List<string>())));
                    
                    break;

                case NaucniRad nr:
                    lblTipRezultata.Text = "Tip selektovanog istrazivackog rezultata: Naučni rad";
                    svojstva.Add(new KeyValuePair<string, string>("Tip rada", nr.TipRada));
                    svojstva.Add(new KeyValuePair<string, string>("Naziv časopisa/konferencije", nr.NazivCasKon));
                    svojstva.Add(new KeyValuePair<string, string>("DOI", nr.Doi));
                    svojstva.Add(new KeyValuePair<string, string>("ISSN/ISBN", nr.IssnIliIsbn));
                    svojstva.Add(new KeyValuePair<string, string>("Broj sveske", nr.BrojSveske.ToString()));
                    svojstva.Add(new KeyValuePair<string, string>("Broj izdanja", nr.BrojIzdanja.ToString()));
                    svojstva.Add(new KeyValuePair<string, string>("Broj stranice", nr.BrojStranice.ToString()));
                    break;

                case KnjigaIliPoglavlja kp:
                    lblTipRezultata.Text = "Tip selektovanog istrazivackog rezultata: Knjiga ili poglavlje";
                    svojstva.Add(new KeyValuePair<string, string>("Izdavač", kp.Izdavac));
                    svojstva.Add(new KeyValuePair<string, string>("Mesto izdavanja", kp.MestoIzdavanja));
                    break;

                case OstaliDokumenti od:
                    lblTipRezultata.Text = "Tip selektovanog istrazivackog rezultata: Ostali dokumenti(" + od.Opcije + ")";
                    svojstva.Add(new KeyValuePair<string, string>("Tip:", od.Opcije));
                    break;

                case TehnickiIzvestaj ti:
                    lblTipRezultata.Text = "Tip selektovanog istrazivackog rezultata: Tehnički izveštaj";
                    svojstva.Add(new KeyValuePair<string, string>("Dodatna polja", "(nema dodatnih polja)"));
                    break;

                default:
                    lblTipRezultata.Text = "Tip selektovanog istrazivackog rezultata: " + entitet.GetType().Name;
                    break;
            }

            dgvPodKlasa.AutoGenerateColumns = false;
            dgvPodKlasa.Columns.Clear();
            dgvPodKlasa.Columns.Add("Svojstvo", "Svojstvo");
            dgvPodKlasa.Columns.Add("Vrednost", "Vrednost");
            dgvPodKlasa.Columns["Svojstvo"].ReadOnly = true;
            dgvPodKlasa.Columns["Vrednost"].ReadOnly = true;
            dgvPodKlasa.RowHeadersVisible = false;

            foreach (var kv in svojstva)
                dgvPodKlasa.Rows.Add(kv.Key, kv.Value);

            dgvPodKlasa.AutoResizeColumns();
        }

        private void FormPrikaziIR_FormClosing(object sender, FormClosingEventArgs e)
        {
            _session.Close();
        }
    }
}
