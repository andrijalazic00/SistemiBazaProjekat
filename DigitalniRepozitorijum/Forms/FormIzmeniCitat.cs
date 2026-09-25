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
    public partial class FormIzmeniCitat : Form
    {
        private List<Citat> _citatList;
        private Dictionary<string, Citat> _citatDict;
    

        public FormIzmeniCitat()
        {
            InitializeComponent();
            PopuniComboBox();

            this.Icon = Resources.Edit;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void PopuniComboBox()
        {
            try
            {
                ISession s = DataLayer.GetSession();


                _citatList = s.Query<Citat>().ToList();
                _citatDict = _citatList.ToDictionary(c => c.CitiranaPublikacija + "; " + c.CitirajucaPublikacija + "; " + c.KontekstCitiranja+"; "+c.TipCitata);

                if (_citatDict.Count == 0)
                {

                    s.Close();
                    MessageBox.Show("Nema citata u bazi");
                    this.Close();
                }
                comboBCitati.DataSource = new BindingSource(_citatDict, null);
                comboBCitati.DisplayMember = "Key";
                comboBCitati.ValueMember = "Value";

                comboBCitati.DropDownStyle = ComboBoxStyle.DropDownList;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnObrisiCitat_Click(object sender, EventArgs e)
        {
            try {
                Citat citat = (Citat)comboBCitati.SelectedValue;
                citat.ID_P1.CitiranePublikacije.Remove(citat);
                citat.ID_P2.CitirajucePublikacije.Remove(citat);
                ISession session = DataLayer.GetSession();
                session.Delete(citat);
                session.Flush();
                session.Close();
                MessageBox.Show("Citat obrisan");
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnIzmeniCitat_Click(object sender, EventArgs e)
        {
            Citat citat = (Citat)comboBCitati.SelectedValue;
            Form f = new FormDodajCitat(citat);
            f.ShowDialog();
        }
    }
}
