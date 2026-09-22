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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forms
{
    public partial class FormIzmeniRunduRecenzije : Form
    {
        private ISession _session;
        private List<RundaRecenzije> _rundaList;
        private Dictionary<string, RundaRecenzije> _rundaDict;
        private Dictionary<string, Urednik> _urednikDict; 
        private static readonly string[] _opcijeOdluka = { "PRIHVACENA", "ODBIJENA", "POTREBNA_REVIZIJA" };
        public FormIzmeniRunduRecenzije()
        {
            InitializeComponent();
            PopuniComboBox();
        }
        private void PopuniComboBox()
        {
            try
            {
                _session = DataLayer.GetSession();


                _rundaList = _session.Query<RundaRecenzije>().ToList();
                _rundaDict = _rundaList.ToDictionary(r=>"Broj runde: "+r.BrojRunde + " Publikacija: " + r.ID_P.ID_P + " Odluka: " + r.KonacnaOdluka);

                if (_rundaDict.Count == 0)
                {

                    _session.Close();
                    MessageBox.Show("Nema rundi recenzije u bazi");
                    this.Close();
                }
                comboBRundaRecenzije.DataSource = new BindingSource(_rundaDict, null);
                comboBRundaRecenzije.DisplayMember = "Key";
                comboBRundaRecenzije.ValueMember = "Value";

                comboBRundaRecenzije.DropDownStyle = ComboBoxStyle.DropDownList;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnObrisiRundu_Click(object sender, EventArgs e)
        {
            try 
            {
                //_session = DataLayer.GetSession();
                RundaRecenzije r=(RundaRecenzije)comboBRundaRecenzije.SelectedValue;
                r.ID_P.RundeRecenzije.Remove(r);
                r.ID_Urednika.RundeRecenzije.Remove(r);
                _session.Delete(r);
                _session.Flush();
                _session.Close();
                MessageBox.Show("Runda recenzije obrisana");
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnIzmeniRundu_Click(object sender, EventArgs e)
        {
            try {
                gbIzmene.Visible = true;
                comboBRundaRecenzije.Enabled = false;

                //_session = DataLayer.GetSession();
                RundaRecenzije runda = (RundaRecenzije)comboBRundaRecenzije.SelectedValue;

                comboBKonacnaOdluka.Items.AddRange(_opcijeOdluka);
                comboBKonacnaOdluka.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBKonacnaOdluka.Text = runda.KonacnaOdluka;

                List<Urednik> urednikList = _session.Query<Urednik>().ToList();
                _urednikDict = urednikList.ToDictionary(i => i.ID_I != null ? i.ID_I.Ime + " " + i.ID_I.Prezime + " " + i.ID_U : i.ID_U.ToString());
                if (_urednikDict.Count > 0)
                {
                    comboBAngazovanUrednik.DataSource = new BindingSource(_urednikDict, null);
                    comboBAngazovanUrednik.DisplayMember = "Key";
                    comboBAngazovanUrednik.ValueMember = "Value";
                    comboBAngazovanUrednik.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                else
                {
                    MessageBox.Show("Ne postoji ni jedan urednik u bazi, dodajte urednika pre nego sto predjete na dodavanje rundi recenzije");
                    _session.Close();
                    this.Close();
                }
                comboBAngazovanUrednik.SelectedItem = runda.ID_Urednika;

                dtpDatumOdluke.Value = runda.DatumOdluke;
                //nudBrojRunde.Value = runda.BrojRunde;

                //session.Close();



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnSacuvajIzmene_Click(object sender, EventArgs e)
        {
            try 
            {
                //ISession session = DataLayer.GetSession();
                RundaRecenzije runda = (RundaRecenzije)comboBRundaRecenzije.SelectedValue;
                runda.ID_Urednika.RundeRecenzije.Remove(runda);
                runda.ID_Urednika = (Urednik)comboBAngazovanUrednik.SelectedValue;
                runda.ID_Urednika.RundeRecenzije.Add(runda);

                runda.KonacnaOdluka = comboBKonacnaOdluka.Text;
                runda.DatumOdluke = dtpDatumOdluke.Value;
                //runda.BrojRunde = (int)nudBrojRunde.Value;

                _session.SaveOrUpdate(runda);
                _session.Flush();
                _session.Close();
                MessageBox.Show("Runda recenzije sacuvana");
                this.Close();
            }
            catch(Exception ex)
            {  MessageBox.Show(ex.Message.ToString());}
            
        }
    }
}
