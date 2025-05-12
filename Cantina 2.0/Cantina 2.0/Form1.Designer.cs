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
            txtCantina = new Label();
            pictureBox1 = new PictureBox();
            txtProdutos = new Label();
            txtCarrinho = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            btnAdicionar = new Button();
            btnRemover = new Button();
            lblTotal = new Label();
            btnFinalizar = new Button();
            numericUpDown1 = new NumericUpDown();
            numericQuantidade = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // txtCantina
            // 
            txtCantina.AutoSize = true;
            txtCantina.BackColor = Color.FromArgb(255, 255, 192);
            txtCantina.Font = new Font("Broadway", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantina.Location = new Point(354, 25);
            txtCantina.Name = "txtCantina";
            txtCantina.Size = new Size(92, 21);
            txtCantina.TabIndex = 0;
            txtCantina.Text = "Cantina";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2025_05_12_104225;
            pictureBox1.Location = new Point(-295, -167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1270, 807);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtProdutos
            // 
            txtProdutos.AutoSize = true;
            txtProdutos.BackColor = Color.FromArgb(255, 255, 192);
            txtProdutos.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProdutos.Location = new Point(116, 65);
            txtProdutos.Name = "txtProdutos";
            txtProdutos.Size = new Size(65, 14);
            txtProdutos.TabIndex = 2;
            txtProdutos.Text = "Produtos";
            // 
            // txtCarrinho
            // 
            txtCarrinho.AutoSize = true;
            txtCarrinho.BackColor = Color.FromArgb(255, 255, 192);
            txtCarrinho.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarrinho.Location = new Point(618, 65);
            txtCarrinho.Name = "txtCarrinho";
            txtCarrinho.Size = new Size(64, 14);
            txtCarrinho.TabIndex = 3;
            txtCarrinho.Text = "Carrinho";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(26, 100);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(251, 169);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(508, 100);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(270, 169);
            listBox2.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(354, 114);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(354, 184);
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
            lblTotal.BackColor = Color.FromArgb(255, 255, 192);
            lblTotal.Font = new Font("Broadway", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(565, 289);
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(157, 310);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 10;
            // 
            // numericQuantidade
            // 
            numericQuantidade.AutoSize = true;
            numericQuantidade.BackColor = Color.FromArgb(255, 255, 192);
            numericQuantidade.Font = new Font("Broadway", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericQuantidade.Location = new Point(26, 310);
            numericQuantidade.Name = "numericQuantidade";
            numericQuantidade.Size = new Size(120, 19);
            numericQuantidade.TabIndex = 11;
            numericQuantidade.Text = "Quantidade:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(numericQuantidade);
            Controls.Add(numericUpDown1);
            Controls.Add(btnFinalizar);
            Controls.Add(lblTotal);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(txtCarrinho);
            Controls.Add(txtProdutos);
            Controls.Add(txtCantina);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtCantina;
        private PictureBox pictureBox1;
        private Label txtProdutos;
        private Label txtCarrinho;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnAdicionar;
        private Button btnRemover;
        private Label lblTotal;
        private Button btnFinalizar;
        private NumericUpDown numericUpDown1;
        private Label numericQuantidade;
    }
}
