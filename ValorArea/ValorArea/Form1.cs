using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValorArea
{
    public partial class frmValorArea : Form
    {
        public frmValorArea()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double raio, area;
            raio = Convert.ToDouble(txtRaio.Text);
            area = Math.PI * Math.Pow(raio, 2);
            txtResultado.Text = (area.ToString());
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRaio.Text = "";
            txtResultado.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
