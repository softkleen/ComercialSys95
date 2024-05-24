namespace ComercialSys
{
    partial class FrmCategoria
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
            dgvUsuarios = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnInserir = new Button();
            txtNome = new TextBox();
            label1 = new Label();
            txtSigla = new TextBox();
            label2 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtBusca = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnEmail });
            dgvUsuarios.Location = new Point(148, 281);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.Size = new Size(500, 150);
            dgvUsuarios.TabIndex = 6;
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
            clnNome.Width = 280;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Sigla";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 180;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSigla);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtId);
            groupBox1.Location = new Point(147, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(507, 188);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Categorias";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(251, 124);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(119, 23);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(144, 124);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(39, 124);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(119, 56);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(322, 23);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 30);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(119, 85);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(100, 23);
            txtSigla.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 59);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 88);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 0;
            label4.Text = "Sigla";
            // 
            // txtId
            // 
            txtId.Location = new Point(119, 27);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(61, 23);
            txtId.TabIndex = 6;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(147, 257);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Digite pelo menos duas letras para pesquisar categorias";
            txtBusca.Size = new Size(501, 23);
            txtBusca.TabIndex = 5;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvUsuarios);
            Controls.Add(groupBox1);
            Controls.Add(txtBusca);
            Name = "FrmCategoria";
            Text = "FrmCategoria";
            Load += FrmCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private GroupBox groupBox1;
        private ComboBox cmbNivel;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnInserir;
        private TextBox txtNome;
        private TextBox txtConfSenha;
        private Label label1;
        private TextBox txtSigla;
        private Label label6;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtId;
        private TextBox txtBusca;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
    }
}