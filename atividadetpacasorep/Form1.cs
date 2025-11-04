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
    public partial class frmtabuada : Form
    {
        public frmtabuada()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnenquanto_Click(object sender, EventArgs e)
        {

            double num, i, tabuada;
            i = 1;
            tabuada = 0;
            num = Convert.ToDouble(txtnum.Text);

            while (i <= 10 && num>=1 && num<=9)
            {

                tabuada = num * i;
                i++;
                txttabuada.Text = String.Format(txttabuada.Text + "\n" + tabuada.ToString() + Environment.NewLine);

            }

        }

        private void btnfaca_Click(object sender, EventArgs e)
        {
            double num, tabuada, i;
            i = 1;
            tabuada = 0;
            num=Convert.ToDouble(txtnum.Text);
            do
            {
                tabuada = num * i;
                i++;
                txttabuada.Text = String.Format(txttabuada.Text + "\n" + tabuada.ToString() + Environment.NewLine);


            } while (i <=10 && num >= 1 && num <= 9);
        }

        private void btnpara_Click(object sender, EventArgs e)
        {
            int num, i, tabuada;
            tabuada = 0;

            num = Convert.ToInt32(txtnum.Text);

            if (num < 1 || num > 9)
            {
                return;
            }

            for (i = 1; i <= 10; i++)
            {
                tabuada = num * i;
                txttabuada.Text = String.Format(txttabuada.Text + "\n" + tabuada.ToString() + Environment.NewLine);
            }

        }



       

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txttabuada.Clear();
            txtnum.Focus();
        }

        private void frmtabuada_Load(object sender, EventArgs e)
        {

        }
    }
}
    

