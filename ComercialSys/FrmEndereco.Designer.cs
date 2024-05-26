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
            txtId = new TextBox();
            txtClienteId = new TextBox();
            txtCep = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtTipoEndereco = new TextBox();
            txtLogradouro = new TextBox();
            txtNumero = new TextBox();
            txtComplemento = new TextBox();
            txtUf = new TextBox();
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
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(172, 61);
            txtId.Name = "txtId";
            txtId.Size = new Size(116, 23);
            txtId.TabIndex = 0;
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new Point(172, 100);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(116, 23);
            txtClienteId.TabIndex = 0;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(172, 129);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(241, 23);
            txtCep.TabIndex = 0;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(172, 253);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(241, 23);
            txtBairro.TabIndex = 0;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(172, 282);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(241, 23);
            txtCidade.TabIndex = 0;
            // 
            // txtTipoEndereco
            // 
            txtTipoEndereco.Location = new Point(172, 340);
            txtTipoEndereco.Name = "txtTipoEndereco";
            txtTipoEndereco.Size = new Size(241, 23);
            txtTipoEndereco.TabIndex = 0;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(172, 158);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(241, 23);
            txtLogradouro.TabIndex = 0;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(172, 195);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 0;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(172, 224);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(241, 23);
            txtComplemento.TabIndex = 0;
            // 
            // txtUf
            // 
            txtUf.Location = new Point(172, 311);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(68, 23);
            txtUf.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 61);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 103);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "clienteId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 137);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 1;
            label3.Text = "Cep";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 166);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 1;
            label4.Text = "Logradouro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 195);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 2;
            label5.Text = "Numero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 232);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 3;
            label6.Text = "Complemento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(128, 261);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 4;
            label7.Text = "Bairro";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(128, 290);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 5;
            label8.Text = "Cidade";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(128, 319);
            label9.Name = "label9";
            label9.Size = new Size(19, 15);
            label9.TabIndex = 6;
            label9.Text = "Uf";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(81, 343);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 7;
            label10.Text = "TipoEndereco";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(114, 403);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 8;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(252, 403);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(406, 403);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // FrmEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(txtUf);
            Controls.Add(txtComplemento);
            Controls.Add(txtNumero);
            Controls.Add(txtLogradouro);
            Controls.Add(txtTipoEndereco);
            Controls.Add(txtCidade);
            Controls.Add(txtBairro);
            Controls.Add(txtCep);
            Controls.Add(txtClienteId);
            Controls.Add(txtId);
            Name = "FrmEndereco";
            Text = "FrmEndereco";
            Load += FrmEndereco_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtClienteId;
        private TextBox txtCep;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private TextBox txtTipoEndereco;
        private TextBox txtLogradouro;
        private TextBox txtNumero;
        private TextBox txtComplemento;
        private TextBox txtUf;
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
    }
}