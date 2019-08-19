using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoEditaProduto.Main
{
    public partial class frmMain : Form
    {
        //METODOS
        public void BuscaInformacoes()
        {
            dataMain data = new dataMain();
            modelInformacoes model = data.BuscaInformacoes(tbxIdProduto.Text);

            tbxObservacao.Text = model.observacao;
            tbxComposicao.Text = model.composicao;
            tbxLocalizacao.Text = model.endereco;
            tbxAplicacao.Text = model.aplicacao;
            tbxReferencia.Text = model.referencia;
        }

        public void LimpaTela()
        {
            tbxIdProduto.Text = null;
            tbxDescProduto.Text = null;
            tbxObservacao.Text = null;
            tbxComposicao.Text = null;
            tbxLocalizacao.Text = null;
            tbxAplicacao.Text = null;
            tbxReferencia.Text = null;
            tbxIdProduto.Focus();
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TbxIdProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                PesquisarProduto.frmPesquisarProduto frmProduto = new PesquisarProduto.frmPesquisarProduto(this);
                frmProduto.ShowDialog();
            }
        }

        private void TbxIdProduto_Leave(object sender, EventArgs e)
        {
            BuscaInformacoes();

        }

        private void TbxIdProduto_Enter(object sender, EventArgs e)
        {
            tbxIdProduto.Focus();
            tbxIdProduto.Select(0, tbxIdProduto.Text.Length);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                modelInformacoes model = new modelInformacoes();
                model.observacao = tbxObservacao.Text;
                model.composicao = tbxComposicao.Text;
                model.aplicacao = tbxAplicacao.Text;
                model.referencia = tbxReferencia.Text;
                model.codigo = tbxIdProduto.Text;
                dataMain.SalvarInformacoes(model);
                MessageBox.Show("Dados alterados com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaTela();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops! Algo inesperado aconteceu, contate o seu suporte." + "\n" + "\n" + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
