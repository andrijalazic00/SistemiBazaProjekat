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
namespace DigitalniRepozitorijum.Forms
{
    public partial class FormObrisiVerziju : Form
    {
        private Verzija _verzija;
        private IstrazivackiRezultat _rezultat;
        private Dictionary<string, Verzija> _verzijaDict;
        private ISession _session;

        public FormObrisiVerziju()
        {
            InitializeComponent();
        }
        public FormObrisiVerziju(IstrazivackiRezultat i)
        {
            InitializeComponent();
            _rezultat = i;
            _verzija = new Verzija();
            PopuniComboBox();
        }

        private void PopuniComboBox()
        {
            try
            {
                _session = DataLayer.GetSession();
                List<Verzija> verzije = new List<Verzija>();
                //mailovi = _istrazivac.Mailovi;
                verzije = _session.Query<Verzija>().Where(i => i.ID_IR == _rezultat).ToList();
                if (verzije.Count == 0)
                {
                    MessageBox.Show("Ne postoji ni jedna verzija izabranog istrazivackog rezultata");
                    _session.Close();
                    this.Close();
                }
                _verzijaDict = verzije.ToDictionary(i => i.BrojVerzije+" "+i.OpisIzmena);

                comboBoxVerzija.DataSource = new BindingSource(_verzijaDict, null);
                comboBoxVerzija.DisplayMember = "Key";
                comboBoxVerzija.ValueMember = "Value";

                comboBoxVerzija.DropDownStyle = ComboBoxStyle.DropDownList;
                //comboBoxMail.Items.AddRange(mailovi);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {

                
                _verzija = (Verzija)comboBoxVerzija.SelectedValue;
                _rezultat.Verzije.Remove(_verzija);
                _session.Delete(_verzija);
                _session.Flush();
                _session.Close();
                MessageBox.Show("Verzija obrisana");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void btnIzmeniVerziju_Click(object sender, EventArgs e)
        {
            _verzija = (Verzija)comboBoxVerzija.SelectedValue;
            Form f = new FormIzmeniVerziju(_verzija, _rezultat);
            f.ShowDialog();
        }
    }
}
