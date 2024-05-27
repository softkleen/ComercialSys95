namespace ComercialSys
{
    partial class FrmClienteConsulta
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
            tdpEndereços = new TabPage();
            groupBox1 = new GroupBox();
            tztNome = new TextBox();
            txtEmail = new TextBox();
            dtpDataNasc = new DateTimePicker();
            chkAtivo = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            this.mxtTell = new MaskedTextBox();
            this.mxtCpf = new MaskedTextBox();
            label5 = new Label();
            btnInserir = new Button();
            mxtCep = new MaskedTextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            comboBox1 = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button1 = new Button();
            button2 = new Button();
            label12 = new Label();
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
            tdpEndereços.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpDadosPessoais);
            tabControl1.Controls.Add(tdpEndereços);
            tabControl1.Location = new Point(14, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(595, 346);
            tabControl1.TabIndex = 0;
            // 
            // tbpDadosPessoais
            // 
            tbpDadosPessoais.Controls.Add(btnInserir);
            tbpDadosPessoais.Controls.Add(label5);
            tbpDadosPessoais.Controls.Add(this.mxtCpf);
            tbpDadosPessoais.Controls.Add(this.mxtTell);
            tbpDadosPessoais.Controls.Add(label4);
            tbpDadosPessoais.Controls.Add(label3);
            tbpDadosPessoais.Controls.Add(label2);
            tbpDadosPessoais.Controls.Add(label1);
            tbpDadosPessoais.Controls.Add(chkAtivo);
            tbpDadosPessoais.Controls.Add(dtpDataNasc);
            tbpDadosPessoais.Controls.Add(txtEmail);
            tbpDadosPessoais.Controls.Add(tztNome);
            tbpDadosPessoais.Location = new Point(4, 24);
            tbpDadosPessoais.Name = "tbpDadosPessoais";
            tbpDadosPessoais.Padding = new Padding(3);
            tbpDadosPessoais.Size = new Size(587, 318);
            tbpDadosPessoais.TabIndex = 0;
            tbpDadosPessoais.Text = "Dados pessoais";
            tbpDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // tdpEndereços
            // 
            tdpEndereços.Controls.Add(label12);
            tdpEndereços.Controls.Add(button2);
            tdpEndereços.Controls.Add(button1);
            tdpEndereços.Controls.Add(label11);
            tdpEndereços.Controls.Add(label10);
            tdpEndereços.Controls.Add(label9);
            tdpEndereços.Controls.Add(comboBox1);
            tdpEndereços.Controls.Add(textBox6);
            tdpEndereços.Controls.Add(textBox4);
            tdpEndereços.Controls.Add(label8);
            tdpEndereços.Controls.Add(textBox3);
            tdpEndereços.Controls.Add(textBox2);
            tdpEndereços.Controls.Add(label7);
            tdpEndereços.Controls.Add(label6);
            tdpEndereços.Controls.Add(textBox1);
            tdpEndereços.Controls.Add(mxtCep);
            tdpEndereços.Location = new Point(4, 24);
            tdpEndereços.Name = "tdpEndereços";
            tdpEndereços.Padding = new Padding(3);
            tdpEndereços.Size = new Size(587, 318);
            tdpEndereços.TabIndex = 1;
            tdpEndereços.Text = "Endereços";
            tdpEndereços.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(96, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(615, 372);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Novo Cliente";
            // 
            // tztNome
            // 
            tztNome.Location = new Point(21, 21);
            tztNome.Name = "tztNome";
            tztNome.Size = new Size(472, 23);
            tztNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(199, 65);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(382, 23);
            txtEmail.TabIndex = 3;
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Format = DateTimePickerFormat.Short;
            dtpDataNasc.Location = new Point(199, 114);
            dtpDataNasc.MaxDate = new DateTime(2024, 5, 27, 0, 0, 0, 0);
            dtpDataNasc.MinDate = new DateTime(1920, 1, 1, 0, 0, 0, 0);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(107, 23);
            dtpDataNasc.TabIndex = 5;
            dtpDataNasc.Value = new DateTime(2024, 5, 27, 0, 0, 0, 0);
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Checked = true;
            chkAtivo.CheckState = CheckState.Checked;
            chkAtivo.Location = new Point(512, 23);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 6;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 3);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 8;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 47);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 9;
            label2.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 47);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 10;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 93);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 11;
            label4.Text = "Telefone";
            // 
            // mxtTell
            // 
            this.mxtTell.Location = new Point(21, 114);
            this.mxtTell.Mask = "(999) 000-0000";
            this.mxtTell.Name = "mxtTell";
            this.mxtTell.Size = new Size(130, 23);
            this.mxtTell.TabIndex = 13;
            // 
            // mxtCpf
            // 
            this.mxtCpf.Location = new Point(21, 67);
            this.mxtCpf.Mask = "000.000.000.-00";
            this.mxtCpf.Name = "mxtCpf";
            this.mxtCpf.Size = new Size(130, 23);
            this.mxtCpf.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(199, 93);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 15;
            label5.Text = "Data de Nascimento";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(23, 180);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(92, 24);
            btnInserir.TabIndex = 16;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // mxtCep
            // 
            mxtCep.Location = new Point(24, 39);
            mxtCep.Mask = "00000-000";
            mxtCep.Name = "mxtCep";
            mxtCep.Size = new Size(100, 23);
            mxtCep.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 23);
            textBox1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 21);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 2;
            label6.Text = "CEP";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(130, 21);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 3;
            label7.Text = "Logradouro";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(432, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(136, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(24, 82);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 23);
            textBox3.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(432, 21);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 6;
            label8.Text = "N°";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(250, 82);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(225, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(494, 82);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(74, 23);
            textBox6.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "RES - Residencial", "COM - Comercial", "ENT - Entrega", "COB - Cobrança", "RET - Retirada", "TEMP - Temporário" });
            comboBox1.Location = new Point(24, 132);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 23);
            comboBox1.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 65);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 11;
            label9.Text = "Cidade";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(250, 64);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 12;
            label10.Text = "Bairro";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(494, 65);
            label11.Name = "label11";
            label11.Size = new Size(21, 15);
            label11.TabIndex = 13;
            label11.Text = "UF";
            // 
            // button1
            // 
            button1.Location = new Point(39, 192);
            button1.Name = "button1";
            button1.Size = new Size(85, 23);
            button1.TabIndex = 14;
            button1.Text = "&Salvar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(447, 192);
            button2.Name = "button2";
            button2.Size = new Size(134, 23);
            button2.TabIndex = 14;
            button2.Text = "Adicionar &Novo";
            button2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 114);
            label12.Name = "label12";
            label12.Size = new Size(98, 15);
            label12.TabIndex = 15;
            label12.Text = "Tipo de Endereço";
            // 
            // dgvEnderecos
            // 
            dgvEnderecos.AllowUserToAddRows = false;
            dgvEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnderecos.Columns.AddRange(new DataGridViewColumn[] { clnCep, clnLogradouro, clnNumero, clnComplemento, clnBairro, clnCidade, clnUf, clnTipoEndereco });
            dgvEnderecos.Location = new Point(137, 381);
            dgvEnderecos.Name = "dgvEnderecos";
            dgvEnderecos.ReadOnly = true;
            dgvEnderecos.RowHeadersVisible = false;
            dgvEnderecos.Size = new Size(510, 150);
            dgvEnderecos.TabIndex = 2;
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
            // FrmClienteConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 559);
            Controls.Add(dgvEnderecos);
            Controls.Add(groupBox1);
            Name = "FrmClienteConsulta";
            Text = "FrmClienteConsulta";
            tabControl1.ResumeLayout(false);
            tbpDadosPessoais.ResumeLayout(false);
            tbpDadosPessoais.PerformLayout();
            tdpEndereços.ResumeLayout(false);
            tdpEndereços.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbpDadosPessoais;
        private TabPage tdpEndereços;
        private GroupBox groupBox1;
        private TextBox txtEmail;
        private TextBox tztNome;
        private DateTimePicker dtpDataNasc;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox chkAtivo;
        private Button btnInserir;
        private Label label5;
        private TextBox textBox2;
        private Label label7;
        private Label label6;
        private TextBox textBox1;
        private MaskedTextBox mxtCep;
        private Label label10;
        private Label label9;
        private ComboBox comboBox1;
        private TextBox textBox6;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox3;
        private Label label12;
        private Button button2;
        private Button button1;
        private Label label11;
        private DataGridView dgvEnderecos;
        private DataGridViewTextBoxColumn clnCep;
        private DataGridViewTextBoxColumn clnLogradouro;
        private DataGridViewTextBoxColumn clnNumero;
        private DataGridViewTextBoxColumn clnComplemento;
        private DataGridViewTextBoxColumn clnBairro;
        private DataGridViewTextBoxColumn clnCidade;
        private DataGridViewTextBoxColumn clnUf;
        private DataGridViewTextBoxColumn clnTipoEndereco;
    }
}