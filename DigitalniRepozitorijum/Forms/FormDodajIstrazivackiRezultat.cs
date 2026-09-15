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
using NHibernate.Impl;

namespace DigitalniRepozitorijum.Forms
{
    public partial class FormDodajIstrazivackiRezultat : Form
    {
        //private List<KljucnaRec> _kljucneReci;
        private static readonly string[] _opcijeTip ={ "Obrazovni materijal", "Prezentacija","Doktorska disertacija", "Softverski artifakt",
                                    "Dataset", "Tehnicki izvestaj","Knjiga ili poglavlje", "Naucni rad" };
        private static readonly string[]  _opcijeStatus = { "U_PRIPREMI", "POSLAT_NA_RECENZIJU", "U_REVIZIJI", "PRIHVACEN", "ODBIJEN", "OBJAVLJEN", "ARHIVIRAN" };
        
        private IstrazivackiRezultat _istrazivackiRezultat;
        
        public FormDodajIstrazivackiRezultat()
        {
            InitializeComponent();
            _istrazivackiRezultat=new IstrazivackiRezultat();
            
            comboBStatus.Items.AddRange(_opcijeStatus);
            comboBTipIstrazivackogRezultata.Items.AddRange(_opcijeTip);
            comboBStatus.SelectedIndex = 0;
            comboBTipIstrazivackogRezultata.SelectedIndex = 0;
            comboBTipIstrazivackogRezultata.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBStatus.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private async void btnDodajKljucnuRec_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbKljucnaRec.Text.Length > 0)
                {
                    KljucnaRec k=new KljucnaRec();
                    k.Rec=tbKljucnaRec.Text;
                    k.ID_IR = _istrazivackiRezultat;
                    _istrazivackiRezultat.KljucneReci.Add(k);
                    tbKljucnaRec.Clear();
                    tbKljucnaRec.Text = "Kljucna rec dodata";
                    await Task.Delay(1000);
                    tbKljucnaRec.Clear();

                }
                else
                {
                    tbKljucnaRec.Clear();
                    tbKljucnaRec.Text = "Upisite rec";
                    await Task.Delay(1000);
                    tbKljucnaRec.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnPredjiNaPodklasu_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbApstrakt.Text.Length>0 && tbNaslov.Text.Length>0&& comboBStatus.Text.Length>0 && comboBTipIstrazivackogRezultata.Text.Length>0)
                {
                    _istrazivackiRezultat.Naslov = tbNaslov.Text;
                    
                    _istrazivackiRezultat.Apstrakt = tbApstrakt.Text;
                    _istrazivackiRezultat.DatumKreiranja = dtpDatumKreiranja.Value;
                    _istrazivackiRezultat.DatumObjavljivanja=dtpDatumObjavljivanja.Value;
                    _istrazivackiRezultat.Vidljivost = cbVidljivost.Checked ? 1 : 0;
                    _istrazivackiRezultat.StatusIR=comboBStatus.Text;

                    OstaliDokumenti doc = new OstaliDokumenti();
                    Form f;
                    
                    
                    switch (comboBTipIstrazivackogRezultata.Text)
                    {
                        case "Obrazovni materijal":
                            doc.Opcije = "OBRAZOVNI_MATERIJAL";
                            PreuzmiAtribute(doc, _istrazivackiRezultat);
                            ISession session = DataLayer.GetSession();
                            session.Save(doc);
                            session.Flush();
                            session.Close();
                            MessageBox.Show("Obrazovni materjal dodat");
                            break;   

                        case "Prezentacija":
                            doc.Opcije = "PREZENTACIJA";
                            PreuzmiAtribute(doc, _istrazivackiRezultat);
                            ISession session2 = DataLayer.GetSession();
                            session2.Save(doc);
                            session2.Flush();
                            session2.Close();
                            MessageBox.Show("Prezentacija dodata");
                            break;

                        case "Doktorska disertacija":
                            doc.Opcije = "DOKTORSKA_DISERTACIJA";
                            PreuzmiAtribute(doc, _istrazivackiRezultat);
                            ISession session3 = DataLayer.GetSession();
                            session3.Save(doc);
                            session3.Flush();
                            session3.Close();
                            MessageBox.Show("Doktorska disertacija dodata");
                            break;

                        case "Softverski artifakt":
                            SoftverskiArtifakt sa=new SoftverskiArtifakt();
                            PreuzmiAtribute(sa, _istrazivackiRezultat);
                            f= new FormSoftverskiArtifakt(sa);
                            f.ShowDialog();
                            break;

                        case "Dataset":
                            Dataset set=new Dataset();
                            PreuzmiAtribute(set, _istrazivackiRezultat);
                            f = new FormDataset(set);
                            f.ShowDialog();
                            break;

                        case "Tehnicki izvestaj":
                            TehnickiIzvestaj t=new TehnickiIzvestaj();
                            PreuzmiAtribute(t, _istrazivackiRezultat);
                            ISession session4 = DataLayer.GetSession();
                            session4.Save(t);
                            session4 .Flush();
                            session4.Close();
                            MessageBox.Show("Tehnicki izvestaj dodat");
                            break;

                        case "Knjiga ili poglavlje":
                            KnjigaIliPoglavlja k = new KnjigaIliPoglavlja();
                            PreuzmiAtribute(k, _istrazivackiRezultat);
                            f = new FormKnjigaIliPoglavlje(k);
                            f.ShowDialog();
                            break;

                        case "Naucni rad":
                            NaucniRad n = new NaucniRad();
                            PreuzmiAtribute(n, _istrazivackiRezultat);
                            f = new FormNaucniRad(n);
                            f.ShowDialog();
                            break;
                    }
                    //Verzija v=new Verzija();
                    this.Close();
                    
                }
                else 
                {
                    MessageBox.Show("Popunite polja:status, tip, naslov i apstrakt");
                }

                
            }
            catch(Exception ex)

            { 
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void PreuzmiAtribute(IstrazivackiRezultat primalac, IstrazivackiRezultat davalac)
        {
            primalac.StatusIR=davalac.StatusIR;
            primalac.Vidljivost = davalac.Vidljivost;
            primalac.Apstrakt=davalac.Apstrakt;
            primalac.DatumObjavljivanja=davalac.DatumObjavljivanja;
            primalac.DatumKreiranja=davalac. DatumKreiranja;
            primalac.Naslov=davalac.Naslov;

            primalac.PripadajuciFajlovi = davalac.PripadajuciFajlovi;
            foreach (var f in primalac.PripadajuciFajlovi)
                f.ID_IR = primalac;   // Prevezivanje pokazivaca da pokazuje na novi objekat

            primalac.KljucneReci = davalac.KljucneReci;
            foreach (var k in primalac.KljucneReci)
                k.ID_IR = primalac;      

            primalac.Verzije = davalac.Verzije;
            foreach (var v in primalac.Verzije)
                v.ID_IR = primalac;      
        }
        private void btnDodajVerziju_Click(object sender, EventArgs e)
        {
            Form f = new FormDodajVerziju(_istrazivackiRezultat);
            f.ShowDialog();
        }
    }
}
