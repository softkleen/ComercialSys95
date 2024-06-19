using ComClassSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialSys
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            var categorias = Categoria.ObterLista();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.ValueMember = "id";
            cmbCategoria.DisplayMember = "nome";

            var lista = Produto.ObterLista();
            dgvProdutos.Rows.Clear();
            int count = 0;
            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[count].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[count].Cells[1].Value = produto.CodBarras;
                dgvProdutos.Rows[count].Cells[2].Value = produto.Descricao;
                dgvProdutos.Rows[count].Cells[3].Value = produto.ValorUnit;
                dgvProdutos.Rows[count].Cells[4].Value = produto.UnidadeVenda;
                dgvProdutos.Rows[count].Cells[5].Value = produto.Categoria.Nome;
                dgvProdutos.Rows[count].Cells[6].Value = produto.EstoqueMinimo;
                dgvProdutos.Rows[count].Cells[7].Value = produto.ClasseDesconto;
                dgvProdutos.Rows[count].Cells[8].Value = produto.DataCad;


                count++;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(txtCodigosBarras.Text, txtDescricao.Text, decimal.Parse(txtValorUnit.Text), txtUnidadeVenda.Text, Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)), npEstoqueMinimo.Value, decimal.Parse(txtDesconto.Text));
            produto.Inserir();

            MessageBox.Show($"O produto com o id{produto.Id} foi criado com sucesso");

            FrmProduto_Load(sender, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(Convert.ToInt32(txtId.Text), txtCodigosBarras.Text, txtDescricao.Text, Convert.ToDecimal(txtValorUnit.Text),
              txtUnidadeVenda.Text,
              Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
             npEstoqueMinimo.Value,
              decimal.Parse(txtDesconto.Text));
        }

        private void btnCosultar_Click(object sender, EventArgs e)
        {
            if (btnCosultar.Text == "&Consultar")
            {
                txtCodigosBarras.Clear();
                txtValorUnit.Clear();
                txtUnidadeVenda.Clear();
                txtDescricao.Clear();
                txtDesconto.Clear();
                txtUnidadeVenda.Clear();
                npEstoqueMinimo.Value = 0;
                btnCosultar.Text = "&Obter por ID";

            }
            else
            {
                if (txtId.Text.Length > 0)
                {
                    Produto produto = Produto.BuscarPorId(int.Parse(txtId.Text));
                    txtCodigosBarras.Text = produto.CodBarras;
                    txtValorUnit.Text = Convert.ToString(produto.ValorUnit);
                    txtDescricao.Text = produto.Descricao;
                    txtDesconto.Text = Convert.ToString(produto.ClasseDesconto);
                    txtUnidadeVenda.Text = produto.UnidadeVenda;
                    npEstoqueMinimo.Value = produto.EstoqueMinimo;
                    cmbCategoria.SelectedIndex = cmbCategoria.FindString(produto.Categoria.Nome);
                    btnEditar.Enabled = true;
                }
            }
        }
    }
}
