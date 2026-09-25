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
    public partial class FormDodajRecezenta : Form
    {
        private Recenzent _recenzent;
        public FormDodajRecezenta()
        {
            InitializeComponent();
        }

        public FormDodajRecezenta(Recenzent r)

        {
            InitializeComponent();
            _recenzent = r;

            this.Icon = Resources.Plus;
            this.BackColor = System.Drawing.Color.Azure;
        }

        private async void btnOblastEkspertize_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbOblastEkspertize.Text.Length > 0)
                {
                    OblastiEkspertize oblast = new OblastiEkspertize();
                    oblast.Oblast = tbOblastEkspertize.Text;
                    _recenzent.OblastiEkspertize.Add(oblast);
                    oblast.ID_U = _recenzent;
                    tbOblastEkspertize.Clear();
                    tbOblastEkspertize.Text = "Oblast dodata";
                    await Task.Delay(1000);
                    tbOblastEkspertize.Clear();
                }
                else
                {
                    tbOblastEkspertize.Text = "Unesite oblast ekspertize";
                    await Task.Delay(1000);
                    tbOblastEkspertize.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
