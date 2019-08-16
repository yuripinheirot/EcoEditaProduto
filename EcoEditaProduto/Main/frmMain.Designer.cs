namespace EcoEditaProduto.Main
{
    partial class frmMain
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
            this.btnSair = new System.Windows.Forms.Button();
            this.tbxIdProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDescProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxObservacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxAplicacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxComposicao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxLocalizacao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbxReferencia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(574, 334);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // tbxIdProduto
            // 
            this.tbxIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIdProduto.Location = new System.Drawing.Point(15, 25);
            this.tbxIdProduto.MaxLength = 6;
            this.tbxIdProduto.Name = "tbxIdProduto";
            this.tbxIdProduto.Size = new System.Drawing.Size(67, 20);
            this.tbxIdProduto.TabIndex = 0;
            this.tbxIdProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxIdProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxIdProduto_KeyDown);
            this.tbxIdProduto.Leave += new System.EventHandler(this.TbxIdProduto_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Produto";
            // 
            // tbxDescProduto
            // 
            this.tbxDescProduto.Location = new System.Drawing.Point(88, 25);
            this.tbxDescProduto.Name = "tbxDescProduto";
            this.tbxDescProduto.ReadOnly = true;
            this.tbxDescProduto.Size = new System.Drawing.Size(561, 20);
            this.tbxDescProduto.TabIndex = 1;
            this.tbxDescProduto.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição";
            // 
            // tbxObservacao
            // 
            this.tbxObservacao.Location = new System.Drawing.Point(15, 64);
            this.tbxObservacao.MaxLength = 128;
            this.tbxObservacao.Name = "tbxObservacao";
            this.tbxObservacao.Size = new System.Drawing.Size(634, 20);
            this.tbxObservacao.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Observação";
            // 
            // tbxAplicacao
            // 
            this.tbxAplicacao.Location = new System.Drawing.Point(15, 181);
            this.tbxAplicacao.MaxLength = 384;
            this.tbxAplicacao.Multiline = true;
            this.tbxAplicacao.Name = "tbxAplicacao";
            this.tbxAplicacao.Size = new System.Drawing.Size(634, 59);
            this.tbxAplicacao.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Aplicação";
            // 
            // tbxComposicao
            // 
            this.tbxComposicao.Location = new System.Drawing.Point(15, 103);
            this.tbxComposicao.MaxLength = 128;
            this.tbxComposicao.Name = "tbxComposicao";
            this.tbxComposicao.Size = new System.Drawing.Size(634, 20);
            this.tbxComposicao.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Composição";
            // 
            // tbxLocalizacao
            // 
            this.tbxLocalizacao.Location = new System.Drawing.Point(15, 142);
            this.tbxLocalizacao.MaxLength = 128;
            this.tbxLocalizacao.Name = "tbxLocalizacao";
            this.tbxLocalizacao.Size = new System.Drawing.Size(634, 20);
            this.tbxLocalizacao.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Localização";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(493, 334);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // tbxReferencia
            // 
            this.tbxReferencia.Location = new System.Drawing.Point(15, 259);
            this.tbxReferencia.MaxLength = 384;
            this.tbxReferencia.Multiline = true;
            this.tbxReferencia.Name = "tbxReferencia";
            this.tbxReferencia.Size = new System.Drawing.Size(634, 59);
            this.tbxReferencia.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Referência";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(663, 369);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxReferencia);
            this.Controls.Add(this.tbxAplicacao);
            this.Controls.Add(this.tbxLocalizacao);
            this.Controls.Add(this.tbxComposicao);
            this.Controls.Add(this.tbxObservacao);
            this.Controls.Add(this.tbxDescProduto);
            this.Controls.Add(this.tbxIdProduto);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxObservacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxAplicacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxComposicao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxLocalizacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox tbxReferencia;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tbxIdProduto;
        public System.Windows.Forms.TextBox tbxDescProduto;
    }
}