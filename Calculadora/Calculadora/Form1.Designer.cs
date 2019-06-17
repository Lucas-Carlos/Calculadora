namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsoma = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnporc = new System.Windows.Forms.Button();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btnelev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsoma
            // 
            this.btnsoma.Location = new System.Drawing.Point(12, 38);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(94, 34);
            this.btnsoma.TabIndex = 0;
            this.btnsoma.Text = "Somar";
            this.btnsoma.UseVisualStyleBackColor = true;
            this.btnsoma.Click += new System.EventHandler(this.btnsoma_Click);
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(112, 38);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(94, 34);
            this.btnsub.TabIndex = 1;
            this.btnsub.Text = "Subtrair";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnmult
            // 
            this.btnmult.Location = new System.Drawing.Point(12, 78);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(94, 34);
            this.btnmult.TabIndex = 2;
            this.btnmult.Text = "Multiplicar";
            this.btnmult.UseVisualStyleBackColor = true;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(112, 78);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(94, 34);
            this.btndiv.TabIndex = 3;
            this.btndiv.Text = "Dividir";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnporc
            // 
            this.btnporc.Location = new System.Drawing.Point(112, 118);
            this.btnporc.Name = "btnporc";
            this.btnporc.Size = new System.Drawing.Size(94, 34);
            this.btnporc.TabIndex = 4;
            this.btnporc.Text = "Porcentagem";
            this.btnporc.UseVisualStyleBackColor = true;
            this.btnporc.Click += new System.EventHandler(this.btnporc_Click);
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(12, 12);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(57, 20);
            this.txtn1.TabIndex = 5;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(75, 12);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(57, 20);
            this.txtn2.TabIndex = 6;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(138, 12);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(68, 20);
            this.txtresult.TabIndex = 7;
            // 
            // btnelev
            // 
            this.btnelev.Location = new System.Drawing.Point(12, 118);
            this.btnelev.Name = "btnelev";
            this.btnelev.Size = new System.Drawing.Size(94, 34);
            this.btnelev.TabIndex = 8;
            this.btnelev.Text = "Elevar";
            this.btnelev.UseVisualStyleBackColor = true;
            this.btnelev.Click += new System.EventHandler(this.btnelev_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 172);
            this.Controls.Add(this.btnelev);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.btnporc);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnsoma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsoma;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnporc;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btnelev;
    }
}

