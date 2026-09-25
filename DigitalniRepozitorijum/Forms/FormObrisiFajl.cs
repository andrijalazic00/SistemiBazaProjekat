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
    public partial class FormObrisiFajl : Form
    {
        private Verzija _verzija;
        private IstrazivackiRezultat _rezultat;
        private Dictionary<string, PripadajuciFajl> _fajlDict;
        private ISession _session;

        public FormObrisiFajl()
        {
            InitializeComponent();
        }

        public FormObrisiFajl(Verzija v, IstrazivackiRezultat i)
        {
            InitializeComponent();
            _verzija = v;
            _rezultat = i;
            PopuniComboBox();
            this.Icon = Resources.Delete;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Brisanje fajla";
        }

        private void PopuniComboBox()
        {
            try
            {
                _session = DataLayer.GetSession();
                List<PripadajuciFajl> fajlovi = new List<PripadajuciFajl>();
                fajlovi = _session.Query<PripadajuciFajl>().Where(i => i.ID_IR == _rezultat && i.BrojVerzije==_verzija.BrojVerzije).ToList();
                if (fajlovi.Count == 0)
                {
                    MessageBox.Show("Ne postoji ni jedan fajl izabranog istrazivackog rezultata");
                    _session.Close();
                    this.Close();
                    return;
                }
                _fajlDict = fajlovi.ToDictionary(i => i.NazivFajla);

                comboBoxFajl.DataSource = new BindingSource(_fajlDict, null);
                comboBoxFajl.DisplayMember = "Key";
                comboBoxFajl.ValueMember = "Value";

                comboBoxFajl.DropDownStyle = ComboBoxStyle.DropDownList;
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void btnObrisiFajl_Click(object sender, EventArgs e)
        {
            try
            { 
                PripadajuciFajl fajl = (PripadajuciFajl)comboBoxFajl.SelectedValue;
                _rezultat.PripadajuciFajlovi.Remove(fajl);
                _session.Delete(fajl);
                _session.Flush();
                _session.Close();
                MessageBox.Show("Fajl obrisan");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
