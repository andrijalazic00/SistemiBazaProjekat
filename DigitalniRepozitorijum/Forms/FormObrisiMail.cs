using DigitalniRepozitorijum.Entities;
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
using NHibernate;

namespace DigitalniRepozitorijum.Forms
{
    public partial class FormObrisiMail : Form
    {
        private Istrazivac _istrazivac;
        private NaucnoIstrazivackaInstitucija _institucija;
        private ISession _session;
        private Dictionary<string, Mail> _mailDict;
        private Dictionary<string, MailInstitucija> _mailInstitucijaDict;
        public FormObrisiMail()
        {
            InitializeComponent();
        }
        public FormObrisiMail(Istrazivac i)
        {

            InitializeComponent();
            _istrazivac = i;
            _institucija = null;
            PopuniComboBox();
        }
        public FormObrisiMail(NaucnoIstrazivackaInstitucija i)
        {

            InitializeComponent();
            _istrazivac = null;
            _institucija = i;
            PopuniComboBox2();
        }

        private void PopuniComboBox()
        {
            try 
            {
                _session=DataLayer.GetSession();
                List<Mail> mailovi=new List<Mail>();
                //mailovi = _istrazivac.Mailovi;

                mailovi=_session.Query<Mail>().Where(i => i.ID_I == _istrazivac).ToList();
                if(mailovi.Count==0)
                {
                    MessageBox.Show("Ne postoji ni jedan mail izabranog istrazivaca");
                    _session.Close();
                    this.Close();
                }
                _mailDict = mailovi.ToDictionary(i=>i.MailAdresa);

                comboBoxMail.DataSource = new BindingSource(_mailDict, null);
                comboBoxMail.DisplayMember = "Key";
                comboBoxMail.ValueMember = "Value";

                comboBoxMail.DropDownStyle= ComboBoxStyle.DropDownList;
                //comboBoxMail.Items.AddRange(mailovi);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message.ToString()); }
            
        }

        private void PopuniComboBox2()
        {
            try
            {
                _session = DataLayer.GetSession();
                List<MailInstitucija> mailovi = new List<MailInstitucija>();
                //mailovi = _istrazivac.Mailovi;

                mailovi = _session.Query<MailInstitucija>().Where(i => i.ID_NII == _institucija).ToList();
                if (mailovi.Count == 0)
                {
                    MessageBox.Show("Ne postoji ni jedan mail izabrane institucije");
                    _session.Close();
                    this.Close();
                }
                _mailInstitucijaDict = mailovi.ToDictionary(i => i.MailAdresa);

                comboBoxMail.DataSource = new BindingSource(_mailInstitucijaDict, null);
                comboBoxMail.DisplayMember = "Key";
                comboBoxMail.ValueMember = "Value";

                comboBoxMail.DropDownStyle = ComboBoxStyle.DropDownList;
                //comboBoxMail.Items.AddRange(mailovi);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }

        }

        private void btnObrisiMail_Click(object sender, EventArgs e)
        {
            try
            {
                if (_institucija == null)
                {
                    Mail mail = new Mail();
                    mail = (Mail)comboBoxMail.SelectedValue;
                    _istrazivac.Mailovi.Remove(mail);
                    _session.Delete(mail);
                }
                else
                {
                    MailInstitucija mail = new MailInstitucija();
                    mail = (MailInstitucija)comboBoxMail.SelectedValue;
                    _institucija.Mailovi.Remove(mail);
                    _session.Delete(mail);
                }

                _session.Flush();
                _session.Close();
                MessageBox.Show("Mail obrisan");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }
    }
}
