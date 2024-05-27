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
    public partial class FrmEndereco : Form
    {
        public FrmEndereco()
        {
            InitializeComponent();
        }

        private void FrmEndereco_Load(object sender, EventArgs e)
        {
            var lista = Endereco.ObterLista();
            dgvUsuarios.Rows.Clear();
            int count = 0;
            foreach (var usuario in lista)
            {
                dgvUsuarios.Rows[count].Cells[0].Value = usuario.ID;
                dgvUsuarios.Rows[count].Cells[1].Value = usuario.ClienteId;
                dgvUsuarios.Rows[count].Cells[2].Value = usuario.Cep;
                dgvUsuarios.Rows[count].Cells[3].Value = usuario.Logradouro;
                dgvUsuarios.Rows[count].Cells[4].Value = usuario.Numero;
                dgvUsuarios.Rows[count].Cells[5].Value = usuario.Complemento;
                dgvUsuarios.Rows[count].Cells[6].Value = usuario.Bairro;
                dgvUsuarios.Rows[count].Cells[7].Value = usuario.Cidade;
                dgvUsuarios.Rows[count].Cells[8].Value = usuario.Uf;
                dgvUsuarios.Rows[count].Cells[9].Value = usuario.TipoEndereco;

                count++;
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Endereco endereco = new Endereco(
                txtClienteId.Text,
                maskTxtCep.Text,
                txtLogradouro.Text,
                maskTxtNumero.Text,
                txtComplemento.Text,
                txtBairro.Text,
                txtCidade.Text,
                maskTxtUf.Text,
                txtTipoEndereco.Text);
            endereco.Inserir();
            FrmEndereco_Load(sender, e);
        }

        private void txtId_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Endereco endereco = new(
                int.Parse(txtId.Text),
                txtClienteId.Text,
                maskTxtCep.Text,
                txtLogradouro.Text,
                maskTxtNumero.Text,
                txtComplemento.Text,
                txtBairro.Text,
                txtCidade.Text,
                maskTxtUf.Text,
                txtTipoEndereco.Text);

            if (endereco.Editar(endereco.ID))
            {
                FrmEndereco_Load(sender, e);
                MessageBox.Show($"o Endereço{endereco.ID} foi alterado com sucesso!");
            }
            else
            {
                MessageBox.Show($"Falha ao alterar o Endereço {endereco.ID}!");
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
