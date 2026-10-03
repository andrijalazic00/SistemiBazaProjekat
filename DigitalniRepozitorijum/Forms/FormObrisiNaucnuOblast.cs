using DigitalniRepozitorijum.Entities;
using DigitalniRepozitorijum.Properties;
using NHibernate;
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

namespace DigitalniRepozitorijum.Forms
{
    public partial class FormObrisiNaucnuOblast : Form
    {
        private NaucnoIstrazivackaInstitucija _institucija;
        private Dictionary<string, NaucnaOblast> _naucnaOblastDict;
        private ISession _session;
        public FormObrisiNaucnuOblast()
        {
            InitializeComponent();
        }
        public FormObrisiNaucnuOblast(NaucnoIstrazivackaInstitucija i)
        {
            InitializeComponent();
            _institucija = i;
            PopuniComboBox();
            this.Icon = Resources.Delete;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Brisanje naucne oblasti";

        }
        private void PopuniComboBox()
        {
            try
            {
                _session = DataLayer.GetSession();
                List<NaucnaOblast> naucneOblasti = new List<NaucnaOblast>();
                //mailovi = _istrazivac.Mailovi;
                naucneOblasti = _session.Query<NaucnaOblast>().Where(i => i.ID_NII == _institucija).ToList();
                if (naucneOblasti.Count == 0)
                {
                    MessageBox.Show("Ne postoji ni jedna naucna oblast izabrane institucije");
                    _session.Close();
                    this.Close();
                }
                _naucnaOblastDict = naucneOblasti.ToDictionary(i => i.Oblast);

                comboBoxNaucnaOblast.DataSource = new BindingSource(_naucnaOblastDict, null);
                comboBoxNaucnaOblast.DisplayMember = "Key";
                comboBoxNaucnaOblast.ValueMember = "Value";

                comboBoxNaucnaOblast.DropDownStyle = ComboBoxStyle.DropDownList;
                //comboBoxMail.Items.AddRange(mailovi);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                
                NaucnaOblast oblast = new NaucnaOblast();
                oblast = (NaucnaOblast)comboBoxNaucnaOblast.SelectedValue;
                _institucija.NaucneOblasti.Remove(oblast);
                _session.Delete(oblast);
                _session.Flush();
                _session.Close();
                MessageBox.Show("Naucna oblast obrisana");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
