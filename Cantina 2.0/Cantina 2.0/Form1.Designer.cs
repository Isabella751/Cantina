namespace Cantina_2._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtProdutos = new Label();
            txtCarrinho = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            btnAdicionar = new Button();
            btnRemover = new Button();
            lblTotal = new Label();
            btnFinalizar = new Button();
            btnQuantidade = new NumericUpDown();
            numericQuantidade = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            comboBox = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtProdutos
            // 
            txtProdutos.AutoSize = true;
            txtProdutos.BackColor = Color.FromArgb(213, 251, 62);
            txtProdutos.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProdutos.Location = new Point(110, 107);
            txtProdutos.Name = "txtProdutos";
            txtProdutos.Size = new Size(65, 14);
            txtProdutos.TabIndex = 2;
            txtProdutos.Text = "Produtos";
            // 
            // txtCarrinho
            // 
            txtCarrinho.AutoSize = true;
            txtCarrinho.BackColor = Color.FromArgb(213, 251, 62);
            txtCarrinho.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarrinho.Location = new Point(606, 107);
            txtCarrinho.Name = "txtCarrinho";
            txtCarrinho.Size = new Size(64, 14);
            txtCarrinho.TabIndex = 3;
            txtCarrinho.Text = "Carrinho";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(21, 142);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(251, 169);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(502, 142);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(270, 169);
            listBox2.TabIndex = 5;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(354, 190);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(354, 246);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 7;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.FromArgb(213, 251, 62);
            lblTotal.Font = new Font("Broadway", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(563, 322);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(107, 22);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total: R$";
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(342, 365);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(104, 22);
            btnFinalizar.TabIndex = 9;
            btnFinalizar.Text = "Finalizar pedido";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnQuantidade
            // 
            btnQuantidade.Location = new Point(152, 326);
            btnQuantidade.Name = "btnQuantidade";
            btnQuantidade.Size = new Size(120, 23);
            btnQuantidade.TabIndex = 10;
            // 
            // numericQuantidade
            // 
            numericQuantidade.AutoSize = true;
            numericQuantidade.BackColor = Color.FromArgb(213, 251, 62);
            numericQuantidade.Font = new Font("Broadway", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericQuantidade.Location = new Point(26, 330);
            numericQuantidade.Name = "numericQuantidade";
            numericQuantidade.Size = new Size(120, 19);
            numericQuantidade.TabIndex = 11;
            numericQuantidade.Text = "Quantidade:";
            numericQuantidade.Click += numericQuantidade_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bolt_logo;
            pictureBox1.Location = new Point(277, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.raio;
            pictureBox2.Location = new Point(-9, -7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(281, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.raio_invertido;
            pictureBox3.Location = new Point(530, 365);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(281, 97);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "Crédito", "Débito", "Dinheiro" });
            comboBox.Location = new Point(152, 366);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(121, 23);
            comboBox.TabIndex = 15;
            comboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 365);
            label1.Name = "label1";
            label1.Size = new Size(115, 19);
            label1.TabIndex = 16;
            label1.Text = "Pagamento:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(213, 251, 62);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(comboBox);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(numericQuantidade);
            Controls.Add(btnQuantidade);
            Controls.Add(btnFinalizar);
            Controls.Add(lblTotal);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(txtCarrinho);
            Controls.Add(txtProdutos);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)btnQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label txtProdutos;
        private Label txtCarrinho;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnAdicionar;
        private Button btnRemover;
        private Label lblTotal;
        private Button btnFinalizar;
        private NumericUpDown btnQuantidade;
        private Label numericQuantidade;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private ComboBox comboBox;
        private Label label1;
    }
}
