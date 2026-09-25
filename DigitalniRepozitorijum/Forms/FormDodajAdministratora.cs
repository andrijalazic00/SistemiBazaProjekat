using DigitalniRepozitorijum.Entities;
using DigitalniRepozitorijum.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalniRepozitorijum
{
    public partial class FormDodajAdministratora : Form
    {
        private AdministratorRepozitorijuma _administrator;
        public FormDodajAdministratora()
        {
            InitializeComponent();
        }

        public FormDodajAdministratora(AdministratorRepozitorijuma u)
        {
            InitializeComponent();
            _administrator = u;

            this.Icon = Resources.Plus;
            this.BackColor = System.Drawing.Color.Azure;
        }

        private async void btnDodajOvlascenje_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbOvlascenje.Text.Length>0)
                {
                    AdministratorOvlascenja ovlascenje= new AdministratorOvlascenja();
                    ovlascenje.Ovlascenje = tbOvlascenje.Text;
                    _administrator.Ovlascenja.Add(ovlascenje);
                    ovlascenje.ID_U = _administrator;
                    tbOvlascenje.Clear();
                    tbOvlascenje.Text = "Ovlascenje dodato";
                    await Task.Delay(1000);
                    tbOvlascenje.Clear();
                }
                else 
                {
                    tbOvlascenje.Text = "Unesite ovlascenje";
                    await Task.Delay(1000);
                    tbOvlascenje.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
