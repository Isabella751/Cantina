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
            listPedidosBal = new ListBox();
            listEntreguesBal = new ListBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // listPedidosBal
            // 
            listPedidosBal.FormattingEnabled = true;
            listPedidosBal.ItemHeight = 15;
            listPedidosBal.Location = new Point(33, 59);
            listPedidosBal.Name = "listPedidosBal";
            listPedidosBal.Size = new Size(599, 169);
            listPedidosBal.TabIndex = 0;
            listPedidosBal.SelectedIndexChanged += listPedidosBal_SelectedIndexChanged;
            // 
            // listEntreguesBal
            // 
            listEntreguesBal.FormattingEnabled = true;
            listEntreguesBal.ItemHeight = 15;
            listEntreguesBal.Location = new Point(33, 274);
            listEntreguesBal.Name = "listEntreguesBal";
            listEntreguesBal.Size = new Size(599, 154);
            listEntreguesBal.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 23);
            label1.Name = "label1";
            label1.Size = new Size(68, 22);
            label1.TabIndex = 2;
            label1.Text = "Pedidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 240);
            label2.Name = "label2";
            label2.Size = new Size(145, 22);
            label2.TabIndex = 3;
            label2.Text = "Pedidos entregues";
            // 
            // button1
            // 
            button1.Location = new Point(680, 134);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Entregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Balcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 255, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listEntreguesBal);
            Controls.Add(listPedidosBal);
            Name = "Balcao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Balcão";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listPedidosBal;
        private ListBox listEntreguesBal;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}