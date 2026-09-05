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
    public partial class FormKnjigaIliPoglavlje : Form
    {
        private KnjigaIliPoglavlja _knjiga;

        public FormKnjigaIliPoglavlje()
        {
            InitializeComponent();
        }

        public FormKnjigaIliPoglavlje(KnjigaIliPoglavlja k)
        {
            InitializeComponent();
            _knjiga = k;
        }

        private async void btnSacuvajKnjigu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                if (tbIzdavac.Text.Length > 0 && tbMestoIzdavanja.Text.Length > 0)
                {
                    _knjiga.Izdavac = tbIzdavac.Text;
                    _knjiga.MestoIzdavanja = tbMestoIzdavanja.Text;
                    session.Save( _knjiga );

                }
                else
                {
                    if(tbIzdavac.Text.Length == 0)
                    {
                        tbIzdavac.Clear();
                        tbIzdavac.Text = "Unesite izdavaca";
                        await Task.Delay(1000);
                        tbIzdavac.Clear();
                    }
                    else 
                    {
                        tbMestoIzdavanja.Clear();
                        tbMestoIzdavanja.Text = "Unesite mesto izdavanja";
                        await Task.Delay(1000);
                        tbMestoIzdavanja.Clear();
                    }
                }
                session.Flush();
                session.Close();

            }

            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString() + ex.InnerException.ToString());
            }
        }
    }
}
