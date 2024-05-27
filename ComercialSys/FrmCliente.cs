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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtNome.Text, masktxtCpf.Text, masketxtTell.Text, txtEmail.Text, Endereco.ObterPorId(Convert.ToInt32(cmbEndCliente.SelectedValue)), masktxtDataNasc.Text);
            cliente.Inserir();
            FrmCliente_Load(sender, e);


        }

        private void txtDataNasc_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            var lista = Cliente.ObterLista();
            dgvUsuarios.Rows.Clear();
            int count = 0;
            foreach (var usuario in lista)
            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[count].Cells[0].Value = usuario.Id;
                dgvUsuarios.Rows[count].Cells[0].Value = usuario.Nome;
                dgvUsuarios.Rows[count].Cells[0].Value = usuario.Cpf;
                dgvUsuarios.Rows[count].Cells[0].Value = usuario.Telefone;
                dgvUsuarios.Rows[count].Cells[0].Value = usuario.Email;
                dgvUsuarios.Rows[count].Cells[0].Value = usuario.Data_nasc;
                dgvUsuarios.Rows[count].Cells[0].Value = usuario.Data_cad;
                dgvUsuarios.Rows[count].Cells[0].Value = usuario.Ativo;

                count++;
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(
                int.Parse(txtId.Text),
                txtNome.Text,
                masktxtCpf.Text,
                masketxtTell.Text,
                txtEmail.Text,
                masktxtDataNasc.Text,
                maskedTxtDataCad.Text,
               Convert.ToSByte( masktxtAtivo.Text)
                );
            if (cliente.Editar(cliente.Id))
            {
                FrmCliente_Load(sender, e);
                MessageBox.Show($"O cliente{cliente.Nome} foi editado com sucesso!");
            }
            else
            {
                MessageBox.Show($"Falha ao alterar o Cliente \"{cliente.Id}\" !");
            }
            return cliente;
        }

        private void btnObterEndereco_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtEndCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
