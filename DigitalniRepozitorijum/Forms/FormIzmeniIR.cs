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
using System.Linq.Expressions;

namespace DigitalniRepozitorijum.Forms
{
    public partial class FormIzmeniIR : Form
    {
        private IstrazivackiRezultat _rezultat;

        private Dictionary<string, IstrazivackiRezultat> _rezultatDict;

        private ISession _session;

        private static readonly string[] _opcijeStatus = { "U_PRIPREMI", "POSLAT_NA_RECENZIJU", "U_REVIZIJI", "PRIHVACEN", "ODBIJEN", "OBJAVLJEN", "ARHIVIRAN" };

        public FormIzmeniIR()
        {
            InitializeComponent();
            comboBStatus.Items.AddRange(_opcijeStatus);
            comboBStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            PopuniComboBox();
        }

        private void PopuniComboBox()
        {
            try
            {
                _session = DataLayer.GetSession();
                List<IstrazivackiRezultat> rezultatList = _session.Query<IstrazivackiRezultat>().ToList();
                _rezultatDict = rezultatList.ToDictionary(i => i.Naslov);

                if (_rezultatDict.Count == 0)
                {

                    _session.Close();
                    MessageBox.Show("Nema istrazivackih rezultata u bazi");
                    this.Close();
                }
                comboBIstrazivackiRezultat.DataSource = new BindingSource(_rezultatDict, null);
                comboBIstrazivackiRezultat.DisplayMember = "Key";
                comboBIstrazivackiRezultat.ValueMember = "Value";
                comboBIstrazivackiRezultat.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBIstrazivackiRezultat.Text.Length > 0)
                {
                    _rezultat = (IstrazivackiRezultat)comboBIstrazivackiRezultat.SelectedValue;

                    _session.Delete(_rezultat);
                    _session.Flush();
                    _session.Close();
                    this.Close();
                    //a.ID_NII = comboBInstitucija.Text;
                }
                else
                {
                    MessageBox.Show("Nije izabran istrazivacki rezultat");
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
                if (comboBIstrazivackiRezultat.Text.Length > 0)
                {
                    _rezultat = (IstrazivackiRezultat)comboBIstrazivackiRezultat.SelectedValue;

                    gbAzuriraj.Enabled = true;
                    gbObrisi.Enabled = false;
                    tbNaslov.Text = _rezultat.Naslov;
                    tbApstrakt.Text = _rezultat.Apstrakt;
                    dtpDatumKreiranja.Value = _rezultat.DatumKreiranja;
                    dtpDatumObjavljivanja.Value = _rezultat.DatumObjavljivanja;
                    comboBStatus.Text = _rezultat.StatusIR;
                    cbVidljivost.Checked = _rezultat.Vidljivost == 1 ? true : false;

                    
                }
                else
                {
                    MessageBox.Show("Nije izabrana institucija");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                this.Close();
            }
        }

        private async void btnDodajKljucnuRec_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbKljucnaRec.Text.Length > 0)
                {
                    KljucnaRec k = new KljucnaRec();
                    k.Rec = tbKljucnaRec.Text;
                    k.ID_IR = _rezultat;
                    _rezultat.KljucneReci.Add(k);
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

        private void btnDodajVerziju_Click(object sender, EventArgs e)
        {
            Form f = new FormDodajVerziju(_rezultat);
            f.ShowDialog();
        }

        private void btnObrisiKljucnuRec_Click(object sender, EventArgs e)
        {
            try {
                Form f = new FormObrisiKljucnuRec(_rezultat);
                f.ShowDialog();
            }
            catch(Exception ex)
            {

            }
            
        }

        private void btnObrisiVerziju_Click(object sender, EventArgs e)
        {
            try {
                Form f = new FormObrisiVerziju(_rezultat);
                f.ShowDialog();
            }
            catch(Exception ex) { }
            
        }

        private void btnPredjiNaPodklasu_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbApstrakt.Text.Length > 0 && tbNaslov.Text.Length > 0 && comboBStatus.Text.Length > 0 )
                {
                    _rezultat.Naslov = tbNaslov.Text;

                    _rezultat.Apstrakt = tbApstrakt.Text;
                    _rezultat.DatumKreiranja = dtpDatumKreiranja.Value;
                    _rezultat.DatumObjavljivanja = dtpDatumObjavljivanja.Value;
                    _rezultat.Vidljivost = cbVidljivost.Checked ? 1 : 0;
                    _rezultat.StatusIR = comboBStatus.Text;
                    Form f;
                    switch (_rezultat)
                    {
                        case OstaliDokumenti od:
                            _session.SaveOrUpdate(od);
                            _session.Flush();
                            _session.Close();
                            MessageBox.Show("Istrazivacki rezultat ovog tipa(obrazovni materjal, prezentacija, doktorska disertacija) nema dodatne atribute. Izmene sacuvane");
                            this.Close();
                            break;
                        case TehnickiIzvestaj ti:
                            _session.SaveOrUpdate(ti);
                            _session.Flush();
                            _session.Close();
                            MessageBox.Show("Istrazivacki rezultat tipa tehnicki izvestaj nema dodatne atribute. Izmene sacuvane");
                            this.Close();
                            break;
                        case SoftverskiArtifakt sa:
                            //_session.Close();
                            f = new FormSoftverskiArtifakt(sa,_session);
                            f.ShowDialog();
                            this.Close();
                            break;
                        case Dataset ds:
                            _session.Close();
                            f = new FormDataset(ds,true);
                            f.ShowDialog();
                            this.Close();
                            break;
                        case KnjigaIliPoglavlja knjiga:
                            //_session.Close();
                            f = new FormKnjigaIliPoglavlje(knjiga,_session);
                            f.ShowDialog();
                            this.Close();
                            break;
                        case NaucniRad nr:
                            _session.Close();
                            f = new FormNaucniRad(nr,true);
                            f.ShowDialog();
                            this.Close();
                            break;


                    }
                }
                else
                {
                    MessageBox.Show("Popunite naslov apstrakt i status");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        
           
            


        }
    }
}
