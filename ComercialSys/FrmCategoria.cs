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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria(txtNome.Text, txtSigla.Text);
            categoria.Inserir();

            FrmCategoria_Load(sender, e);

        }



        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "&Consultar")
            {


                txtSigla.Clear(); // limpa o campo email 
                txtNome.Clear(); // limpa o campo nome
                txtId.ReadOnly = false;
                txtId.Focus();
                btnConsultar.Text = "&Obter por ID";

            }
            else
            {
                if (txtId.Text.Length > 0)
                {
                    Categoria categoria = Categoria.ObterPorId(int.Parse(txtId.Text));
                    txtNome.Text = categoria.Nome;
                    txtSigla.Text = categoria.Sigla;
                    btnEditar.Enabled = true;
                }
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new(
                int.Parse(txtId.Text),
                txtNome.Text,
                txtSigla.Text);
            if (categoria.Editar(categoria.Id))
            {
                FrmCategoria_Load(sender, e);
                MessageBox.Show($"o Categoria {categoria.Nome} foi alterada com sucesso!");
            }
            else
            {
                MessageBox.Show($"Falha ao alterar Categoria \"{categoria.Id}\" !");
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {

            var lista = Categoria.ObterLista();
            dgvUsuarios.Rows.Clear();
            int count = 0;
            foreach (var usuario in lista)
            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[count].Cells[0].Value = usuario.Id;
                dgvUsuarios.Rows[count].Cells[1].Value = usuario.Nome;
                dgvUsuarios.Rows[count].Cells[2].Value = usuario.Sigla;


                count++;
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text.Length > 0)
            {
                var lista = Categoria.ObterLista(txtBusca.Text);
                dgvUsuarios.Rows.Clear();
                int count = 0;
                foreach (var usuario in lista)
                {
                    dgvUsuarios.Rows.Add();
                    dgvUsuarios.Rows[count].Cells[0].Value = usuario.Id;
                    dgvUsuarios.Rows[count].Cells[1].Value = usuario.Nome;
                    dgvUsuarios.Rows[count].Cells[2].Value = usuario.Sigla;


                    count++;
                }
            }
        }
    }
}
