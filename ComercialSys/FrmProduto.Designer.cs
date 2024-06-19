namespace ComercialSys
{
    partial class FrmProduto
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
            dgvProdutos = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnCodigoBarras = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnUnidadeVenda = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnEstoqueMinimo = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnData = new DataGridViewTextBoxColumn();
            gpProdutos = new GroupBox();
            cmbCategoria = new ComboBox();
            npEstoqueMinimo = new NumericUpDown();
            btnCosultar = new Button();
            btnAdicionar = new Button();
            btnEditar = new Button();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label9 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            txtCodigosBarras = new TextBox();
            txtDescricao = new TextBox();
            txtDesconto = new TextBox();
            txtValorUnit = new TextBox();
            txtUnidadeVenda = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            gpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)npEstoqueMinimo).BeginInit();
            SuspendLayout();
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCodigoBarras, clnDescricao, clnValorUnit, clnUnidadeVenda, clnCategoria, clnEstoqueMinimo, clnDesconto, clnData });
            dgvProdutos.Location = new Point(50, 394);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.Size = new Size(748, 150);
            dgvProdutos.TabIndex = 6;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            // 
            // clnCodigoBarras
            // 
            clnCodigoBarras.HeaderText = "Código de Barras";
            clnCodigoBarras.Name = "clnCodigoBarras";
            clnCodigoBarras.ReadOnly = true;
            clnCodigoBarras.Width = 200;
            // 
            // clnDescricao
            // 
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 200;
            // 
            // clnValorUnit
            // 
            clnValorUnit.HeaderText = "Valor Unitário";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 120;
            // 
            // clnUnidadeVenda
            // 
            clnUnidadeVenda.HeaderText = "Unidade de Venda";
            clnUnidadeVenda.Name = "clnUnidadeVenda";
            clnUnidadeVenda.ReadOnly = true;
            clnUnidadeVenda.Width = 130;
            // 
            // clnCategoria
            // 
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            clnCategoria.Width = 250;
            // 
            // clnEstoqueMinimo
            // 
            clnEstoqueMinimo.HeaderText = "Estoque Minimo";
            clnEstoqueMinimo.Name = "clnEstoqueMinimo";
            clnEstoqueMinimo.ReadOnly = true;
            clnEstoqueMinimo.Width = 130;
            // 
            // clnDesconto
            // 
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            // 
            // clnData
            // 
            clnData.HeaderText = "Data Cadastro";
            clnData.Name = "clnData";
            clnData.ReadOnly = true;
            clnData.Width = 160;
            // 
            // gpProdutos
            // 
            gpProdutos.Controls.Add(cmbCategoria);
            gpProdutos.Controls.Add(npEstoqueMinimo);
            gpProdutos.Controls.Add(btnCosultar);
            gpProdutos.Controls.Add(btnAdicionar);
            gpProdutos.Controls.Add(btnEditar);
            gpProdutos.Controls.Add(label7);
            gpProdutos.Controls.Add(label6);
            gpProdutos.Controls.Add(label8);
            gpProdutos.Controls.Add(label3);
            gpProdutos.Controls.Add(label5);
            gpProdutos.Controls.Add(label4);
            gpProdutos.Controls.Add(label9);
            gpProdutos.Controls.Add(label2);
            gpProdutos.Controls.Add(txtId);
            gpProdutos.Controls.Add(txtCodigosBarras);
            gpProdutos.Controls.Add(txtDescricao);
            gpProdutos.Controls.Add(txtDesconto);
            gpProdutos.Controls.Add(txtValorUnit);
            gpProdutos.Controls.Add(txtUnidadeVenda);
            gpProdutos.Location = new Point(50, 59);
            gpProdutos.Name = "gpProdutos";
            gpProdutos.Size = new Size(748, 306);
            gpProdutos.TabIndex = 5;
            gpProdutos.TabStop = false;
            gpProdutos.Text = "Produtos";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(338, 158);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(384, 23);
            cmbCategoria.TabIndex = 8;
            // 
            // npEstoqueMinimo
            // 
            npEstoqueMinimo.Location = new Point(578, 100);
            npEstoqueMinimo.Name = "npEstoqueMinimo";
            npEstoqueMinimo.Size = new Size(39, 23);
            npEstoqueMinimo.TabIndex = 7;
            // 
            // btnCosultar
            // 
            btnCosultar.Location = new Point(459, 206);
            btnCosultar.Name = "btnCosultar";
            btnCosultar.Size = new Size(75, 23);
            btnCosultar.TabIndex = 5;
            btnCosultar.Text = "&Consultar";
            btnCosultar.UseVisualStyleBackColor = true;
            btnCosultar.Click += btnCosultar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(263, 206);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(364, 206);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(578, 82);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 2;
            label7.Text = "Estoque Mínimo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(338, 136);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 2;
            label6.Text = "Categoria";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(132, 188);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 2;
            label8.Text = "Desconto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 136);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(440, 81);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 2;
            label5.Text = "Unidade de Venda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 81);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 2;
            label4.Text = "Valor Unitário";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(132, 26);
            label9.Name = "label9";
            label9.Size = new Size(18, 15);
            label9.TabIndex = 2;
            label9.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 82);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 2;
            label2.Text = "Código de barras";
            // 
            // txtId
            // 
            txtId.Location = new Point(132, 44);
            txtId.Name = "txtId";
            txtId.Size = new Size(70, 23);
            txtId.TabIndex = 1;
            // 
            // txtCodigosBarras
            // 
            txtCodigosBarras.Location = new Point(132, 99);
            txtCodigosBarras.Name = "txtCodigosBarras";
            txtCodigosBarras.Size = new Size(140, 23);
            txtCodigosBarras.TabIndex = 1;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(132, 154);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(188, 23);
            txtDescricao.TabIndex = 1;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(132, 207);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(117, 23);
            txtDesconto.TabIndex = 1;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(296, 99);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(117, 23);
            txtValorUnit.TabIndex = 1;
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.Location = new Point(440, 99);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.PlaceholderText = "EX: Caixa";
            txtUnidadeVenda.Size = new Size(117, 23);
            txtUnidadeVenda.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(311, 18);
            label1.Name = "label1";
            label1.Size = new Size(179, 38);
            label1.TabIndex = 4;
            label1.Text = "Produtos";
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 581);
            Controls.Add(dgvProdutos);
            Controls.Add(gpProdutos);
            Controls.Add(label1);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            gpProdutos.ResumeLayout(false);
            gpProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)npEstoqueMinimo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProdutos;
        private GroupBox gpProdutos;
        private MaskedTextBox mtbDesconto;
        private MaskedTextBox mtbValorUnit;
        private NumericUpDown npEstoqueMinimo;
        private Button btnCosultar;
        private Button btnAdicionar;
        private Button btnEditar;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox txtCodigosBarras;
        private TextBox txtDescricao;
        private TextBox txtUnidadeVenda;
        private Label label1;
        private TextBox txtValorUnit;
        private TextBox txtDesconto;
        private ComboBox cmbCategoria;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodigoBarras;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnUnidadeVenda;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnEstoqueMinimo;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnData;
        private Label label9;
        private TextBox txtId;
    }
}