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
    public partial class FormGlavnaForma : Form
    {
        public FormGlavnaForma()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            Form form = new FormUnos();
            form.ShowDialog();

        }

        private void btnBrisanjeAzuriranje_Click(object sender, EventArgs e)
        {
            Form form = new FormBrisanjeIAzuriranje();
            form.ShowDialog();
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            Form form = new FormPrikaz();
            form.ShowDialog();
        }
    }
}
