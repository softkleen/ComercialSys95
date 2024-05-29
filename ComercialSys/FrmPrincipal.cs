using ComClassSys;

namespace ComercialSys
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteNovo frmCliente = new FrmClienteNovo();
            frmCliente.MdiParent = this;
            frmCliente.StartPosition = FormStartPosition.CenterScreen;
            frmCliente.Show();

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategoria = new FrmCategoria();
            frmCategoria.MdiParent = this;
            frmCategoria.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //FrmLogin login = new();
            //login.MdiParent = this;
            //login.StartPosition = FormStartPosition.CenterScreen;
            //this.Hide();
            //login.ShowDialog();

            //tslUsuario.Text = Program.Usuario.Nome + " - " + Program.Usuario.Nivel.Nome;

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteConsulta frmClienteConsulta = new FrmClienteConsulta();
            frmClienteConsulta.MdiParent = this;
            frmClienteConsulta.StartPosition = FormStartPosition.CenterScreen;
            frmClienteConsulta.Show();
        }
    }
}
