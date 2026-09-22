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
using NHibernate;

namespace DigitalniRepozitorijum.Forms
{
    public partial class FormIzmeniAngazovanje : Form
    {
        private List<NaucnoIstrazivackaInstitucija> _institucijeList;
        private List<Angazovanje> _angazovanjeList;
        private Dictionary<string, Angazovanje> _angazovanjeDict;
        private Dictionary<string, Istrazivac> _istrazivacDict;
        public FormIzmeniAngazovanje()
        {
            InitializeComponent();
            PopuniComboBox();
        }
        private void PopuniComboBox()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                _angazovanjeList = s.Query<Angazovanje>().ToList();
                _angazovanjeDict = _angazovanjeList.ToDictionary(a => a.NazivPozicije + "; " + a.OrganizacionaJedinica + "; " + a.ID_I.Ime + " " + a.ID_I.Prezime +"; "+ a.ID_NII.Naziv);

                


              

                if (_angazovanjeDict.Count == 0)
                {

                    s.Close();
                    MessageBox.Show("Nema angazovanja u bazi");
                    this.Close();
                }
                comboBAngazovanje.DataSource = new BindingSource(_angazovanjeDict, null);
                comboBAngazovanje.DisplayMember = "Key";
                comboBAngazovanje.ValueMember = "Value";

                comboBAngazovanje.DropDownStyle = ComboBoxStyle.DropDownList;
                
            }
            
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
            } 
           
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try 
            {
                Angazovanje angazovanje = (Angazovanje)comboBAngazovanje.SelectedValue;
                
                Form f = new FormAngazovanje(angazovanje);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try 
            {
                Angazovanje angazovanje = (Angazovanje)comboBAngazovanje.SelectedValue;
                angazovanje.ID_I.Institucije.Remove(angazovanje);
                angazovanje.ID_NII.Istrazivaci.Remove(angazovanje);
                ISession session = DataLayer.GetSession();
                session.Delete(angazovanje);
                session.Flush();
                session.Close();
                MessageBox.Show("Angazovanje obrisano");
                this.Close();

            }
            catch(Exception ex)
            {  
                MessageBox.Show(ex.Message.ToString()+" Neuspelo brisanje");
            }
        }
    }
}
