using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2018_10_24_1
{
    public partial class SiustasVardasForma : Form
    {
        public SiustasVardasForma(string vardas)
        {
            InitializeComponent();
            label1.Text = "Labas,\n" + vardas;
        }
    }
}
