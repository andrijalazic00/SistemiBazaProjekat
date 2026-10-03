using DigitalniRepozitorijum.Entities;
using DigitalniRepozitorijum.Properties;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forms
{
    public partial class FormDodajSoftverskiArtifakt : Form
    {
        private ISession _session;
        private SoftverskiArtifakt _softverskiArtifakt;
        private static string[] _opcijePodrzanePlatforme = {"WINDOWS","LINUX","MACOS","WEB","ANDROID","IOS" };

        public FormDodajSoftverskiArtifakt()
        {
            InitializeComponent();
        }

        public FormDodajSoftverskiArtifakt(SoftverskiArtifakt sa)
        {
            InitializeComponent();
            _softverskiArtifakt = sa;
            comboBPodrzanePlatforme.Items.AddRange(_opcijePodrzanePlatforme);
            comboBPodrzanePlatforme.DropDownStyle=ComboBoxStyle.DropDownList;
            _session = null;
            this.Icon = Resources.Plus;
            this.BackColor = System.Drawing.Color.Azure;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Dodavanje softverskog artifakta";

        }

        public FormDodajSoftverskiArtifakt(SoftverskiArtifakt sa, ISession s) 
        {
            InitializeComponent();
            _softverskiArtifakt = sa;
            _session = s;

            comboBPodrzanePlatforme.Items.AddRange(_opcijePodrzanePlatforme);
            comboBPodrzanePlatforme.DropDownStyle = ComboBoxStyle.DropDownList;
            tbDokumentacija.Text = sa.Dokumentacija;
            tbNacinLicenciranja.Text = sa.NacinLicenciranja;
            tbProgramskiJezik.Text= sa.ProgramskiJezik;
            tbRepoLink.Text = sa.RepoLink;
            this.Icon = Resources.Edit;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Izmene softverskog artifakta";

        }

        private async void btnDodajPlatformu_Click(object sender, EventArgs e)
        {
            try 
            {
                if (comboBPodrzanePlatforme.Text.Length > 0)
                {
                    PodrzanaPlatforma p = new PodrzanaPlatforma();
                    p.Platforma = comboBPodrzanePlatforme.Text;
                    p.ID_IR = _softverskiArtifakt;
                  
                    _softverskiArtifakt.PodrzanePlatforme.Add(p);
                    comboBPodrzanePlatforme.ResetText();
                    comboBPodrzanePlatforme.Text = "Platforma dodata";
                    await Task.Delay(1000);
                    comboBPodrzanePlatforme.ResetText();

                }
                else
                {
                    comboBPodrzanePlatforme.Text = "Unesite platformu";
                    await Task.Delay(1000);
                    comboBPodrzanePlatforme.ResetText();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnSacuvajSoftverskiArtifakt_Click(object sender, EventArgs e)
        {
            try
            {
                if(_session==null)
                    _session=DataLayer.GetSession();

                if (tbRepoLink.Text.Length > 0 && tbProgramskiJezik.Text.Length > 0 &&
                    tbNacinLicenciranja.Text.Length > 0 && tbDokumentacija.Text.Length > 0)
                {
                    _softverskiArtifakt.ProgramskiJezik = tbProgramskiJezik.Text;
                    _softverskiArtifakt.RepoLink = tbRepoLink.Text;
                    _softverskiArtifakt.NacinLicenciranja = tbNacinLicenciranja.Text;
                    _softverskiArtifakt.Dokumentacija = tbDokumentacija.Text;
                    _session.SaveOrUpdate(_softverskiArtifakt);
                    _session.Flush();
                    _session.Close();
                    MessageBox.Show("Softverski artifakt sacuvan");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Popunite sva polja");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString()+ex.InnerException.ToString());
            }
        }

        private void btnObrisiPlatformu_Click(object sender, EventArgs e)
        {
            try
            {
                PodrzanaPlatforma p= _softverskiArtifakt.PodrzanePlatforme.FirstOrDefault(i => i.Platforma == comboBPodrzanePlatforme.Text);
                if (p!=null)
                {
                    _softverskiArtifakt.PodrzanePlatforme.Remove(p);
                    ISession session=DataLayer.GetSession();
                    session.Delete(p);
                    session.Flush();
                    session.Close();
                    MessageBox.Show("Platforma obrisana");
                }
                else 
                {
                    MessageBox.Show("Entitet nema platformu cije brisanje zahtevate");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }
    }
}
