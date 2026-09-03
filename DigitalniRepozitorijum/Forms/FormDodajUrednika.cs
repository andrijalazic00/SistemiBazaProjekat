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

namespace DigitalniRepozitorijum
{
    public partial class FormDodajUrednika : Form
    {
        Urednik _urednik;
        public FormDodajUrednika()
        {
            InitializeComponent();
        }

        public FormDodajUrednika(Urednik u)

        {

            InitializeComponent();
            _urednik = u;
        }

        private async void btnDodajUpravljackuSekciju_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbUredjivackaSekcija.Text.Length > 0)
                {
                    _urednik.UredjivackaSekcija = tbUredjivackaSekcija.Text;
                }
                else
                {
                    tbUredjivackaSekcija.Text = "Unesite neku vrednost";
                    await Task.Delay(1000);
                    tbUredjivackaSekcija.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
