namespace ComercialSys
{
    partial class FrmClienteNovo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tbpDadosPessoais = new TabPage();
            txtClienteId = new TextBox();
            btnEditar = new Button();
            btnInsert = new Button();
            label4 = new Label();
            mxtCpf = new MaskedTextBox();
            mxtTelefone = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblNome = new Label();
            chkAtivo = new CheckBox();
            dtpDataNasc = new DateTimePicker();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            tbpEnderecos = new TabPage();
            btnAdicionaEndereco = new Button();
            btnSalvar = new Button();
            cmbTipoEndereco = new ComboBox();
            txtUf = new TextBox();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            txtComplemento = new TextBox();
            txtNumero = new TextBox();
            txtLogradouro = new TextBox();
            mxtCep = new MaskedTextBox();
            groupBox1 = new GroupBox();
            dgvEnderecos = new DataGridView();
            clnCep = new DataGridViewTextBoxColumn();
            clnLogradouro = new DataGridViewTextBoxColumn();
            clnNumero = new DataGridViewTextBoxColumn();
            clnComplemento = new DataGridViewTextBoxColumn();
            clnBairro = new DataGridViewTextBoxColumn();
            clnCidade = new DataGridViewTextBoxColumn();
            clnUf = new DataGridViewTextBoxColumn();
            clnTipoEndereco = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tbpDadosPessoais.SuspendLayout();
            tbpEnderecos.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpDadosPessoais);
            tabControl1.Controls.Add(tbpEnderecos);
            tabControl1.Location = new Point(32, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(515, 229);
            tabControl1.TabIndex = 0;
            // 
            // tbpDadosPessoais
            // 
            tbpDadosPessoais.Controls.Add(txtClienteId);
            tbpDadosPessoais.Controls.Add(btnEditar);
            tbpDadosPessoais.Controls.Add(btnInsert);
            tbpDadosPessoais.Controls.Add(label4);
            tbpDadosPessoais.Controls.Add(mxtCpf);
            tbpDadosPessoais.Controls.Add(mxtTelefone);
            tbpDadosPessoais.Controls.Add(label3);
            tbpDadosPessoais.Controls.Add(label2);
            tbpDadosPessoais.Controls.Add(label1);
            tbpDadosPessoais.Controls.Add(lblNome);
            tbpDadosPessoais.Controls.Add(chkAtivo);
            tbpDadosPessoais.Controls.Add(dtpDataNasc);
            tbpDadosPessoais.Controls.Add(txtEmail);
            tbpDadosPessoais.Controls.Add(txtNome);
            tbpDadosPessoais.Location = new Point(4, 24);
            tbpDadosPessoais.Name = "tbpDadosPessoais";
            tbpDadosPessoais.Padding = new Padding(3);
            tbpDadosPessoais.Size = new Size(507, 201);
            tbpDadosPessoais.TabIndex = 0;
            tbpDadosPessoais.Text = "Dados pessoais";
            tbpDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new Point(314, 110);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(100, 23);
            txtClienteId.TabIndex = 2;
            txtClienteId.Text = "0";
            txtClienteId.Visible = false;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(143, 162);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(25, 161);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 14;
            btnInsert.Text = "&Inserir";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 95);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 13;
            label4.Text = "Data de Nascimento";
            // 
            // mxtCpf
            // 
            mxtCpf.Location = new Point(24, 64);
            mxtCpf.Mask = "000.000.000-99";
            mxtCpf.Name = "mxtCpf";
            mxtCpf.Size = new Size(95, 23);
            mxtCpf.TabIndex = 12;
            // 
            // mxtTelefone
            // 
            mxtTelefone.Location = new Point(25, 110);
            mxtTelefone.Mask = "(99) 00000-0000";
            mxtTelefone.Name = "mxtTelefone";
            mxtTelefone.Size = new Size(100, 23);
            mxtTelefone.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 95);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 10;
            label3.Text = "Telefone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 49);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 9;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 49);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 8;
            label1.Text = "CPF";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(25, 8);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Checked = true;
            chkAtivo.CheckState = CheckState.Checked;
            chkAtivo.FlatAppearance.BorderSize = 0;
            chkAtivo.Location = new Point(434, 23);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 6;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Format = DateTimePickerFormat.Short;
            dtpDataNasc.Location = new Point(150, 110);
            dtpDataNasc.MaxDate = new DateTime(2024, 5, 27, 0, 0, 0, 0);
            dtpDataNasc.MinDate = new DateTime(1920, 1, 1, 0, 0, 0, 0);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(110, 23);
            dtpDataNasc.TabIndex = 5;
            dtpDataNasc.Value = new DateTime(2024, 5, 27, 0, 0, 0, 0);
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(130, 64);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(358, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(24, 23);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(390, 23);
            txtNome.TabIndex = 1;
            // 
            // tbpEnderecos
            // 
            tbpEnderecos.Controls.Add(btnAdicionaEndereco);
            tbpEnderecos.Controls.Add(btnSalvar);
            tbpEnderecos.Controls.Add(cmbTipoEndereco);
            tbpEnderecos.Controls.Add(txtUf);
            tbpEnderecos.Controls.Add(txtCidade);
            tbpEnderecos.Controls.Add(txtBairro);
            tbpEnderecos.Controls.Add(txtComplemento);
            tbpEnderecos.Controls.Add(txtNumero);
            tbpEnderecos.Controls.Add(txtLogradouro);
            tbpEnderecos.Controls.Add(mxtCep);
            tbpEnderecos.Location = new Point(4, 24);
            tbpEnderecos.Name = "tbpEnderecos";
            tbpEnderecos.Padding = new Padding(3);
            tbpEnderecos.Size = new Size(507, 201);
            tbpEnderecos.TabIndex = 1;
            tbpEnderecos.Text = "Endereços";
            tbpEnderecos.UseVisualStyleBackColor = true;
            // 
            // btnAdicionaEndereco
            // 
            btnAdicionaEndereco.Location = new Point(330, 166);
            btnAdicionaEndereco.Name = "btnAdicionaEndereco";
            btnAdicionaEndereco.Size = new Size(161, 23);
            btnAdicionaEndereco.TabIndex = 9;
            btnAdicionaEndereco.Text = "Adicionar &Novo";
            btnAdicionaEndereco.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(23, 166);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // cmbTipoEndereco
            // 
            cmbTipoEndereco.FormattingEnabled = true;
            cmbTipoEndereco.Items.AddRange(new object[] { "RES - Residencial", "COM - Comercial", "ENT - Entrega", "COB - Cobrança", "RET - Retirada", "TMP - Temporário" });
            cmbTipoEndereco.Location = new Point(21, 127);
            cmbTipoEndereco.Name = "cmbTipoEndereco";
            cmbTipoEndereco.Size = new Size(151, 23);
            cmbTipoEndereco.TabIndex = 7;
            // 
            // txtUf
            // 
            txtUf.Location = new Point(455, 78);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(36, 23);
            txtUf.TabIndex = 6;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(304, 78);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(145, 23);
            txtCidade.TabIndex = 5;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(178, 78);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(120, 23);
            txtBairro.TabIndex = 4;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(19, 78);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(153, 23);
            txtComplemento.TabIndex = 3;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(391, 32);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 2;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(104, 32);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(281, 23);
            txtLogradouro.TabIndex = 1;
            // 
            // mxtCep
            // 
            mxtCep.Location = new Point(19, 32);
            mxtCep.Mask = "00000-999";
            mxtCep.Name = "mxtCep";
            mxtCep.Size = new Size(79, 23);
            mxtCep.TabIndex = 0;
            mxtCep.MaskInputRejected += mxtCep_MaskInputRejected;
            mxtCep.Leave += mxtCep_Leave;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvEnderecos);
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(37, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(578, 404);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Novo Cliente";
            // 
            // dgvEnderecos
            // 
            dgvEnderecos.AllowUserToAddRows = false;
            dgvEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnderecos.Columns.AddRange(new DataGridViewColumn[] { clnCep, clnLogradouro, clnNumero, clnComplemento, clnBairro, clnCidade, clnUf, clnTipoEndereco });
            dgvEnderecos.Location = new Point(32, 253);
            dgvEnderecos.Name = "dgvEnderecos";
            dgvEnderecos.ReadOnly = true;
            dgvEnderecos.RowHeadersVisible = false;
            dgvEnderecos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEnderecos.Size = new Size(510, 125);
            dgvEnderecos.TabIndex = 1;
            dgvEnderecos.SelectionChanged += dgvEnderecos_SelectionChanged;
            // 
            // clnCep
            // 
            clnCep.Frozen = true;
            clnCep.HeaderText = "CEP";
            clnCep.Name = "clnCep";
            clnCep.ReadOnly = true;
            clnCep.Width = 60;
            // 
            // clnLogradouro
            // 
            clnLogradouro.HeaderText = "Logradouro";
            clnLogradouro.Name = "clnLogradouro";
            clnLogradouro.ReadOnly = true;
            clnLogradouro.Width = 200;
            // 
            // clnNumero
            // 
            clnNumero.HeaderText = "Número";
            clnNumero.Name = "clnNumero";
            clnNumero.ReadOnly = true;
            clnNumero.Width = 60;
            // 
            // clnComplemento
            // 
            clnComplemento.HeaderText = "Complemento";
            clnComplemento.Name = "clnComplemento";
            clnComplemento.ReadOnly = true;
            // 
            // clnBairro
            // 
            clnBairro.HeaderText = "Bairro";
            clnBairro.Name = "clnBairro";
            clnBairro.ReadOnly = true;
            clnBairro.Width = 150;
            // 
            // clnCidade
            // 
            clnCidade.HeaderText = "Cidade";
            clnCidade.Name = "clnCidade";
            clnCidade.ReadOnly = true;
            clnCidade.Width = 150;
            // 
            // clnUf
            // 
            clnUf.HeaderText = "UF";
            clnUf.Name = "clnUf";
            clnUf.ReadOnly = true;
            clnUf.Width = 30;
            // 
            // clnTipoEndereco
            // 
            clnTipoEndereco.HeaderText = "Tipo";
            clnTipoEndereco.Name = "clnTipoEndereco";
            clnTipoEndereco.ReadOnly = true;
            clnTipoEndereco.Width = 60;
            // 
            // FrmClienteNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FrmClienteNovo";
            Text = "FrmClienteNovo";
            Load += FrmClienteNovo_Load;
            tabControl1.ResumeLayout(false);
            tbpDadosPessoais.ResumeLayout(false);
            tbpDadosPessoais.PerformLayout();
            tbpEnderecos.ResumeLayout(false);
            tbpEnderecos.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbpDadosPessoais;
        private TabPage tbpEnderecos;
        private GroupBox groupBox1;
        private DateTimePicker dtpDataNasc;
        private TextBox txtEmail;
        private TextBox txtNome;
        private MaskedTextBox mxtTelefone;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblNome;
        private CheckBox chkAtivo;
        private Label label4;
        private MaskedTextBox mxtCpf;
        private Button btnInsert;
        private TextBox txtLogradouro;
        private MaskedTextBox mxtCep;
        private ComboBox cmbTipoEndereco;
        private TextBox txtUf;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtComplemento;
        private TextBox txtNumero;
        private Button btnAdicionaEndereco;
        private Button btnSalvar;
        private DataGridView dgvEnderecos;
        private Button btnEditar;
        private DataGridViewTextBoxColumn clnCep;
        private DataGridViewTextBoxColumn clnLogradouro;
        private DataGridViewTextBoxColumn clnNumero;
        private DataGridViewTextBoxColumn clnComplemento;
        private DataGridViewTextBoxColumn clnBairro;
        private DataGridViewTextBoxColumn clnCidade;
        private DataGridViewTextBoxColumn clnUf;
        private DataGridViewTextBoxColumn clnTipoEndereco;
        private TextBox txtClienteId;
    }
}