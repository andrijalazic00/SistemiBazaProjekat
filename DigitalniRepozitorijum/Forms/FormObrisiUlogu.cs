using DigitalniRepozitorijum.Entities;
using DigitalniRepozitorijum.Properties;
using NHibernate;
using NHibernate.Exceptions;
using Oracle.ManagedDataAccess.Client;
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
    public partial class FormObrisiUlogu : Form
    {
        private Istrazivac _istrazivac;
        private ISession _session;
        private Dictionary<int, Uloga> _ulogaDict;
       
        public FormObrisiUlogu()
        {
            InitializeComponent();
            _istrazivac = null;
            PopuniComboBox();
            this.Icon = Resources.Delete;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Brisanje uloge";
        }
        public FormObrisiUlogu(Istrazivac i)
        {
            InitializeComponent();
            _istrazivac = i;
            PopuniComboBox();
            this.Icon = Resources.Delete;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Brisanje uloge istrazivaca";
        }

        private void PopuniComboBox()
        {
            try
            {
                _session = DataLayer.GetSession();
                List<Uloga> uloge = new List<Uloga>();

                if (_istrazivac == null)
                {
                    uloge = _session.Query<Uloga>().ToList();
                    if (uloge.Count == 0)
                    {
                        MessageBox.Show("Ne postoji ni jedna uloga u bazi");
                        _session.Close();
                        this.Close();
                        return;
                    }
                }
                else 
                {
                    uloge = _session.Query<Uloga>().Where(i => i.ID_I == _istrazivac).ToList();
                    if (uloge.Count == 0)
                    {
                        MessageBox.Show("Ne postoji ni jedna uloga izabranog istrazivaca");
                        _session.Close();
                        this.Close();
                        return;
                    }                   
                }
               
                _ulogaDict = uloge.ToDictionary(i => i.ID_U);

                comboBoxUloga.DataSource = new BindingSource(_ulogaDict, null);
                comboBoxUloga.DisplayMember = "Key";
                comboBoxUloga.ValueMember = "Value";

                comboBoxUloga.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }

        }

        private void btnObrisiUlogu_Click(object sender, EventArgs e)
        {
            try
            {
                Uloga uloga = new Uloga();
                uloga = (Uloga)comboBoxUloga.SelectedValue;
                if (_istrazivac != null)
                    _istrazivac.Uloge.Remove(uloga);
                _session.Delete(uloga);
                _session.Flush();
                _session.Close();
                MessageBox.Show("Uloga obrisana");
                this.Close();
            }
            catch (GenericADOException ex) when (ex.InnerException is OracleException oraEx && oraEx.Number == 1407)
            {
                MessageBox.Show("Izabrana uloga je kljucna za neku od veza, brisanje nije moguce");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
