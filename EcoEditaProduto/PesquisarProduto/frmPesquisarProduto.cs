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

namespace EcoEditaProduto.PesquisarProduto
{
    public partial class frmPesquisarProduto : Form
    {
        frmMain main = null;

        //metodos
        void AtualizaDgv()
        {
            try
            {
                string pesquisarPor()
                {
                    switch (cbxPesquisarPor.Text)
                    {
                        case "Código":
                            return "pdt.produto";
                        case "Descrição":
                            return "pdg.descricao";
                        case "Marca":
                            return "mrc.descricao";
                        case "Grupo":
                            return "grp.grupo";
                        case "Sub grupo":
                            return "sgp.subgrupo";
                        case "Referência":
                            return "pdg.referencia";
                        default:
                            return null;
                    }
                }
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

                dataProduto.AtualizaDgv(dgvProduto, pesquisarPor(), tbxPalavraChave.Text, chkAtivo());
                lblEncontrados.Text = "Produtos encontrados: " + dgvProduto.RowCount;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops! Algo inesperado aconteceu, contate o seu suporte." + "\n" + "\n" + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            AtualizaDgv();
        }

        private void TbxPalavraChave_TextChanged(object sender, EventArgs e)
        {
            AtualizaDgv();
        }

        private void ChkInativos_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaDgv();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            main.tbxIdProduto.Text = dgvProduto.CurrentRow.Cells[0].Value.ToString();
            main.tbxDescProduto.Text = dgvProduto.CurrentRow.Cells[1].Value.ToString();
            Close();

        }
    }
}
