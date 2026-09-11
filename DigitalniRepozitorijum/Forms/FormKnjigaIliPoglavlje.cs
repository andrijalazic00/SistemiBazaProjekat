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
//using System.ServiceModel.Channels;


namespace DigitalniRepozitorijum.Forms
{
    public partial class FormKnjigaIliPoglavlje : Form
    {
        private ISession _session;
        private KnjigaIliPoglavlja _knjiga;
        private Dictionary<string, Urednik> _uredniciDict;
        private List<Urednik> _uredniciList;

        public FormKnjigaIliPoglavlje()
        {
            InitializeComponent();
        }

        public FormKnjigaIliPoglavlje(KnjigaIliPoglavlja k)
        {
            InitializeComponent();
            PopuniComboBox();
            _knjiga = k;
        }

        public void PopuniComboBox()
        {
            _session = DataLayer.GetSession();
            _uredniciList = _session.Query<Urednik>().ToList();
            _uredniciDict = _uredniciList.ToDictionary(i => i.ID_I != null ? i.ID_I.Ime + " " + i.ID_I.Prezime + " " + i.ID_U : i.ID_U.ToString());
            if(_uredniciDict.Count==0)
            {
                
                MessageBox.Show("Nema urednika u bazi, kreirajte bar jednog urednika pre kreiranja knjige");
                _session.Close();
                this.Close();
                
            }
            comboBUrednici.DataSource = new BindingSource(_uredniciDict, null);
            comboBUrednici.DisplayMember = "Key";
            comboBUrednici.ValueMember = "Value";
            comboBUrednici.DropDownStyle=ComboBoxStyle.DropDownList;
            

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

                    
                    Urednik urednik = (Urednik)comboBUrednici.SelectedValue;
                    Uredjuje uredjuje=new Uredjuje(_knjiga,urednik);
                    _knjiga.Urednici.Add(uredjuje);
                    urednik.Knjige.Add(uredjuje);

                    _session.Save(_knjiga);
                    _session.SaveOrUpdate(urednik);
                    
                    
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
    }
}
