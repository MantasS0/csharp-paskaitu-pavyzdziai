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
    public partial class SkaiciavimaiForma : Form
    {
        public SkaiciavimaiForma(Automobiliai automobiliai)
        {
            InitializeComponent();

            var naujausias = automobiliai.Naujausias();
            naujausioInfo.Rows.Add(naujausias.Marke, naujausias.Modelis, naujausias.Rida, naujausias.Metai, naujausias.DarbinisTuris, naujausias.KuroTipas);

            var didzRidos = automobiliai.DidziausiosRidos();
            didziausiosRidos.Rows.Add(didzRidos.Marke, didzRidos.Modelis, didzRidos.Rida, didzRidos.Metai,
                didzRidos.DarbinisTuris, didzRidos.KuroTipas);
        }
    }
}
