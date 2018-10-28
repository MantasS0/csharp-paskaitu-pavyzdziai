using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2018_10_24_2
{
    public partial class Form1 : Form
    {
        public Automobiliai Automobiliai { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void iseitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nuskaitytiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog failas = new OpenFileDialog();
            failas.Filter = "CSV failas|*.csv";
            failas.Title = "CSV Failas";

            if (failas.ShowDialog() == DialogResult.OK)
            {
                Automobiliai = new Automobiliai(failas.FileName);
                dataGridView1.DataSource = Automobiliai.AutomobiliuSarasas;
            }
        }

        private void skaiciavimaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new SkaiciavimaiForma(Automobiliai);
            forma.ShowDialog();
        }
    }
}
