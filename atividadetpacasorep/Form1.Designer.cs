namespace atividadetpacasorep
{
    partial class frmtabuada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txttabuada = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnpara = new System.Windows.Forms.Button();
            this.btnfaca = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnenquanto = new System.Windows.Forms.Button();
            this.lblnum = new System.Windows.Forms.Label();
            this.lbltabuada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txttabuada
            // 
            this.txttabuada.Location = new System.Drawing.Point(209, 112);
            this.txttabuada.Multiline = true;
            this.txttabuada.Name = "txttabuada";
            this.txttabuada.Size = new System.Drawing.Size(100, 142);
            this.txttabuada.TabIndex = 0;
            this.txttabuada.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(209, 51);
            this.txtnum.Multiline = true;
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 20);
            this.txtnum.TabIndex = 1;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(595, 286);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 2;
            this.btnvoltar.Text = "voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            // 
            // btnpara
            // 
            this.btnpara.Location = new System.Drawing.Point(334, 286);
            this.btnpara.Name = "btnpara";
            this.btnpara.Size = new System.Drawing.Size(75, 23);
            this.btnpara.TabIndex = 3;
            this.btnpara.Text = "para";
            this.btnpara.UseVisualStyleBackColor = true;
            this.btnpara.Click += new System.EventHandler(this.btnpara_Click);
            // 
            // btnfaca
            // 
            this.btnfaca.Location = new System.Drawing.Point(209, 286);
            this.btnfaca.Name = "btnfaca";
            this.btnfaca.Size = new System.Drawing.Size(75, 23);
            this.btnfaca.TabIndex = 4;
            this.btnfaca.Text = "faca enquanto";
            this.btnfaca.UseVisualStyleBackColor = true;
            this.btnfaca.Click += new System.EventHandler(this.btnfaca_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(456, 286);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 5;
            this.btnlimpar.Text = "limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnenquanto
            // 
            this.btnenquanto.Location = new System.Drawing.Point(109, 286);
            this.btnenquanto.Name = "btnenquanto";
            this.btnenquanto.Size = new System.Drawing.Size(75, 23);
            this.btnenquanto.TabIndex = 6;
            this.btnenquanto.Text = "enquanto";
            this.btnenquanto.UseVisualStyleBackColor = true;
            this.btnenquanto.Click += new System.EventHandler(this.btnenquanto_Click);
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(106, 51);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(89, 13);
            this.lblnum.TabIndex = 7;
            this.lblnum.Text = "Digite um número";
            // 
            // lbltabuada
            // 
            this.lbltabuada.AutoSize = true;
            this.lbltabuada.Location = new System.Drawing.Point(106, 112);
            this.lbltabuada.Name = "lbltabuada";
            this.lbltabuada.Size = new System.Drawing.Size(50, 13);
            this.lbltabuada.TabIndex = 8;
            this.lbltabuada.Text = "Tabuada";
            // 
            // frmtabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltabuada);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.btnenquanto);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnfaca);
            this.Controls.Add(this.btnpara);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txttabuada);
            this.Name = "frmtabuada";
            this.Text = "tabuada ";
            this.Load += new System.EventHandler(this.frmtabuada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttabuada;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnpara;
        private System.Windows.Forms.Button btnfaca;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnenquanto;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lbltabuada;
    }
}

