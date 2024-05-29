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
    public partial class FrmClienteNovo : Form
    {
        public FrmClienteNovo()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            mxtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mxtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Cliente cliente = new(
                    txtNome.Text,
                    mxtCpf.Text,
                    mxtTelefone.Text,
                    txtEmail.Text,
                    dtpDataNasc.Value
                );
            cliente.Inserir();
            if (cliente.Id > 0)
            {
                txtClienteId.Text = cliente.Id.ToString();
                MessageBox.Show($"Cliente {cliente.GetHashCode()} cadastrado com sucesso");
            }

        }
        private void CarregaGrid(int clienteId)
        {
            var listaEnderecos = Endereco.ObterListaPorCliente(clienteId);
            int count = 0;
            // Preenche o DataGridView com todos os endereços
            dgvEnderecos.Rows.Clear();
            foreach (var endereco in listaEnderecos)
            {
                int rowIndex = dgvEnderecos.Rows.Add();
                dgvEnderecos.Rows[count].Cells[0].Value = endereco.Cep;
                dgvEnderecos.Rows[count].Cells[1].Value = endereco.Logradouro;
                dgvEnderecos.Rows[count].Cells[2].Value = endereco.Numero;
                dgvEnderecos.Rows[count].Cells[3].Value = endereco.Complemento;
                dgvEnderecos.Rows[count].Cells[4].Value = endereco.Bairro;
                dgvEnderecos.Rows[count].Cells[5].Value = endereco.Cidade;
                dgvEnderecos.Rows[count].Cells[6].Value = endereco.Uf;
                dgvEnderecos.Rows[count].Cells[7].Value = endereco.TipoEndereco;
                count++;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string tipoEnd = cmbTipoEndereco.SelectedItem.ToString();
            tipoEnd = tipoEnd.Substring(0, 3);
            mxtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Endereco endereco = new(
                    int.Parse(txtClienteId.Text),
                    mxtCep.Text,
                    txtLogradouro.Text,
                    txtNumero.Text,
                    txtComplemento.Text,
                    txtBairro.Text,
                    txtCidade.Text,
                    txtUf.Text,
                    tipoEnd
                );

            endereco.Inserir();

            CarregaGrid(int.Parse(txtClienteId.Text));
        }

        private void mxtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void mxtCep_Leave(object sender, EventArgs e)
        {
            mxtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mxtCep.Text.Length == 8)
            {
                WebCEP webCEP = new(mxtCep.Text);
                txtLogradouro.Text = webCEP.TipoLagradouro + " " + webCEP.Lagradouro;
                txtBairro.Text = webCEP.Bairro;
                txtCidade.Text = webCEP.Cidade;
                txtUf.Text = webCEP.UF;
                txtNumero.Focus();

            }
        }

        private void FrmClienteNovo_Load(object sender, EventArgs e)
        {

        }

        private void dgvEnderecos_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
