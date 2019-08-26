using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EcoEditaProduto.Main;
using System.Data;
using FirebirdSql.Data.FirebirdClient;

namespace EcoEditaProduto.PesquisarProduto
{
    public partial class frmPesquisarProduto : Form
    {
        frmMain main = null;
        static BindingSource bind = null;

        //metodos
        void CarregarDgv()
        {
            try
            {
                string chkAtivo()
                {
                    if (chkInativos.Checked)
                    {
                        return " pdt.ativo in ('S','N') ";
                    }
                    else
                    {
                        return " pdt.ativo = 'S' ";
                    }
                }

                if (bind != null)
                {
                    dgvProduto.DataSource = bind.DataSource;
                    return;
                }

                dataProduto.AtualizaDgv(dgvProduto, chkAtivo());
                bind = new BindingSource();
                bind.DataSource = dgvProduto.DataSource;
                lblEncontrados.Text = "Produtos encontrados: " + dgvProduto.RowCount;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops! Algo inesperado aconteceu, contate o seu suporte." + "\n" + "\n" + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void AtualizaDgv()
        {
            string pesquisarPor()
            {
                switch (cbxPesquisarPor.Text)
                {
                    case "Código":
                        return "produto";
                    case "Descrição":
                        return "descricao";
                    case "Marca":
                        return "marca";
                    case "Grupo":
                        return "grupo";
                    case "Sub grupo":
                        return "subgrupo";
                    case "Referência":
                        return "referencia";
                    default:
                        return null;
                }
            }

            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dgvProduto.DataSource;
                bs.Filter = pesquisarPor() +" like '%" + tbxPalavraChave.Text + "%'";
                dgvProduto.DataSource = null;
                dgvProduto.DataSource = bs.DataSource;
                lblEncontrados.Text = "Produtos encontrados: " + dgvProduto.RowCount;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public frmPesquisarProduto(frmMain main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void FrmPesquisarProduto_Load(object sender, EventArgs e)
        {
            cbxPesquisarPor.Text = "Descrição";
            CarregarDgv();
        }

        private void TbxPalavraChave_TextChanged(object sender, EventArgs e)
        {
            //atualizaDgv();
            AtualizaDgv();
        }

        private void ChkInativos_CheckedChanged(object sender, EventArgs e)
        {
            CarregarDgv();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            main.tbxIdProduto.Text = dgvProduto.CurrentRow.Cells[0].Value.ToString();
            main.tbxDescProduto.Text = dgvProduto.CurrentRow.Cells[1].Value.ToString();
            main.BuscaInformacoes();
            Close();

        }

        private void TbxPalavraChave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (dgvProduto.Focused == false)
                {
                    if (e.KeyCode == Keys.Up)
                    {
                        int i = dgvProduto.CurrentRow.Index - 1;
                        dgvProduto.CurrentCell = dgvProduto.Rows[i].Cells[0];
                    }
                    else if (e.KeyCode == Keys.Down)
                    {
                        int i = dgvProduto.CurrentRow.Index + 1;
                        dgvProduto.CurrentCell = dgvProduto.Rows[i].Cells[0];
                    }
                }
            }
            catch
            {
            }
        }

        private void FrmPesquisarProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose(true);
        }
    }
}
