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
    }
}
