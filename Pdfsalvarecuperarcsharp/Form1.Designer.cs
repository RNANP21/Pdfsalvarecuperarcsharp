namespace Pdfsalvarecuperarcsharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblArquivoPdf = new System.Windows.Forms.Label();
            this.btnCarregarPdf = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Arquivo PDF";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(167, 58);
            this.txtId.MaxLength = 7;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 3;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(167, 104);
            this.txtTitulo.MaxLength = 60;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(212, 20);
            this.txtTitulo.TabIndex = 4;
            this.txtTitulo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblArquivoPdf
            // 
            this.lblArquivoPdf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArquivoPdf.Location = new System.Drawing.Point(167, 158);
            this.lblArquivoPdf.Name = "lblArquivoPdf";
            this.lblArquivoPdf.Size = new System.Drawing.Size(212, 23);
            this.lblArquivoPdf.TabIndex = 5;
            // 
            // btnCarregarPdf
            // 
            this.btnCarregarPdf.FlatAppearance.BorderSize = 0;
            this.btnCarregarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarPdf.Image = ((System.Drawing.Image)(resources.GetObject("btnCarregarPdf.Image")));
            this.btnCarregarPdf.Location = new System.Drawing.Point(117, 143);
            this.btnCarregarPdf.Name = "btnCarregarPdf";
            this.btnCarregarPdf.Size = new System.Drawing.Size(44, 45);
            this.btnCarregarPdf.TabIndex = 6;
            this.btnCarregarPdf.UseVisualStyleBackColor = true;
            this.btnCarregarPdf.Click += new System.EventHandler(this.btnCarregarPdf_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(167, 225);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(287, 225);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 8;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCarregarPdf);
            this.Controls.Add(this.lblArquivoPdf);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblArquivoPdf;
        private System.Windows.Forms.Button btnCarregarPdf;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCarregar;
    }
}

