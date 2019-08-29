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
            modelInformacoes model = data.BuscaInformacoes(tbxIdProduto.Text,cbxEmpresa.Text.Substring(0,2),cbxAlmoxarifado.Text.Substring(0,2));

            tbxObservacao.Text = model.observacao;
            tbxComposicao.Text = model.composicao;
            tbxLocalizacao.Text = model.endereco;
            tbxAplicacao.Text = model.aplicacao;
            tbxReferencia.Text = model.referencia;
            tbxDescProduto.Text = model.descricao;
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
            dataMain.BuscaEmpresa(cbxEmpresa);
            cbxEmpresa.SelectedIndex = 0;
            dataMain.BuscaAlmox(cbxAlmoxarifado, cbxEmpresa.Text.Substring(0, 2));
            cbxAlmoxarifado.SelectedIndex = 0;

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TbxIdProduto_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TbxIdProduto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxIdProduto.Text))
            {
                LimpaTela();
                return;
            }

            BuscaInformacoes();

        }

        private void TbxIdProduto_Enter(object sender, EventArgs e)
        {
            tbxIdProduto.Focus();
            tbxIdProduto.Select(0, tbxIdProduto.Text.Length);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxIdProduto.Text) || string.IsNullOrWhiteSpace(tbxDescProduto.Text))
            {
                return;
            }

            try
            {
                modelInformacoes model = new modelInformacoes();
                model.observacao = tbxObservacao.Text;
                model.composicao = tbxComposicao.Text;
                model.aplicacao = tbxAplicacao.Text;
                model.referencia = tbxReferencia.Text;
                model.codigo = tbxIdProduto.Text;
                model.endereco = tbxLocalizacao.Text;
                dataMain.SalvarInformacoes(model, cbxEmpresa.Text.Substring(0, 2), cbxAlmoxarifado.Text.Substring(0, 2));
                MessageBox.Show("Dados alterados com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaTela();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops! Algo inesperado aconteceu, contate o seu suporte." + "\n" + "\n" + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

    }
}
