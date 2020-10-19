using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMoeda
{
    public partial class frmCalcMoeda : Form
    {
        public frmCalcMoeda()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double moedaDolar, moedaReal, calcMoeda;
            moedaReal = Convert.ToDouble(txtReal.Text);
            moedaDolar = Convert.ToDouble(txtDolar.Text);
            calcMoeda = moedaReal / moedaDolar;
            txtResultado.Text = (calcMoeda.ToString());
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtReal.Text = "";
            txtDolar.Text = "";
            txtResultado.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
