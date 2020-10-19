using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcVolume
{
    public partial class frmCalcVolume : Form
    {
        public frmCalcVolume()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double vol, comp, larg, alt;
            comp = Convert.ToDouble(txtComprimento.Text);
            larg = Convert.ToDouble(txtLargura.Text);
            alt = Convert.ToDouble(txtAltura.Text);
            vol = comp * larg * alt;
            txtResultado.Text = (vol.ToString());        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtComprimento.Text = "";
            txtLargura.Text = "";
            txtAltura.Text = "";
            txtResultado.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
