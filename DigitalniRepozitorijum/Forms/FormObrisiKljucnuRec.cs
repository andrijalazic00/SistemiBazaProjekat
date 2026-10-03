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
    public partial class FormObrisiKljucnuRec : Form
    {
        private IstrazivackiRezultat _rezultat;
        private Dictionary<string, KljucnaRec> _kljucnaRecDict;
        private ISession _session;

        public FormObrisiKljucnuRec()
        {
            InitializeComponent();
        }
        public FormObrisiKljucnuRec(IstrazivackiRezultat i)
        {
            InitializeComponent();
            _rezultat = i;
            PopuniComboBox();
            this.Icon = Resources.Delete;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Brisanje kljucne reci";
        }

        private void PopuniComboBox()
        {
            try
            {
                _session = DataLayer.GetSession();
                List<KljucnaRec> reci = new List<KljucnaRec>();
                reci = _session.Query<KljucnaRec>().Where(i => i.ID_IR == _rezultat).ToList();
                if (reci.Count == 0)
                {
                    MessageBox.Show("Ne postoji ni jedna kljucna rec izabranog istrazivackog rezultata");
                    _session.Close();
                    this.Close();
                }
                _kljucnaRecDict = reci.ToDictionary(i => i.Rec);

                comboBoxKljucnaRec.DataSource = new BindingSource(_kljucnaRecDict, null);
                comboBoxKljucnaRec.DisplayMember = "Key";
                comboBoxKljucnaRec.ValueMember = "Value";

                comboBoxKljucnaRec.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {

                KljucnaRec rec = new KljucnaRec();
                rec = (KljucnaRec)comboBoxKljucnaRec.SelectedValue;
                _rezultat.KljucneReci.Remove(rec);
                _session.Delete(rec);
                _session.Flush();
                _session.Close();
                MessageBox.Show("Kljucna rec obrisana");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
