namespace ComercialSys
{
    partial class FrmPedido
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            txtNumeroPedido = new TextBox();
            label3 = new Label();
            txtVendedor = new TextBox();
            btnAbrirNovo = new Button();
            gbxProduto = new GroupBox();
            btnInserirItem = new Button();
            lblDescMax = new Label();
            label8 = new Label();
            label7 = new Label();
            txtDescontoItem = new TextBox();
            txtQuantidade = new TextBox();
            txtValorUnit = new TextBox();
            label6 = new Label();
            txtDescricao = new TextBox();
            txtCodBar = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnExcluirItem = new Button();
            dgvItens = new DataGridView();
            clnSeq = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnUnidadeVenda = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnValorItem = new DataGridViewTextBoxColumn();
            clnId = new DataGridViewTextBoxColumn();
            btn = new Button();
            txtDesconto = new TextBox();
            txtOutros = new TextBox();
            txtTotal = new TextBox();
            txtSubTotal = new TextBox();
            label9 = new Label();
            lblIdCodBar = new Label();
            groupBox1.SuspendLayout();
            gbxProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItens).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 20);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Pedido";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(35, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(585, 97);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Cliente";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(148, 36);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(415, 23);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 36);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(738, 23);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Número";
            // 
            // txtNumeroPedido
            // 
            txtNumeroPedido.Font = new Font("Segoe UI", 24F);
            txtNumeroPedido.ForeColor = Color.Red;
            txtNumeroPedido.Location = new Point(795, 20);
            txtNumeroPedido.Name = "txtNumeroPedido";
            txtNumeroPedido.RightToLeft = RightToLeft.Yes;
            txtNumeroPedido.Size = new Size(169, 50);
            txtNumeroPedido.TabIndex = 3;
            txtNumeroPedido.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 61);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Vendedor";
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(99, 58);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.ReadOnly = true;
            txtVendedor.Size = new Size(346, 23);
            txtVendedor.TabIndex = 5;
            // 
            // btnAbrirNovo
            // 
            btnAbrirNovo.Location = new Point(630, 151);
            btnAbrirNovo.Name = "btnAbrirNovo";
            btnAbrirNovo.Size = new Size(145, 44);
            btnAbrirNovo.TabIndex = 6;
            btnAbrirNovo.Text = "&Abrir Pedido";
            btnAbrirNovo.UseVisualStyleBackColor = true;
            btnAbrirNovo.Click += btnAbrirNovo_Click;
            // 
            // gbxProduto
            // 
            gbxProduto.Controls.Add(btnInserirItem);
            gbxProduto.Controls.Add(lblDescMax);
            gbxProduto.Controls.Add(label8);
            gbxProduto.Controls.Add(label7);
            gbxProduto.Controls.Add(txtDescontoItem);
            gbxProduto.Controls.Add(txtQuantidade);
            gbxProduto.Controls.Add(txtValorUnit);
            gbxProduto.Controls.Add(label6);
            gbxProduto.Controls.Add(txtDescricao);
            gbxProduto.Controls.Add(txtCodBar);
            gbxProduto.Controls.Add(label5);
            gbxProduto.Controls.Add(label4);
            gbxProduto.Enabled = false;
            gbxProduto.Location = new Point(36, 201);
            gbxProduto.Name = "gbxProduto";
            gbxProduto.Size = new Size(739, 82);
            gbxProduto.TabIndex = 7;
            gbxProduto.TabStop = false;
            gbxProduto.Text = "Produto";
            // 
            // btnInserirItem
            // 
            btnInserirItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInserirItem.Location = new Point(668, 28);
            btnInserirItem.Name = "btnInserirItem";
            btnInserirItem.Size = new Size(65, 35);
            btnInserirItem.TabIndex = 15;
            btnInserirItem.Text = "Inserir";
            btnInserirItem.UseVisualStyleBackColor = true;
            btnInserirItem.Click += btnInserirItem_Click;
            // 
            // lblDescMax
            // 
            lblDescMax.AutoSize = true;
            lblDescMax.ForeColor = Color.Red;
            lblDescMax.Location = new Point(583, 63);
            lblDescMax.Name = "lblDescMax";
            lblDescMax.Size = new Size(44, 15);
            lblDescMax.TabIndex = 9;
            lblDescMax.Text = "R$ 0,00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(583, 19);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 7;
            label8.Text = "Desconto";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(477, 19);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 7;
            label7.Text = "Quantidade";
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.Location = new Point(583, 37);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.Size = new Size(69, 23);
            txtDescontoItem.TabIndex = 6;
            txtDescontoItem.Text = "0";
            txtDescontoItem.TextAlign = HorizontalAlignment.Right;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(477, 37);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 6;
            txtQuantidade.Text = "1";
            txtQuantidade.TextAlign = HorizontalAlignment.Right;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(371, 37);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(100, 23);
            txtValorUnit.TabIndex = 5;
            txtValorUnit.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(366, 19);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 4;
            label6.Text = "Valor Unitário";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(121, 37);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(244, 23);
            txtDescricao.TabIndex = 3;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(6, 37);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(100, 23);
            txtCodBar.TabIndex = 2;
            txtCodBar.TextChanged += txtCodBar_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 19);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 1;
            label5.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 0;
            label4.Text = "Código de Barras";
            // 
            // btnExcluirItem
            // 
            btnExcluirItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluirItem.Location = new Point(665, 558);
            btnExcluirItem.Name = "btnExcluirItem";
            btnExcluirItem.Size = new Size(110, 35);
            btnExcluirItem.TabIndex = 8;
            btnExcluirItem.Text = "Excluir Item";
            btnExcluirItem.UseVisualStyleBackColor = true;
            btnExcluirItem.Click += btnExcluirItem_Click;
            // 
            // dgvItens
            // 
            dgvItens.AllowUserToAddRows = false;
            dgvItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItens.Columns.AddRange(new DataGridViewColumn[] { clnSeq, clnCodBar, clnDescricao, clnUnidadeVenda, clnValorUnit, clnQuantidade, clnDesconto, clnValorItem, clnId });
            dgvItens.Location = new Point(36, 307);
            dgvItens.Name = "dgvItens";
            dgvItens.ReadOnly = true;
            dgvItens.RowHeadersVisible = false;
            dgvItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItens.Size = new Size(740, 245);
            dgvItens.TabIndex = 8;
            dgvItens.CellContentClick += dataGridView1_CellContentClick;
            dgvItens.RowsRemoved += dgvItens_RowsRemoved;
            // 
            // clnSeq
            // 
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "Seq";
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 40;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "CodBar";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 200;
            // 
            // clnUnidadeVenda
            // 
            clnUnidadeVenda.Frozen = true;
            clnUnidadeVenda.HeaderText = "Unidade";
            clnUnidadeVenda.Name = "clnUnidadeVenda";
            clnUnidadeVenda.ReadOnly = true;
            clnUnidadeVenda.Width = 60;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 90;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quantidade";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 80;
            // 
            // clnDesconto
            // 
            clnDesconto.Frozen = true;
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            clnDesconto.Width = 70;
            // 
            // clnValorItem
            // 
            clnValorItem.Frozen = true;
            clnValorItem.HeaderText = "Valor Item";
            clnValorItem.Name = "clnValorItem";
            clnValorItem.ReadOnly = true;
            // 
            // clnId
            // 
            clnId.HeaderText = "Id";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Visible = false;
            // 
            // btn
            // 
            btn.Font = new Font("Segoe UI", 14F);
            btn.Location = new Point(795, 511);
            btn.Name = "btn";
            btn.Size = new Size(169, 41);
            btn.TabIndex = 9;
            btn.Text = "Finalizar Pedido";
            btn.UseVisualStyleBackColor = true;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(845, 390);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(119, 23);
            txtDesconto.TabIndex = 10;
            // 
            // txtOutros
            // 
            txtOutros.Location = new Point(846, 419);
            txtOutros.Name = "txtOutros";
            txtOutros.Size = new Size(118, 23);
            txtOutros.TabIndex = 11;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(797, 466);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(167, 39);
            txtTotal.TabIndex = 12;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubTotal.Location = new Point(797, 330);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(167, 39);
            txtSubTotal.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(797, 307);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 14;
            label9.Text = "SubTotal";
            // 
            // lblIdCodBar
            // 
            lblIdCodBar.Location = new Point(496, 23);
            lblIdCodBar.Name = "lblIdCodBar";
            lblIdCodBar.Size = new Size(51, 15);
            lblIdCodBar.TabIndex = 2;
            lblIdCodBar.Text = "Número";
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 619);
            Controls.Add(label9);
            Controls.Add(btnExcluirItem);
            Controls.Add(txtSubTotal);
            Controls.Add(txtTotal);
            Controls.Add(txtOutros);
            Controls.Add(txtDesconto);
            Controls.Add(btn);
            Controls.Add(dgvItens);
            Controls.Add(gbxProduto);
            Controls.Add(btnAbrirNovo);
            Controls.Add(txtVendedor);
            Controls.Add(label3);
            Controls.Add(txtNumeroPedido);
            Controls.Add(lblIdCodBar);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmPedido";
            Text = "FrmPedido";
            Load += FrmPedido_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbxProduto.ResumeLayout(false);
            gbxProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtNumeroPedido;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private TextBox txtVendedor;
        private Button btnAbrirNovo;
        private GroupBox gbxProduto;
        private DataGridView dgvItens;
        private Button btn;
        private TextBox txtDesconto;
        private TextBox txtOutros;
        private TextBox txtTotal;
        private TextBox txtValorUnit;
        private Label label6;
        private TextBox txtDescricao;
        private TextBox txtCodBar;
        private Label label5;
        private Label label4;
        private Button btnExcluirItem;
        private Label label7;
        private TextBox txtQuantidade;
        private TextBox txtSubTotal;
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnUnidadeVenda;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnValorItem;
        private Label label8;
        private TextBox txtDescontoItem;
        private Label label9;
        private Label lblDescMax;
        private Button btnInserirItem;
        private DataGridViewTextBoxColumn clnId;
        private Label lblIdCodBar;
    }
}