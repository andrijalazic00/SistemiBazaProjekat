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
    public partial class FormNaucniRad : Form
    {
        private NaucniRad _naucniRad;

        public FormNaucniRad()
        {
            InitializeComponent();
        }

        public FormNaucniRad(NaucniRad n)
        {
            InitializeComponent();
            _naucniRad = n;
        }

        private void btnSacuvajKnjigu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session= DataLayer.GetSession();
                if(comboBTipRada.Text.Length>0 && tbNazivCasopisa.Text.Length>0)
                {
                    _naucniRad.TipRada = comboBTipRada.Text;
                    _naucniRad.NazivCasKon = tbNazivCasopisa.Text;
                    _naucniRad.Doi=tbDOI.Text;
                    _naucniRad.IssnIliIsbn=tbISSN.Text;
                    _naucniRad.BrojStranice=(int)nudBrojSveske.Value;
                    _naucniRad.BrojIzdanja=(int)nudBrojIzdanja.Value;
                    _naucniRad.BrojStranice=(int)nudBrojStranice.Value;
                    session.Save(_naucniRad);


                }
                else
                {
                    MessageBox.Show("Popunite polja tip rada i naziv konferencije");
                }
                session.Flush();
                session.Close();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.InnerException.ToString());
            }
        }
    }
}
