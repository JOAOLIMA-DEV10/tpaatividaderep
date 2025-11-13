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
    public partial class frmtemperatura : Form
    {
        public frmtemperatura()
        {
            InitializeComponent();
        }

        private void btnenqaunto_Click(object sender, EventArgs e)
        {
            double graus, f, i;
            i = 10;
            graus = 10;
            while (i<=100)
            {
                f = (graus * 1.8) + 32;
                graus = graus + 10;
                i = i + 10;
                txtresult.Text= String.Format(txtresult.Text + "\n" + f.ToString() + Environment.NewLine);

            }
        }

        private void btnfaca_Click(object sender, EventArgs e)
        {
            double graus, f, i;
            graus = 10;
            i = 10;
            do
            {
                f = (graus * 1.8) + 32;
                graus = graus + 10;
                i = i + 10;
                txtresult.Text = String.Format(txtresult.Text + "\n" + f.ToString() + Environment.NewLine);
            } while (i <= 100);
        }
        private void btnpara_Click(object sender, EventArgs e)
        {
            double graus, f;
            int i;
            graus = 10;
            if (graus <10 || graus > 100)
            {
                return;
            }
            for (i = 10; i <= 110; i++)
            {
                f = (graus * 1.8) + 32;
                graus = graus + 10;
                i = i + 10;
                txtresult.Text = String.Format(txtresult.Text + "\n" + f.ToString() + Environment.NewLine);

            }

        }


        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtresult.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            menu.Show();
            this.Hide();
        }
    }
}
