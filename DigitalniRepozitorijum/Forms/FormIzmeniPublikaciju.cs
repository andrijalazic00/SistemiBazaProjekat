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
    public partial class FormIzmeniPublikaciju : Form
    {
        private ISession _session;
        private Publikacija _publikacija;
        private List<Publikacija> _publikacijaList;
        public FormIzmeniPublikaciju()
        {
            InitializeComponent();
            PopuniComboBox();
            this.Icon = Resources.Edit;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        public void PopuniComboBox()
        {
            try
            {
                _session = DataLayer.GetSession();
                _publikacijaList = _session.Query<Publikacija>().ToList();
                if (_publikacijaList.Count > 0)
                {
                    comboBPublikacija.DataSource = _publikacijaList;
                    comboBPublikacija.DisplayMember = "ID_P";
                }
                comboBPublikacija.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString() + "Neuspesno popunjavanje combo box-a. Nema Publikacija u bazi");
            }
           
        }

        private void btnObrisiPublikaciju_Click(object sender, EventArgs e)
        {
            try 
            {
                _publikacija = (Publikacija)comboBPublikacija.SelectedValue;
                _session.Delete(_publikacija);
                _session.Flush();
                _session.Close();
                MessageBox.Show("Publikacija obrisana");
                this.Close();
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message.ToString()); }
            

        }

        private void btnIzmeniPublikaciju_Click(object sender, EventArgs e)
        {
            try
            {
                _publikacija = (Publikacija)comboBPublikacija.SelectedValue;
                Form f = new FormDodajPublikaciju(_publikacija, _session);
                f.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
