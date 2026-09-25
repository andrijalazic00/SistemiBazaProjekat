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
//using System.ServiceModel.Channels;


namespace DigitalniRepozitorijum.Forms
{
    public partial class FormDodajKnjiguIliPoglavlje : Form
    {
        private ISession _session;
        private KnjigaIliPoglavlja _knjiga;
        private Dictionary<string, Urednik> _uredniciDict;
        private List<Urednik> _uredniciList;

        public FormDodajKnjiguIliPoglavlje()
        {
            InitializeComponent();
        }

        public FormDodajKnjiguIliPoglavlje(KnjigaIliPoglavlja k)
        {
            InitializeComponent();
            _session = null;
            _knjiga = k;
            PopuniComboBox();
            this.Icon = Resources.Plus;
            this.BackColor = System.Drawing.Color.Azure;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Dodavanje knjige";

        }

        public FormDodajKnjiguIliPoglavlje(KnjigaIliPoglavlja k, ISession s) //b postoji samo da bi se konstruktor razlikovao od prethodnog 
        {
            InitializeComponent();
            _knjiga = k;
            _session = s;
            tbIzdavac.Text = k.Izdavac;
            tbMestoIzdavanja.Text = k.MestoIzdavanja;
            PopuniComboBox();
            this.Icon = Resources.Edit;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Izmene knjige";

        }

        public void PopuniComboBox()
        {
            try {
                if (_session == null)
                { 
                    _session = DataLayer.GetSession(); 
                }
                    
                _uredniciList = _session.Query<Urednik>().ToList();
                _uredniciDict = _uredniciList.ToDictionary(i => i.ID_I != null ? i.ID_I.Ime + " " + i.ID_I.Prezime + " " + i.ID_U : i.ID_U.ToString());
                if (_uredniciDict.Count == 0)
                {

                    MessageBox.Show("Nema urednika u bazi, kreirajte bar jednog urednika pre kreiranja knjige");
                    _session.Close();
                    this.Close();

                }
                comboBUrednici.DataSource = new BindingSource(_uredniciDict, null);
                comboBUrednici.DisplayMember = "Key";
                comboBUrednici.ValueMember = "Value";
                comboBUrednici.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message.ToString()); 
            }
            
            

        }

        private async void btnSacuvajKnjigu_Click(object sender, EventArgs e)
        {
            try
            {
                //ISession session = DataLayer.GetSession();
                
                if (tbIzdavac.Text.Length > 0 && tbMestoIzdavanja.Text.Length > 0 && comboBUrednici.SelectedValue!=null)
                {
                    _knjiga.Izdavac = tbIzdavac.Text;
                    _knjiga.MestoIzdavanja = tbMestoIzdavanja.Text;

                    
                    

                    _session.SaveOrUpdate(_knjiga);
                   
                    
                    
                    this.Close();
                    _session.Flush();
                    _session.Close();
                    MessageBox.Show("Knjiga sacuvana");

                }
                else
                {
                    if(tbIzdavac.Text.Length == 0)
                    {
                        tbIzdavac.Clear();
                        tbIzdavac.Text = "Unesite izdavaca";
                        await Task.Delay(1000);
                        tbIzdavac.Clear();
                    }
                    else if(tbMestoIzdavanja.Text.Length==0)
                    {
                        tbMestoIzdavanja.Clear();
                        tbMestoIzdavanja.Text = "Unesite mesto izdavanja";
                        await Task.Delay(1000);
                        tbMestoIzdavanja.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Unesite urednika ako postoji u listi. U suprotnom kreirajte novog urednika");
                    }
                    
                }
               

            }

            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
                _session.Close();
                this.Close();
                //session.Close();
            }
        }

        private void btnDodajUrednika_Click(object sender, EventArgs e)
        {
            try 
            {
                Urednik urednik = new Urednik();
                urednik = (Urednik)comboBUrednici.SelectedValue;
                Uredjuje uredjuje = new Uredjuje(_knjiga, urednik);
                _knjiga.Urednici.Add(uredjuje);
                urednik.Knjige.Add(uredjuje);
                _session.SaveOrUpdate(urednik);
                MessageBox.Show("Urednik dodat");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }
    }
}
