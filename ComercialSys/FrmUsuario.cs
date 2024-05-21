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
            string nivel = String.Empty;
            nivel = cmbNivel.SelectedIndex == 0 ? "A" : "G";
            Usuario usuario = new Usuario(txtNome.Text, txtEmail.Text, txtSenha.Text, nivel);
            usuario.Inserir();

            FrmUsuario_Load(sender, e);

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            var lista = Usuario.ObterLista();
            dgvUsuarios.Rows.Clear();
            int count = 0;
            foreach (var usuario in lista)
            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[count].Cells[0].Value = usuario.Id;
                dgvUsuarios.Rows[count].Cells[1].Value = usuario.Nome;
                dgvUsuarios.Rows[count].Cells[2].Value = usuario.Email;
                dgvUsuarios.Rows[count].Cells[3].Value = usuario.Nivel;
                dgvUsuarios.Rows[count].Cells[4].Value = usuario.Ativo;

                count++;
            }


        }
    }
}
