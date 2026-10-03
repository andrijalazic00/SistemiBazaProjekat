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
    public partial class FormDodajUlogu : Form
    {
        private static readonly string[] _opcije = { "Rukovodilac projekta", "Administrator repozitorijuma", "Urednik", "Recezent", "Autor" };
        public FormDodajUlogu()
        {
            InitializeComponent();           
            cBoxUloga.Items.AddRange(_opcije);
            cBoxUloga.DropDownStyle = ComboBoxStyle.DropDownList;

            this.Icon = Resources.Plus;
            this.BackColor = System.Drawing.Color.Azure;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        

        private void btnDodajUlogu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session =DataLayer.GetSession();
                
                if (cBoxUloga.Text.Length > 0)
                {

                    Form f;
                    switch (cBoxUloga.Text)
                    {
                        case "Administrator repozitorijuma":
                            AdministratorRepozitorijuma a = new AdministratorRepozitorijuma();

                            f = new FormDodajAdministratora(a);
                            f.ShowDialog();
                            session.Save(a);
                            session.Flush();
                            session.Close();
                            MessageBox.Show("Uloga dodata");
                            break;

                        case "Urednik":
                            Urednik u = new Urednik();

                            f = new FormDodajUrednika(u);
                            f.ShowDialog();
                            session.Save(u);
                            session.Flush();
                            session.Close();
                            MessageBox.Show("Uloga dodata");
                            break;

                        case "Recezent":
                            Recenzent r = new Recenzent();

                            f = new FormDodajRecezenta(r);
                            f.ShowDialog();
                            session.Save(r);
                            session.Flush();
                            session.Close();
                            MessageBox.Show("Uloga dodata");
                            break;
                        case "Autor":
                            Autor autor = new Autor();

                            f = new FormDodajAutora(autor);
                            f.ShowDialog();
                            session.Save(autor);
                            session.Flush();
                            session.Close();
                            MessageBox.Show("Uloga dodata");
                            break;
                        case "Rukovodilac projekta":

                            RukovodilacProjekta rukovodilac = new RukovodilacProjekta();

                            session.Save(rukovodilac);
                            session.Flush();
                            session.Close();
                            MessageBox.Show("Uloga dodata");
                            break;

                    }
                }
                else
                {
                    
                    MessageBox.Show("Izaberite ulogu");
                }
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message.ToString()); 
                this.Close();
               
            }
        }
    }
}
