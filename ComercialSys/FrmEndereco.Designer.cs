namespace ComercialSys
{
    partial class FrmEndereco
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
            txtClienteId = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtTipoEndereco = new TextBox();
            txtLogradouro = new TextBox();
            txtComplemento = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnInserir = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            txtId = new TextBox();
            maskTxtCep = new MaskedTextBox();
            maskTxtUf = new MaskedTextBox();
            maskTxtNumero = new MaskedTextBox();
            dgvUsuarios = new DataGridView();
            clnClienteId = new DataGridViewTextBoxColumn();
            clnLogradouro = new DataGridViewTextBoxColumn();
            clnNumero = new DataGridViewTextBoxColumn();
            clnComplemento = new DataGridViewCheckBoxColumn();
            clnBairro = new DataGridViewTextBoxColumn();
            clnCidade = new DataGridViewTextBoxColumn();
            clnUf = new DataGridViewTextBoxColumn();
            clnTipoEndereco = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new Point(171, 32);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(116, 23);
            txtClienteId.TabIndex = 0;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(171, 173);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(241, 23);
            txtBairro.TabIndex = 5;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(171, 199);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(241, 23);
            txtCidade.TabIndex = 6;
            // 
            // txtTipoEndereco
            // 
            txtTipoEndereco.Location = new Point(171, 254);
            txtTipoEndereco.Name = "txtTipoEndereco";
            txtTipoEndereco.Size = new Size(241, 23);
            txtTipoEndereco.TabIndex = 8;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(171, 90);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(241, 23);
            txtLogradouro.TabIndex = 2;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(171, 144);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(241, 23);
            txtComplemento.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 7);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 35);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 19;
            label2.Text = "clienteId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 69);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 20;
            label3.Text = "Cep";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 98);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 21;
            label4.Text = "Logradouro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 123);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 22;
            label5.Text = "Numero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 152);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 0;
            label6.Text = "Complemento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(127, 181);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 23;
            label7.Text = "Bairro";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(127, 210);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 20;
            label8.Text = "Cidade";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(146, 231);
            label9.Name = "label9";
            label9.Size = new Size(19, 15);
            label9.TabIndex = 21;
            label9.Text = "Uf";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(86, 257);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 18;
            label10.Text = "TipoEndereco";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(141, 283);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 9;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(262, 283);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(396, 283);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(171, 3);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(61, 23);
            txtId.TabIndex = 19;
            txtId.TextChanged += txtId_TextChanged_1;
            // 
            // maskTxtCep
            // 
            maskTxtCep.Location = new Point(171, 61);
            maskTxtCep.Mask = "00000-000";
            maskTxtCep.Name = "maskTxtCep";
            maskTxtCep.Size = new Size(133, 23);
            maskTxtCep.TabIndex = 1;
            // 
            // maskTxtUf
            // 
            maskTxtUf.Location = new Point(171, 228);
            maskTxtUf.Mask = "LL";
            maskTxtUf.Name = "maskTxtUf";
            maskTxtUf.Size = new Size(100, 23);
            maskTxtUf.TabIndex = 7;
            // 
            // maskTxtNumero
            // 
            maskTxtNumero.Location = new Point(171, 115);
            maskTxtNumero.Mask = "00000";
            maskTxtNumero.Name = "maskTxtNumero";
            maskTxtNumero.Size = new Size(140, 23);
            maskTxtNumero.TabIndex = 3;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnClienteId, clnLogradouro, clnNumero, clnComplemento, clnBairro, clnCidade, clnUf, clnTipoEndereco });
            dgvUsuarios.Location = new Point(12, 312);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.Size = new Size(778, 132);
            dgvUsuarios.TabIndex = 15;
            // 
            // clnClienteId
            // 
            clnClienteId.Frozen = true;
            clnClienteId.HeaderText = "ClienteId";
            clnClienteId.Name = "clnClienteId";
            clnClienteId.ReadOnly = true;
            clnClienteId.Width = 70;
            // 
            // clnLogradouro
            // 
            clnLogradouro.Frozen = true;
            clnLogradouro.HeaderText = "Logradouro";
            clnLogradouro.Name = "clnLogradouro";
            clnLogradouro.ReadOnly = true;
            clnLogradouro.Width = 150;
            // 
            // clnNumero
            // 
            clnNumero.Frozen = true;
            clnNumero.HeaderText = "N°";
            clnNumero.Name = "clnNumero";
            clnNumero.ReadOnly = true;
            clnNumero.Width = 40;
            // 
            // clnComplemento
            // 
            clnComplemento.Frozen = true;
            clnComplemento.HeaderText = "Complemento";
            clnComplemento.Name = "clnComplemento";
            clnComplemento.ReadOnly = true;
            clnComplemento.Width = 150;
            // 
            // clnBairro
            // 
            clnBairro.Frozen = true;
            clnBairro.HeaderText = "Bairro";
            clnBairro.Name = "clnBairro";
            clnBairro.ReadOnly = true;
            clnBairro.Width = 115;
            // 
            // clnCidade
            // 
            clnCidade.Frozen = true;
            clnCidade.HeaderText = "Cidade";
            clnCidade.Name = "clnCidade";
            clnCidade.ReadOnly = true;
            clnCidade.Width = 90;
            // 
            // clnUf
            // 
            clnUf.Frozen = true;
            clnUf.HeaderText = "UF";
            clnUf.Name = "clnUf";
            clnUf.ReadOnly = true;
            clnUf.Width = 30;
            // 
            // clnTipoEndereco
            // 
            clnTipoEndereco.HeaderText = "Tipo Endereço";
            clnTipoEndereco.Name = "clnTipoEndereco";
            clnTipoEndereco.ReadOnly = true;
            clnTipoEndereco.Width = 130;
            // 
            // FrmEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvUsuarios);
            Controls.Add(maskTxtNumero);
            Controls.Add(maskTxtUf);
            Controls.Add(maskTxtCep);
            Controls.Add(txtId);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnInserir);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtComplemento);
            Controls.Add(txtLogradouro);
            Controls.Add(txtTipoEndereco);
            Controls.Add(txtCidade);
            Controls.Add(txtBairro);
            Controls.Add(txtClienteId);
            Name = "FrmEndereco";
            Text = "FrmEndereco";
            Load += FrmEndereco_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtClienteId;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private TextBox txtTipoEndereco;
        private TextBox txtLogradouro;
        private TextBox txtComplemento;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnInserir;
        private Button btnEditar;
        private Button btnExcluir;
        private TextBox txtId;
        private MaskedTextBox maskTxtCep;
        private MaskedTextBox maskTxtUf;
        private MaskedTextBox maskTxtNumero;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn clnClienteId;
        private DataGridViewTextBoxColumn clnLogradouro;
        private DataGridViewTextBoxColumn clnNumero;
        private DataGridViewCheckBoxColumn clnComplemento;
        private DataGridViewTextBoxColumn clnBairro;
        private DataGridViewTextBoxColumn clnCidade;
        private DataGridViewTextBoxColumn clnUf;
        private DataGridViewTextBoxColumn clnTipoEndereco;
    }
}