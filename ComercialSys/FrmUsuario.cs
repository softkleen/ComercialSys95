using ComClassSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialSys
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(
                txtNome.Text,
                txtEmail.Text,
                txtSenha.Text,
                Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue)));
            usuario.Inserir();

            FrmUsuario_Load(sender, e);

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            //cmbNivel.Items.Clear();
            var niveis = Nivel.ObterLista();
            cmbNivel.DataSource = niveis;
            cmbNivel.DisplayMember = "nome";
            cmbNivel.ValueMember = "id";



            var lista = Usuario.ObterLista();
            dgvUsuarios.Rows.Clear();
            int count = 0;
            foreach (var usuario in lista)
            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[count].Cells[0].Value = usuario.Id;
                dgvUsuarios.Rows[count].Cells[1].Value = usuario.Nome;
                dgvUsuarios.Rows[count].Cells[2].Value = usuario.Email;
                dgvUsuarios.Rows[count].Cells[3].Value = usuario.Nivel.Nome;
                dgvUsuarios.Rows[count].Cells[4].Value = usuario.Ativo;

                count++;
            }


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "&Consultar")
            {
                txtSenha.Clear(); // limpa o campo senha
                txtConfSenha.Clear(); // limpa o campo de confirmação de senha
                txtEmail.Clear(); // limpa o campo email 
                txtNome.Clear(); // limpa o campo nome
                txtId.ReadOnly = false;
                txtId.Focus();
                btnConsultar.Text = "&Obter por ID";
                txtSenha.PlaceholderText = string.Empty;
            }
            else
            {
                if (txtId.Text.Length > 0)
                {
                    Usuario usuario = Usuario.ObterPorId(int.Parse(txtId.Text));
                    txtNome.Text = usuario.Nome;
                    txtEmail.Text = usuario.Email;
                    txtId.ReadOnly = true;
                    btnConsultar.Text = "&Consultar";
                    txtSenha.PlaceholderText = "[senha não alterada]";

                    cmbNivel.SelectedValue = usuario.Nivel.Id;
                    btnEditar.Enabled = true;
                }
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new(
                int.Parse(txtId.Text),
                txtNome.Text,
                txtEmail.Text,
                txtSenha.Text,
                Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue)),
                true);
            if (usuario.Editar(usuario.Id))
            {
                FrmUsuario_Load(sender, e);
                MessageBox.Show($"o Usuário {usuario.Nome} foi alterado com sucesso!");
            }
            else
            {
                MessageBox.Show($"Falha ao alterar o usuário \"{usuario.Nome}\" !");
            }
        }
    }
}
