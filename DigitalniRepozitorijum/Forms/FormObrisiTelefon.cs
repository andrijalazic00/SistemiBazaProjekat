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
    public partial class FormObrisiTelefon : Form
    {
        private Istrazivac _istrazivac;
        private NaucnoIstrazivackaInstitucija _institucija;
        private ISession _session;
        private Dictionary<string, Telefon> _telefonDict;
        private Dictionary<string, TelefonInstitucija> _telefonInstitucijaDict;
        public FormObrisiTelefon()
        {
            InitializeComponent();
        }

        public FormObrisiTelefon(Istrazivac i)
        {

            InitializeComponent();
            _istrazivac = i;
            _institucija = null;
            PopuniComboBox();
            this.Icon = Resources.Delete;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Brisanje telefona istrazivaca";
        }

        public FormObrisiTelefon(NaucnoIstrazivackaInstitucija i)
        {

            InitializeComponent();
            _istrazivac = null;
            _institucija = i;
            PopuniComboBox2();
            this.Icon = Resources.Delete;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Brisanje telefona naucno istrazivacke institucije";
        }
        private void PopuniComboBox()
        {
            try
            {
                _session = DataLayer.GetSession();
                List<Telefon> telefoni = new List<Telefon>();
                //mailovi = _istrazivac.Mailovi;
                telefoni = _session.Query<Telefon>().Where(i => i.ID_I == _istrazivac).ToList();
                if (telefoni.Count == 0)
                {
                    MessageBox.Show("Ne postoji ni jedan telefon izabranog istrazivaca");
                    _session.Close();
                    this.Close();
                }
                _telefonDict = telefoni.ToDictionary(i => i.Broj);

                comboBoxTelefon.DataSource = new BindingSource(_telefonDict, null);
                comboBoxTelefon.DisplayMember = "Key";
                comboBoxTelefon.ValueMember = "Value";

                comboBoxTelefon.DropDownStyle = ComboBoxStyle.DropDownList;
                //comboBoxMail.Items.AddRange(mailovi);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }

        }

        private void PopuniComboBox2()
        {
            try
            {
                _session = DataLayer.GetSession();
                List<TelefonInstitucija> telefoniInstitucija = new List<TelefonInstitucija>();
                telefoniInstitucija = _session.Query<TelefonInstitucija>().Where(i => i.ID_NII == _institucija).ToList();
                if (telefoniInstitucija.Count == 0)
                {
                    MessageBox.Show("Ne postoji ni jedan telefon izabrane institucije");
                    _session.Close();
                    this.Close();
                }
                _telefonInstitucijaDict = telefoniInstitucija.ToDictionary(i => i.Broj);

                comboBoxTelefon.DataSource = new BindingSource(_telefonInstitucijaDict, null);
                comboBoxTelefon.DisplayMember = "Key";
                comboBoxTelefon.ValueMember = "Value";

                comboBoxTelefon.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }

        }


        private void btnObrisiTelefon_Click(object sender, EventArgs e)
        {
            try
            {
                if(_institucija==null)
                {
                    Telefon telefon = new Telefon();
                    telefon = (Telefon)comboBoxTelefon.SelectedValue;
                    _istrazivac.Telefoni.Remove(telefon);
                    _session.Delete(telefon);
                 
                }
                else
                {
                    TelefonInstitucija telefon = new TelefonInstitucija();
                    telefon = (TelefonInstitucija)comboBoxTelefon.SelectedValue;
                    _institucija.Telefoni.Remove(telefon);
                    _session.Delete(telefon);
                    
                }
                _session.Flush();
                _session.Close();
                MessageBox.Show("Telefon obrisan");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
