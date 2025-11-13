namespace atividadetpacasorep
{
    partial class frmtemperatura
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btnpara = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnenqaunto = new System.Windows.Forms.Button();
            this.btnfaca = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "resultado em fahrenheint";
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(265, 109);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(100, 166);
            this.txtresult.TabIndex = 1;
            // 
            // btnpara
            // 
            this.btnpara.Location = new System.Drawing.Point(306, 309);
            this.btnpara.Name = "btnpara";
            this.btnpara.Size = new System.Drawing.Size(75, 23);
            this.btnpara.TabIndex = 2;
            this.btnpara.Text = "para";
            this.btnpara.UseVisualStyleBackColor = true;
            this.btnpara.Click += new System.EventHandler(this.btnpara_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(431, 309);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnenqaunto
            // 
            this.btnenqaunto.Location = new System.Drawing.Point(55, 309);
            this.btnenqaunto.Name = "btnenqaunto";
            this.btnenqaunto.Size = new System.Drawing.Size(75, 23);
            this.btnenqaunto.TabIndex = 4;
            this.btnenqaunto.Text = "enquanto";
            this.btnenqaunto.UseVisualStyleBackColor = true;
            this.btnenqaunto.Click += new System.EventHandler(this.btnenqaunto_Click);
            // 
            // btnfaca
            // 
            this.btnfaca.Location = new System.Drawing.Point(187, 309);
            this.btnfaca.Name = "btnfaca";
            this.btnfaca.Size = new System.Drawing.Size(75, 23);
            this.btnfaca.TabIndex = 5;
            this.btnfaca.Text = "faca ";
            this.btnfaca.UseVisualStyleBackColor = true;
            this.btnfaca.Click += new System.EventHandler(this.btnfaca_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(564, 309);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 6;
            this.btnvoltar.Text = "voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmtemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnfaca);
            this.Controls.Add(this.btnenqaunto);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnpara);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.label1);
            this.Name = "frmtemperatura";
            this.Text = "converção temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btnpara;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnenqaunto;
        private System.Windows.Forms.Button btnfaca;
        private System.Windows.Forms.Button btnvoltar;
    }
}