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

namespace DigitalniRepozitorijum.Forms
{
    public partial class FormPrikaziPublikacije : Form
    {
        private ISession _session;
        private List<Publikacija> _publikacije;
        public FormPrikaziPublikacije()
        {
            InitializeComponent();
            PopuniDataGrid();
        }
        private class PublikacijaRow
        {
            public int ID_P { get; set; }
            public string OsnovaDataset { get; set; } // "Dataset: X", "Tehnički izveštaj: Y", "Softverski artifakt: Z", or "-"
            public string OsnovaTehnickiIzvestaj { get; set; }
            public string OsnovaSoftverskiArtifakt { get; set; }
        }
       
       

        private void PopuniDataGrid()
        {
            try
            {
                _session = DataLayer.GetSession();
                _publikacije = _session.Query<Publikacija>().ToList();

                var prikaz = _publikacije.Select(p => new PublikacijaRow
                {
                    ID_P = p.ID_P,
                    OsnovaDataset = p.DatasetID != null ? "Dataset: " + p.DatasetID.Naslov : "-",
                    OsnovaTehnickiIzvestaj = p.TehnickiIzvestajID != null ? "Tehnički izveštaj: " + p.TehnickiIzvestajID.Naslov : "-",
                    OsnovaSoftverskiArtifakt =p.SoftverskiArtifaktID != null ? "Softverski artifakt: " + p.SoftverskiArtifaktID.Naslov: "-"
                }).ToList();

                dgvPublikacije.AutoGenerateColumns = true;
                dgvPublikacije.DataSource = prikaz;
                dgvPublikacije.ReadOnly = true;
                dgvPublikacije.AllowUserToAddRows = false;
                dgvPublikacije.AllowUserToDeleteRows = false;
                dgvPublikacije.Columns["ID_P"].HeaderText = "ID";
                dgvPublikacije.Columns["OsnovaDataset"].HeaderText = "Zasnovana na dataset-u";
                dgvPublikacije.Columns["OsnovaTehnickiIzvestaj"].HeaderText = "Zasnovana na tehnickom izvestaju";
                dgvPublikacije.Columns["OsnovaSoftverskiArtifakt"].HeaderText = "Zasnovana na softverskom artifaktu";
                dgvPublikacije.AutoResizeColumns();

                //dgvPublikacije.SelectionChanged += dgvPublikacije_SelectionChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Neuspešno popunjavanje tabele publikacija");
            }
        }

        private void btnPrikaziSelektovanu_Click(object sender, EventArgs e)
        {
            if (dgvPublikacije.CurrentRow == null) return;
            var pub = _publikacije[dgvPublikacije.CurrentRow.Index];
            PrikaziAutore(pub);
            PrikaziRundeRecenzije(pub);
            PrikaziCitate(pub);
        }

      

        private void PrikaziAutore(Publikacija pub)
        {
            var autori = pub.Autorstva?.Select(a => new
            {
                Autor = a.ID_U?.ID_I != null ? a.ID_U.ID_I.Ime + " " + a.ID_U.ID_I.Prezime : "-",
                RedniBroj = a.RedniBrojAutora,
                TipDoprinosa = a.TipDoprinosa,
                Uloga = a.UlogaUPublikaciji
            }).OrderBy(a => a.RedniBroj).ToList();
            //?? new List<object>();
            if (autori.Count < 0)
                return;

            dgvAutorstva.AutoGenerateColumns = true;
            dgvAutorstva.DataSource = autori;
            dgvAutorstva.ReadOnly = true;
            dgvAutorstva.AutoResizeColumns();
        }

        private void PrikaziRundeRecenzije(Publikacija pub)
        {
            var runde = pub.RundeRecenzije?.Select(r => new
            {
                r.BrojRunde,
                r.DatumOdluke,
                r.KonacnaOdluka,
                Urednik = r.ID_Urednika?.ID_I != null ? r.ID_Urednika.ID_I.Ime + " " + r.ID_Urednika.ID_I.Prezime : "-",
                Recenzenti = string.Join("; ", r.Recenzenti?.Select(rec =>
                    (rec.ID_Recenzenta?.ID_I != null ? rec.ID_Recenzenta.ID_I.Ime + " " + rec.ID_Recenzenta.ID_I.Prezime : "-")
                    + " (preporuka: " + rec.Preporuka
                    + ", ocene: " + string.Join(",", rec.Ocene?.Select(o => o.Ocena.ToString()) ?? Enumerable.Empty<string>())
                    + ")") ?? Enumerable.Empty<string>())
            }).OrderBy(r => r.BrojRunde).ToList();
              //?? new List<object>();

            dgvRundeRecenzije.AutoGenerateColumns = true;
            dgvRundeRecenzije.DataSource = runde;
            dgvRundeRecenzije.ReadOnly = true;
            dgvRundeRecenzije.Columns["Recenzenti"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvRundeRecenzije.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRundeRecenzije.AutoResizeColumns();
        }

        private void PrikaziCitate(Publikacija pub)
        {
            var citati = new List<object>();

            // ove publikacija CITIRA (izlazni citati)
            if (pub.CitirajucePublikacije != null)
                foreach (var c in pub.CitirajucePublikacije)
                    citati.Add(new
                    {
                        Smer = "Citira",
                        DrugaPublikacija = c.ID_P2.ID_P, 
                        c.TipCitata,
                        c.MestoCitiranja,
                        c.KontekstCitiranja
                    });

            // ovu publikaciju CITIRAJU (dolazni citati)
            if (pub.CitiranePublikacije != null)
                foreach (var c in pub.CitiranePublikacije)
                    citati.Add(new
                    {
                        Smer = "Citirana od",
                        DrugaPublikacija = c.ID_P1.ID_P, 
                        c.TipCitata,
                        c.MestoCitiranja,
                        c.KontekstCitiranja
                    });

            dgvCitati.AutoGenerateColumns = true;
            dgvCitati.DataSource = citati;
            dgvCitati.ReadOnly = true;
            dgvCitati.AutoResizeColumns();
        }
    }
    
}
