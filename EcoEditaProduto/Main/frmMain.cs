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
    }
}
