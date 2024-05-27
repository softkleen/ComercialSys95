namespace ComercialSys
{
    partial class FrmCliente
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
            txtNome = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnInserir = new Button();
            btnEditar = new Button();
            masktxtDataNasc = new MaskedTextBox();
            masktxtCpf = new MaskedTextBox();
            masketxtTell = new MaskedTextBox();
            groupBox1 = new GroupBox();
            label8 = new Label();
            masktxtAtivo = new MaskedTextBox();
            label7 = new Label();
            maskedTxtDataCad = new MaskedTextBox();
            txtId = new TextBox();
            dgvUsuarios = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewCheckBoxColumn();
            clnDataNasc = new DataGridViewTextBoxColumn();
            clnDataCad = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            txtBusca = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(326, 56);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(348, 23);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(326, 143);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(348, 23);
            txtEmail.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 30);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 8;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 59);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 9;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 88);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 10;
            label3.Text = "Cpf";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(271, 117);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 11;
            label4.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(282, 146);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(208, 175);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 13;
            label6.Text = "Data de Nascimento";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(51, 196);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 6;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(251, 196);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // masktxtDataNasc
            // 
            masktxtDataNasc.Location = new Point(326, 167);
            masktxtDataNasc.Mask = "00/00/0000";
            masktxtDataNasc.Name = "masktxtDataNasc";
            masktxtDataNasc.Size = new Size(88, 23);
            masktxtDataNasc.TabIndex = 5;
            // 
            // masktxtCpf
            // 
            masktxtCpf.Location = new Point(326, 88);
            masktxtCpf.Mask = "000.000.000-00";
            masktxtCpf.Name = "masktxtCpf";
            masktxtCpf.Size = new Size(348, 23);
            masktxtCpf.TabIndex = 2;
            // 
            // masketxtTell
            // 
            masketxtTell.Location = new Point(326, 117);
            masketxtTell.Mask = "(00)00000-0000";
            masketxtTell.Name = "masketxtTell";
            masketxtTell.Size = new Size(348, 23);
            masketxtTell.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(masktxtAtivo);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(maskedTxtDataCad);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Location = new Point(208, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(506, 237);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(389, 19);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 19;
            label8.Text = "Ativo";
            // 
            // masktxtAtivo
            // 
            masktxtAtivo.Location = new Point(430, 15);
            masktxtAtivo.Mask = "0";
            masktxtAtivo.Name = "masktxtAtivo";
            masktxtAtivo.ReadOnly = true;
            masktxtAtivo.Size = new Size(36, 23);
            masktxtAtivo.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(198, 18);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 17;
            label7.Text = "Data Cadastro";
            // 
            // maskedTxtDataCad
            // 
            maskedTxtDataCad.Location = new Point(285, 15);
            maskedTxtDataCad.Mask = "00/00/0000";
            maskedTxtDataCad.Name = "maskedTxtDataCad";
            maskedTxtDataCad.ReadOnly = true;
            maskedTxtDataCad.Size = new Size(75, 23);
            maskedTxtDataCad.TabIndex = 16;
            // 
            // txtId
            // 
            txtId.Location = new Point(119, 15);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(61, 23);
            txtId.TabIndex = 15;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnCpf, clnTelefone, clnEmail, clnDataNasc, clnDataCad, clnAtivo });
            dgvUsuarios.Location = new Point(12, 288);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.Size = new Size(778, 150);
            dgvUsuarios.TabIndex = 14;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 40;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 200;
            // 
            // clnCpf
            // 
            clnCpf.Frozen = true;
            clnCpf.HeaderText = "Cpf";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            clnCpf.Width = 90;
            // 
            // clnTelefone
            // 
            clnTelefone.Frozen = true;
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            clnTelefone.ReadOnly = true;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 165;
            // 
            // clnDataNasc
            // 
            clnDataNasc.Frozen = true;
            clnDataNasc.HeaderText = "Data_Nasc";
            clnDataNasc.Name = "clnDataNasc";
            clnDataNasc.ReadOnly = true;
            clnDataNasc.Width = 70;
            // 
            // clnDataCad
            // 
            clnDataCad.Frozen = true;
            clnDataCad.HeaderText = "Data_cad";
            clnDataCad.Name = "clnDataCad";
            clnDataCad.ReadOnly = true;
            clnDataCad.Width = 70;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 60;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(12, 255);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Digite pelo menos duas letras para pesquisar cliente";
            txtBusca.Size = new Size(776, 23);
            txtBusca.TabIndex = 13;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvUsuarios);
            Controls.Add(txtBusca);
            Controls.Add(masketxtTell);
            Controls.Add(masktxtCpf);
            Controls.Add(masktxtDataNasc);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(groupBox1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnInserir;
        private Button btnEditar;
        private MaskedTextBox masktxtDataNasc;
        private MaskedTextBox masktxtCpf;
        private MaskedTextBox masketxtTell;
        private GroupBox groupBox1;
        private DataGridView dgvUsuarios;
        private TextBox txtBusca;
        private TextBox txtId;
        private Label label7;
        private MaskedTextBox maskedTxtDataCad;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewCheckBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnDataNasc;
        private DataGridViewTextBoxColumn clnDataCad;
        private DataGridViewTextBoxColumn clnAtivo;
        private Label label8;
        private MaskedTextBox masktxtAtivo;
    }
}