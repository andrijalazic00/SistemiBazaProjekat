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
    public partial class FormSoftverskiArtifakt : Form
    {
        private SoftverskiArtifakt _softverskiArtifakt;

        public FormSoftverskiArtifakt()
        {
            InitializeComponent();
        }

        public FormSoftverskiArtifakt(SoftverskiArtifakt sa)
        {
            InitializeComponent();
            _softverskiArtifakt = sa;
        }
    }
}
