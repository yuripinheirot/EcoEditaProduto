namespace EcoEditaProduto.PesquisarProduto
{
    partial class frmPesquisarProduto
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.lblEncontrados = new System.Windows.Forms.Label();
            this.cbxPesquisarPor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPalavraChave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.chkInativos = new System.Windows.Forms.CheckBox();
            this.dsProdutos = new EcoEditaProduto.PesquisarProduto.dsProdutos();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.embalagemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precopraticadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(797, 476);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AllowUserToOrderColumns = true;
            this.dgvProduto.AutoGenerateColumns = false;
            this.dgvProduto.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produtoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.embalagemDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.referenciaDataGridViewTextBoxColumn,
            this.precopraticadoDataGridViewTextBoxColumn});
            this.dgvProduto.DataSource = this.dataTable1BindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduto.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProduto.Location = new System.Drawing.Point(12, 25);
            this.dgvProduto.MultiSelect = false;
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersWidth = 24;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(860, 374);
            this.dgvProduto.TabIndex = 3;
            this.dgvProduto.VirtualMode = true;
            // 
            // lblEncontrados
            // 
            this.lblEncontrados.AutoSize = true;
            this.lblEncontrados.Location = new System.Drawing.Point(9, 9);
            this.lblEncontrados.Name = "lblEncontrados";
            this.lblEncontrados.Size = new System.Drawing.Size(114, 13);
            this.lblEncontrados.TabIndex = 2;
            this.lblEncontrados.Text = "Produtos encontrados:";
            // 
            // cbxPesquisarPor
            // 
            this.cbxPesquisarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPesquisarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPesquisarPor.FormattingEnabled = true;
            this.cbxPesquisarPor.Items.AddRange(new object[] {
            "Descrição",
            "Código",
            "Marca",
            "Referência"});
            this.cbxPesquisarPor.Location = new System.Drawing.Point(12, 439);
            this.cbxPesquisarPor.Name = "cbxPesquisarPor";
            this.cbxPesquisarPor.Size = new System.Drawing.Size(205, 21);
            this.cbxPesquisarPor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar por";
            // 
            // tbxPalavraChave
            // 
            this.tbxPalavraChave.Location = new System.Drawing.Point(12, 479);
            this.tbxPalavraChave.Name = "tbxPalavraChave";
            this.tbxPalavraChave.Size = new System.Drawing.Size(205, 20);
            this.tbxPalavraChave.TabIndex = 0;
            this.tbxPalavraChave.TextChanged += new System.EventHandler(this.TbxPalavraChave_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Palavra chave";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(716, 476);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // chkInativos
            // 
            this.chkInativos.AutoSize = true;
            this.chkInativos.Location = new System.Drawing.Point(772, 8);
            this.chkInativos.Name = "chkInativos";
            this.chkInativos.Size = new System.Drawing.Size(100, 17);
            this.chkInativos.TabIndex = 5;
            this.chkInativos.Text = "&Mostrar inativos";
            this.chkInativos.UseVisualStyleBackColor = true;
            this.chkInativos.CheckedChanged += new System.EventHandler(this.ChkInativos_CheckedChanged);
            // 
            // dsProdutos
            // 
            this.dsProdutos.DataSetName = "dsProdutos";
            this.dsProdutos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dsProdutos;
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            this.produtoDataGridViewTextBoxColumn.DataPropertyName = "produto";
            this.produtoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            this.produtoDataGridViewTextBoxColumn.ReadOnly = true;
            this.produtoDataGridViewTextBoxColumn.Width = 65;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 375;
            // 
            // embalagemDataGridViewTextBoxColumn
            // 
            this.embalagemDataGridViewTextBoxColumn.DataPropertyName = "embalagem";
            this.embalagemDataGridViewTextBoxColumn.HeaderText = "Emb";
            this.embalagemDataGridViewTextBoxColumn.Name = "embalagemDataGridViewTextBoxColumn";
            this.embalagemDataGridViewTextBoxColumn.ReadOnly = true;
            this.embalagemDataGridViewTextBoxColumn.Width = 50;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // referenciaDataGridViewTextBoxColumn
            // 
            this.referenciaDataGridViewTextBoxColumn.DataPropertyName = "referencia";
            this.referenciaDataGridViewTextBoxColumn.HeaderText = "Referência";
            this.referenciaDataGridViewTextBoxColumn.Name = "referenciaDataGridViewTextBoxColumn";
            this.referenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precopraticadoDataGridViewTextBoxColumn
            // 
            this.precopraticadoDataGridViewTextBoxColumn.DataPropertyName = "precopraticado";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.precopraticadoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.precopraticadoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.precopraticadoDataGridViewTextBoxColumn.Name = "precopraticadoDataGridViewTextBoxColumn";
            this.precopraticadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmPesquisarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(885, 511);
            this.Controls.Add(this.chkInativos);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.tbxPalavraChave);
            this.Controls.Add(this.cbxPesquisarPor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEncontrados);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPesquisarProduto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de produto";
            this.Load += new System.EventHandler(this.FrmPesquisarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Label lblEncontrados;
        private System.Windows.Forms.ComboBox cbxPesquisarPor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPalavraChave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.CheckBox chkInativos;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private dsProdutos dsProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn embalagemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precopraticadoDataGridViewTextBoxColumn;
    }
}