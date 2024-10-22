namespace Proj.Interface
{
    partial class Form_Criar_Produto
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDown_Preco_Compra_1 = new NumericUpDown();
            numericUpDown_Preco_Venda2 = new NumericUpDown();
            textBox_Nome_Fornecedor_1 = new TextBox();
            textBox_Nome_Produto2 = new TextBox();
            Ok_Criar_Prod = new Button();
            Cancelar_Criar_Prod = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Preco_Compra_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Preco_Venda2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 132);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do Fornecedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome do Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 165);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 0;
            label3.Text = "Preço da Compra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 193);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 0;
            label4.Text = "Preço da Venda";
            // 
            // numericUpDown_Preco_Compra_1
            // 
            numericUpDown_Preco_Compra_1.DecimalPlaces = 2;
            numericUpDown_Preco_Compra_1.Location = new Point(151, 163);
            numericUpDown_Preco_Compra_1.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown_Preco_Compra_1.Name = "numericUpDown_Preco_Compra_1";
            numericUpDown_Preco_Compra_1.Size = new Size(120, 23);
            numericUpDown_Preco_Compra_1.TabIndex = 1;
            numericUpDown_Preco_Compra_1.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDown_Preco_Venda2
            // 
            numericUpDown_Preco_Venda2.DecimalPlaces = 2;
            numericUpDown_Preco_Venda2.Location = new Point(151, 191);
            numericUpDown_Preco_Venda2.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown_Preco_Venda2.Name = "numericUpDown_Preco_Venda2";
            numericUpDown_Preco_Venda2.Size = new Size(120, 23);
            numericUpDown_Preco_Venda2.TabIndex = 2;
            numericUpDown_Preco_Venda2.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox_Nome_Fornecedor_1
            // 
            textBox_Nome_Fornecedor_1.Location = new Point(151, 129);
            textBox_Nome_Fornecedor_1.Name = "textBox_Nome_Fornecedor_1";
            textBox_Nome_Fornecedor_1.Size = new Size(100, 23);
            textBox_Nome_Fornecedor_1.TabIndex = 3;
            // 
            // textBox_Nome_Produto2
            // 
            textBox_Nome_Produto2.Location = new Point(151, 100);
            textBox_Nome_Produto2.Name = "textBox_Nome_Produto2";
            textBox_Nome_Produto2.Size = new Size(100, 23);
            textBox_Nome_Produto2.TabIndex = 4;
            // 
            // Ok_Criar_Prod
            // 
            Ok_Criar_Prod.BackColor = Color.Cyan;
            Ok_Criar_Prod.FlatStyle = FlatStyle.Popup;
            Ok_Criar_Prod.Location = new Point(57, 252);
            Ok_Criar_Prod.Name = "Ok_Criar_Prod";
            Ok_Criar_Prod.Size = new Size(75, 23);
            Ok_Criar_Prod.TabIndex = 5;
            Ok_Criar_Prod.Text = "Ok";
            Ok_Criar_Prod.UseVisualStyleBackColor = false;
            Ok_Criar_Prod.Click += Ok_Criar_Prod_Click;
            // 
            // Cancelar_Criar_Prod
            // 
            Cancelar_Criar_Prod.BackColor = Color.Red;
            Cancelar_Criar_Prod.FlatStyle = FlatStyle.Popup;
            Cancelar_Criar_Prod.ForeColor = SystemColors.ButtonHighlight;
            Cancelar_Criar_Prod.Location = new Point(159, 252);
            Cancelar_Criar_Prod.Name = "Cancelar_Criar_Prod";
            Cancelar_Criar_Prod.Size = new Size(75, 23);
            Cancelar_Criar_Prod.TabIndex = 6;
            Cancelar_Criar_Prod.Text = "Cancelar";
            Cancelar_Criar_Prod.UseVisualStyleBackColor = false;
            Cancelar_Criar_Prod.Click += Cancelar_Criar_Prod_Click;
            // 
            // Form_Criar_Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(290, 279);
            Controls.Add(Cancelar_Criar_Prod);
            Controls.Add(Ok_Criar_Prod);
            Controls.Add(textBox_Nome_Produto2);
            Controls.Add(textBox_Nome_Fornecedor_1);
            Controls.Add(numericUpDown_Preco_Venda2);
            Controls.Add(numericUpDown_Preco_Compra_1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Criar_Produto";
            Text = "Form_Criar_Produto";
            Load += Form_Criar_Produto_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Preco_Compra_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Preco_Venda2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown_Preco_Compra_1;
        private NumericUpDown numericUpDown_Preco_Venda2;
        private TextBox textBox_Nome_Fornecedor_1;
        private TextBox textBox_Nome_Produto2;
        private Button Ok_Criar_Prod;
        private Button Cancelar_Criar_Prod;
    }
}