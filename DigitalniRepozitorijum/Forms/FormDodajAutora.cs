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
    public partial class FormDodajAutora : Form
    {
        private Autor _autor;
        public FormDodajAutora()
        {
            InitializeComponent();
        }

        public FormDodajAutora(Autor a)
        {
            InitializeComponent();
            _autor = a;
        }

        private async void btnDodajORCID_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbORCID.Text.Length == 19)
                {
                    _autor.Orcid = tbORCID.Text;
                    this.Close();
                }
                else
                {
                    lblFormat.Text = "ORCID mora imati tacno 19 karaktera";
                    await Task.Delay(1000);
                    lblFormat.ResetText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
