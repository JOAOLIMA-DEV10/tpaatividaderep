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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void tabuadaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmtabuada tabuada = new frmtabuada();
            tabuada.Show();
            this.Hide();
        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtemperatura temperatura = new frmtemperatura();
            temperatura.Show();
            this.Hide(); 
        }

        private void casaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmareacasa casa = new frmareacasa();
            casa.Show();
            this.Hide();
        }
    }
}
