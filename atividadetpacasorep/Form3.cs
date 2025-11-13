using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividadetpacasorep
{
    public partial class frmareacasa : Form
    {
        public frmareacasa()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            menu.Show();
            this.Hide();
        }

        private void btnpara_Click(object sender, EventArgs e)
        {

            double areatotal = 0.0, largura = 0.0, comprimento = 0.0, areaComodo = 0.0;
            DialogResult resultado = DialogResult.Yes;

        public Frm1()
        {
            InitializeComponent();
        }

        
        private void btncalcular_Click(object sender, EventArgs e)
        {
            DialogResult resultado = DialogResult.Yes;

            double largura, comprimento, areaComodo, areatotal;
            

            largura = Convert.ToDouble(txtlargura.Text);
            comprimento = Convert.ToDouble(txtcomp.Text);
            areaComodo = largura * comprimento;
            areatotal = areaComodo;
            txtareac.Text = areaComodo.ToString();

            resultado = MessageBox.Show("Deseja adicionar outro cômodo?", "Continuar", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                txtlargura.Clear();
                txtcomp.Clear();
                txtareac.Clear();
                txtlargura.Focus();
            }
            else if (resultado == DialogResult.No)
            {
                txtarear.Text = areatotal.ToString();
            }
        }
    }
    }
}
