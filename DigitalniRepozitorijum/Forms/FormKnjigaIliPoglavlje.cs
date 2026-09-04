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
            _knjiga = k;
        }
    }
}
