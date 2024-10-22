namespace Proj.Interface
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
            Adicionar_Produto_1 = new Button();
            dataGridView1 = new DataGridView();
            Remover_Produto_2 = new Button();
            button_Produto_Figura3 = new Button();
            button_Cliente_Figura = new Button();
            Adicionar_Cliente = new Button();
            Remover_Cliente = new Button();
            Button_Figura_Venda = new Button();
            Adicionar_Venda = new Button();
            Remover_Venda = new Button();
            button_Figura_Compra = new Button();
            button_Adicionar_Compra = new Button();
            button_Remover_Compra = new Button();
            button_Figura_Fornecedor = new Button();
            button_Adicionar_Fornecedor = new Button();
            button_Remover_Fornecedor = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Adicionar_Produto_1
            // 
            Adicionar_Produto_1.BackColor = Color.Cyan;
            Adicionar_Produto_1.FlatStyle = FlatStyle.Popup;
            Adicionar_Produto_1.ForeColor = SystemColors.ActiveCaptionText;
            Adicionar_Produto_1.Location = new Point(12, 48);
            Adicionar_Produto_1.Name = "Adicionar_Produto_1";
            Adicionar_Produto_1.Size = new Size(126, 23);
            Adicionar_Produto_1.TabIndex = 0;
            Adicionar_Produto_1.Text = "Adicionar Produto";
            Adicionar_Produto_1.UseVisualStyleBackColor = false;
            Adicionar_Produto_1.Click += Adicionar_Produto_1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(719, 303);
            dataGridView1.TabIndex = 1;
            // 
            // Remover_Produto_2
            // 
            Remover_Produto_2.BackColor = Color.Red;
            Remover_Produto_2.FlatStyle = FlatStyle.Popup;
            Remover_Produto_2.Location = new Point(12, 82);
            Remover_Produto_2.Name = "Remover_Produto_2";
            Remover_Produto_2.Size = new Size(126, 23);
            Remover_Produto_2.TabIndex = 2;
            Remover_Produto_2.Text = "Remover Produto";
            Remover_Produto_2.UseVisualStyleBackColor = false;
            Remover_Produto_2.Click += Remover_Produto_2_Click;
            // 
            // button_Produto_Figura3
            // 
            button_Produto_Figura3.ForeColor = SystemColors.ButtonHighlight;
            button_Produto_Figura3.Image = Properties.Resources.produto;
            button_Produto_Figura3.Location = new Point(43, 5);
            button_Produto_Figura3.Name = "button_Produto_Figura3";
            button_Produto_Figura3.Size = new Size(68, 38);
            button_Produto_Figura3.TabIndex = 3;
            button_Produto_Figura3.UseVisualStyleBackColor = true;
            button_Produto_Figura3.Click += button_Produto_Figura3_Click;
            // 
            // button_Cliente_Figura
            // 
            button_Cliente_Figura.Image = Properties.Resources.cliente;
            button_Cliente_Figura.Location = new Point(188, 7);
            button_Cliente_Figura.Name = "button_Cliente_Figura";
            button_Cliente_Figura.Size = new Size(70, 38);
            button_Cliente_Figura.TabIndex = 4;
            button_Cliente_Figura.UseVisualStyleBackColor = true;
            button_Cliente_Figura.Click += button_Cliente_Figura_Click;
            // 
            // Adicionar_Cliente
            // 
            Adicionar_Cliente.BackColor = Color.Cyan;
            Adicionar_Cliente.FlatStyle = FlatStyle.Popup;
            Adicionar_Cliente.Location = new Point(163, 51);
            Adicionar_Cliente.Name = "Adicionar_Cliente";
            Adicionar_Cliente.Size = new Size(122, 23);
            Adicionar_Cliente.TabIndex = 5;
            Adicionar_Cliente.Text = "Adicionar Cliente";
            Adicionar_Cliente.UseVisualStyleBackColor = false;
            Adicionar_Cliente.Click += Adicionar_Cliente_Click;
            // 
            // Remover_Cliente
            // 
            Remover_Cliente.BackColor = Color.Red;
            Remover_Cliente.FlatStyle = FlatStyle.Popup;
            Remover_Cliente.Location = new Point(163, 83);
            Remover_Cliente.Name = "Remover_Cliente";
            Remover_Cliente.Size = new Size(122, 23);
            Remover_Cliente.TabIndex = 6;
            Remover_Cliente.Text = "Remover Cliente";
            Remover_Cliente.UseVisualStyleBackColor = false;
            Remover_Cliente.Click += Remover_Cliente_Click;
            // 
            // Button_Figura_Venda
            // 
            Button_Figura_Venda.Image = Properties.Resources.venda;
            Button_Figura_Venda.Location = new Point(337, 7);
            Button_Figura_Venda.Name = "Button_Figura_Venda";
            Button_Figura_Venda.Size = new Size(66, 38);
            Button_Figura_Venda.TabIndex = 7;
            Button_Figura_Venda.UseVisualStyleBackColor = true;
            Button_Figura_Venda.Click += Button_Figura_Venda_Click;
            // 
            // Adicionar_Venda
            // 
            Adicionar_Venda.BackColor = Color.Cyan;
            Adicionar_Venda.FlatStyle = FlatStyle.Popup;
            Adicionar_Venda.Location = new Point(310, 51);
            Adicionar_Venda.Name = "Adicionar_Venda";
            Adicionar_Venda.Size = new Size(122, 23);
            Adicionar_Venda.TabIndex = 8;
            Adicionar_Venda.Text = "Adicionar Venda ";
            Adicionar_Venda.UseVisualStyleBackColor = false;
            Adicionar_Venda.Click += Adicionar_Venda_Click;
            // 
            // Remover_Venda
            // 
            Remover_Venda.BackColor = Color.Red;
            Remover_Venda.FlatStyle = FlatStyle.Popup;
            Remover_Venda.Location = new Point(310, 83);
            Remover_Venda.Name = "Remover_Venda";
            Remover_Venda.Size = new Size(122, 23);
            Remover_Venda.TabIndex = 9;
            Remover_Venda.Text = "Remover Venda ";
            Remover_Venda.UseVisualStyleBackColor = false;
            Remover_Venda.Click += Remover_Venda_Click;
            // 
            // button_Figura_Compra
            // 
            button_Figura_Compra.Image = Properties.Resources.compra;
            button_Figura_Compra.Location = new Point(478, 7);
            button_Figura_Compra.Name = "button_Figura_Compra";
            button_Figura_Compra.Size = new Size(67, 38);
            button_Figura_Compra.TabIndex = 10;
            button_Figura_Compra.UseVisualStyleBackColor = true;
            button_Figura_Compra.Click += button_Figura_Compra_Click;
            // 
            // button_Adicionar_Compra
            // 
            button_Adicionar_Compra.BackColor = Color.Cyan;
            button_Adicionar_Compra.FlatStyle = FlatStyle.Popup;
            button_Adicionar_Compra.Location = new Point(456, 51);
            button_Adicionar_Compra.Name = "button_Adicionar_Compra";
            button_Adicionar_Compra.Size = new Size(116, 23);
            button_Adicionar_Compra.TabIndex = 11;
            button_Adicionar_Compra.Text = "Adicionar Compra ";
            button_Adicionar_Compra.UseVisualStyleBackColor = false;
            button_Adicionar_Compra.Click += button_Adicionar_Compra_Click;
            // 
            // button_Remover_Compra
            // 
            button_Remover_Compra.BackColor = Color.Red;
            button_Remover_Compra.FlatStyle = FlatStyle.Popup;
            button_Remover_Compra.Location = new Point(456, 82);
            button_Remover_Compra.Name = "button_Remover_Compra";
            button_Remover_Compra.Size = new Size(116, 23);
            button_Remover_Compra.TabIndex = 12;
            button_Remover_Compra.Text = "Remover Compra ";
            button_Remover_Compra.UseVisualStyleBackColor = false;
            button_Remover_Compra.Click += button_Remover_Compra_Click;
            // 
            // button_Figura_Fornecedor
            // 
            button_Figura_Fornecedor.Image = Properties.Resources.fornecedor;
            button_Figura_Fornecedor.Location = new Point(626, 8);
            button_Figura_Fornecedor.Name = "button_Figura_Fornecedor";
            button_Figura_Fornecedor.Size = new Size(70, 37);
            button_Figura_Fornecedor.TabIndex = 13;
            button_Figura_Fornecedor.UseVisualStyleBackColor = true;
            button_Figura_Fornecedor.Click += button_Figura_Fornecedor_Click;
            // 
            // button_Adicionar_Fornecedor
            // 
            button_Adicionar_Fornecedor.BackColor = Color.Cyan;
            button_Adicionar_Fornecedor.FlatStyle = FlatStyle.Popup;
            button_Adicionar_Fornecedor.Location = new Point(597, 51);
            button_Adicionar_Fornecedor.Name = "button_Adicionar_Fornecedor";
            button_Adicionar_Fornecedor.Size = new Size(134, 23);
            button_Adicionar_Fornecedor.TabIndex = 14;
            button_Adicionar_Fornecedor.Text = "Adicionar Fornecedor";
            button_Adicionar_Fornecedor.UseVisualStyleBackColor = false;
            button_Adicionar_Fornecedor.Click += button_Adicionar_Fornecedor_Click;
            // 
            // button_Remover_Fornecedor
            // 
            button_Remover_Fornecedor.BackColor = Color.Red;
            button_Remover_Fornecedor.FlatStyle = FlatStyle.Popup;
            button_Remover_Fornecedor.Location = new Point(597, 82);
            button_Remover_Fornecedor.Name = "button_Remover_Fornecedor";
            button_Remover_Fornecedor.Size = new Size(134, 23);
            button_Remover_Fornecedor.TabIndex = 15;
            button_Remover_Fornecedor.Text = "Remover Fornecedor";
            button_Remover_Fornecedor.UseVisualStyleBackColor = false;
            button_Remover_Fornecedor.Click += button_Remover_Fornecedor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(742, 425);
            Controls.Add(button_Remover_Fornecedor);
            Controls.Add(button_Adicionar_Fornecedor);
            Controls.Add(button_Figura_Fornecedor);
            Controls.Add(button_Remover_Compra);
            Controls.Add(button_Adicionar_Compra);
            Controls.Add(button_Figura_Compra);
            Controls.Add(Remover_Venda);
            Controls.Add(Adicionar_Venda);
            Controls.Add(Button_Figura_Venda);
            Controls.Add(Remover_Cliente);
            Controls.Add(Adicionar_Cliente);
            Controls.Add(button_Cliente_Figura);
            Controls.Add(button_Produto_Figura3);
            Controls.Add(Remover_Produto_2);
            Controls.Add(dataGridView1);
            Controls.Add(Adicionar_Produto_1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Adicionar_Produto_1;
        private DataGridView dataGridView1;
        private Button Remover_Produto_2;
        private Button button_Produto_Figura3;
        private Button button_Cliente_Figura;
        private Button Adicionar_Cliente;
        private Button Remover_Cliente;
        private Button Button_Figura_Venda;
        private Button Adicionar_Venda;
        private Button Remover_Venda;
        private Button button_Figura_Compra;
        private Button button_Adicionar_Compra;
        private Button button_Remover_Compra;
        private Button button_Figura_Fornecedor;
        private Button button_Adicionar_Fornecedor;
        private Button button_Remover_Fornecedor;
    }
}
