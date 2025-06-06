namespace Cantina_2._0
{
    partial class Balcao
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
            btnEntregar = new Button();
            listPedidos = new ListBox();
            listEntregues = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnEntregar
            // 
            btnEntregar.Location = new Point(364, 187);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.Size = new Size(75, 23);
            btnEntregar.TabIndex = 0;
            btnEntregar.Text = "Entregar";
            btnEntregar.UseVisualStyleBackColor = true;
            btnEntregar.Click += btnEntregar_Click;
            // 
            // listPedidos
            // 
            listPedidos.FormattingEnabled = true;
            listPedidos.ItemHeight = 15;
            listPedidos.Location = new Point(107, 42);
            listPedidos.Name = "listPedidos";
            listPedidos.Size = new Size(584, 139);
            listPedidos.TabIndex = 1;
            listPedidos.SelectedIndexChanged += listPedidos_SelectedIndexChanged;
            // 
            // listEntregues
            // 
            listEntregues.FormattingEnabled = true;
            listEntregues.ItemHeight = 15;
            listEntregues.Location = new Point(107, 261);
            listEntregues.Name = "listEntregues";
            listEntregues.Size = new Size(584, 139);
            listEntregues.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(371, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 22);
            label1.TabIndex = 3;
            label1.Text = "Pedidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(333, 225);
            label2.Name = "label2";
            label2.Size = new Size(145, 22);
            label2.TabIndex = 4;
            label2.Text = "Pedidos entregues";
            // 
            // Balcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 255, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listEntregues);
            Controls.Add(listPedidos);
            Controls.Add(btnEntregar);
            Name = "Balcao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Balcão";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntregar;
        private ListBox listPedidos;
        private ListBox listEntregues;
        private Label label1;
        private Label label2;
    }
}