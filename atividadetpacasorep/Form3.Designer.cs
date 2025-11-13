namespace atividadetpacasorep
{
    partial class frmareacasa
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
            this.lbllargura = new System.Windows.Forms.Label();
            this.lblcomprimento = new System.Windows.Forms.Label();
            this.lblareac = new System.Windows.Forms.Label();
            this.lblarear = new System.Windows.Forms.Label();
            this.txtlargura = new System.Windows.Forms.TextBox();
            this.txtcomp = new System.Windows.Forms.TextBox();
            this.txtareac = new System.Windows.Forms.TextBox();
            this.txtarear = new System.Windows.Forms.TextBox();
            this.btnenquanto = new System.Windows.Forms.Button();
            this.btnfaca = new System.Windows.Forms.Button();
            this.btnpara = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbllargura
            // 
            this.lbllargura.AutoSize = true;
            this.lbllargura.Location = new System.Drawing.Point(78, 66);
            this.lbllargura.Name = "lbllargura";
            this.lbllargura.Size = new System.Drawing.Size(95, 13);
            this.lbllargura.TabIndex = 0;
            this.lbllargura.Text = "largura do comodo";
            // 
            // lblcomprimento
            // 
            this.lblcomprimento.AutoSize = true;
            this.lblcomprimento.Location = new System.Drawing.Point(78, 119);
            this.lblcomprimento.Name = "lblcomprimento";
            this.lblcomprimento.Size = new System.Drawing.Size(123, 13);
            this.lblcomprimento.TabIndex = 1;
            this.lblcomprimento.Text = "comprimento do comodo";
            // 
            // lblareac
            // 
            this.lblareac.AutoSize = true;
            this.lblareac.Location = new System.Drawing.Point(78, 175);
            this.lblareac.Name = "lblareac";
            this.lblareac.Size = new System.Drawing.Size(84, 13);
            this.lblareac.TabIndex = 2;
            this.lblareac.Text = "aréa do comodo";
            // 
            // lblarear
            // 
            this.lblarear.AutoSize = true;
            this.lblarear.Location = new System.Drawing.Point(78, 233);
            this.lblarear.Name = "lblarear";
            this.lblarear.Size = new System.Drawing.Size(94, 13);
            this.lblarear.TabIndex = 3;
            this.lblarear.Text = "aréa da residencia";
            // 
            // txtlargura
            // 
            this.txtlargura.Location = new System.Drawing.Point(202, 63);
            this.txtlargura.Name = "txtlargura";
            this.txtlargura.Size = new System.Drawing.Size(100, 20);
            this.txtlargura.TabIndex = 5;
            // 
            // txtcomp
            // 
            this.txtcomp.Location = new System.Drawing.Point(202, 112);
            this.txtcomp.Name = "txtcomp";
            this.txtcomp.Size = new System.Drawing.Size(100, 20);
            this.txtcomp.TabIndex = 6;
            // 
            // txtareac
            // 
            this.txtareac.Location = new System.Drawing.Point(202, 175);
            this.txtareac.Name = "txtareac";
            this.txtareac.Size = new System.Drawing.Size(100, 20);
            this.txtareac.TabIndex = 7;
            // 
            // txtarear
            // 
            this.txtarear.Location = new System.Drawing.Point(202, 233);
            this.txtarear.Name = "txtarear";
            this.txtarear.Size = new System.Drawing.Size(100, 20);
            this.txtarear.TabIndex = 8;
            // 
            // btnenquanto
            // 
            this.btnenquanto.Location = new System.Drawing.Point(65, 352);
            this.btnenquanto.Name = "btnenquanto";
            this.btnenquanto.Size = new System.Drawing.Size(75, 23);
            this.btnenquanto.TabIndex = 9;
            this.btnenquanto.Text = "enquanto";
            this.btnenquanto.UseVisualStyleBackColor = true;
            // 
            // btnfaca
            // 
            this.btnfaca.Location = new System.Drawing.Point(213, 352);
            this.btnfaca.Name = "btnfaca";
            this.btnfaca.Size = new System.Drawing.Size(75, 23);
            this.btnfaca.TabIndex = 10;
            this.btnfaca.Text = "faca";
            this.btnfaca.UseVisualStyleBackColor = true;
            // 
            // btnpara
            // 
            this.btnpara.Location = new System.Drawing.Point(337, 352);
            this.btnpara.Name = "btnpara";
            this.btnpara.Size = new System.Drawing.Size(75, 23);
            this.btnpara.TabIndex = 11;
            this.btnpara.Text = "para";
            this.btnpara.UseVisualStyleBackColor = true;
            this.btnpara.Click += new System.EventHandler(this.btnpara_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(493, 352);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 12;
            this.btnlimpar.Text = "limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(627, 352);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 13;
            this.btnvoltar.Text = "voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmareacasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnpara);
            this.Controls.Add(this.btnfaca);
            this.Controls.Add(this.btnenquanto);
            this.Controls.Add(this.txtarear);
            this.Controls.Add(this.txtareac);
            this.Controls.Add(this.txtcomp);
            this.Controls.Add(this.txtlargura);
            this.Controls.Add(this.lblarear);
            this.Controls.Add(this.lblareac);
            this.Controls.Add(this.lblcomprimento);
            this.Controls.Add(this.lbllargura);
            this.Name = "frmareacasa";
            this.Text = "aréa da casa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllargura;
        private System.Windows.Forms.Label lblcomprimento;
        private System.Windows.Forms.Label lblareac;
        private System.Windows.Forms.Label lblarear;
        private System.Windows.Forms.TextBox txtlargura;
        private System.Windows.Forms.TextBox txtcomp;
        private System.Windows.Forms.TextBox txtareac;
        private System.Windows.Forms.TextBox txtarear;
        private System.Windows.Forms.Button btnenquanto;
        private System.Windows.Forms.Button btnfaca;
        private System.Windows.Forms.Button btnpara;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}