namespace Proj.Interface
{
    partial class Form_Criar_Compra
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
            numericUpDown_Quantidade_Comprada = new NumericUpDown();
            numericUpDown_Porcentagem_Desconto = new NumericUpDown();
            button_OK_Criar_Compra = new Button();
            button_Cancelar_Compra = new Button();
            comboBox_Produto_Criar_Compra = new ComboBox();
            comboBox_Forncedor_Criar_Compra = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox_Preco_Unitario_Compra = new TextBox();
            textBox_Valor_Total_Compra = new TextBox();
            textBox_Total_Desconto_Compra = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Quantidade_Comprada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Porcentagem_Desconto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 47);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "ID do Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 76);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "ID do Fornecedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 104);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 0;
            label3.Text = "Quantidade Comprada";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 133);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 0;
            label4.Text = "Desconto";
            // 
            // numericUpDown_Quantidade_Comprada
            // 
            numericUpDown_Quantidade_Comprada.Location = new Point(182, 102);
            numericUpDown_Quantidade_Comprada.Name = "numericUpDown_Quantidade_Comprada";
            numericUpDown_Quantidade_Comprada.Size = new Size(120, 23);
            numericUpDown_Quantidade_Comprada.TabIndex = 3;
            numericUpDown_Quantidade_Comprada.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDown_Porcentagem_Desconto
            // 
            numericUpDown_Porcentagem_Desconto.DecimalPlaces = 2;
            numericUpDown_Porcentagem_Desconto.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown_Porcentagem_Desconto.Location = new Point(181, 131);
            numericUpDown_Porcentagem_Desconto.Name = "numericUpDown_Porcentagem_Desconto";
            numericUpDown_Porcentagem_Desconto.Size = new Size(120, 23);
            numericUpDown_Porcentagem_Desconto.TabIndex = 4;
            numericUpDown_Porcentagem_Desconto.TextAlign = HorizontalAlignment.Right;
            // 
            // button_OK_Criar_Compra
            // 
            button_OK_Criar_Compra.BackColor = Color.Cyan;
            button_OK_Criar_Compra.FlatStyle = FlatStyle.Popup;
            button_OK_Criar_Compra.Location = new Point(64, 253);
            button_OK_Criar_Compra.Name = "button_OK_Criar_Compra";
            button_OK_Criar_Compra.Size = new Size(75, 23);
            button_OK_Criar_Compra.TabIndex = 5;
            button_OK_Criar_Compra.Text = "Ok";
            button_OK_Criar_Compra.UseVisualStyleBackColor = false;
            button_OK_Criar_Compra.Click += button_OK_Criar_Compra_Click;
            // 
            // button_Cancelar_Compra
            // 
            button_Cancelar_Compra.BackColor = Color.Red;
            button_Cancelar_Compra.FlatStyle = FlatStyle.Popup;
            button_Cancelar_Compra.ForeColor = SystemColors.ButtonHighlight;
            button_Cancelar_Compra.Location = new Point(166, 253);
            button_Cancelar_Compra.Name = "button_Cancelar_Compra";
            button_Cancelar_Compra.Size = new Size(75, 23);
            button_Cancelar_Compra.TabIndex = 6;
            button_Cancelar_Compra.Text = "Cancelar";
            button_Cancelar_Compra.UseVisualStyleBackColor = false;
            button_Cancelar_Compra.Click += button_Cancelar_Compra_Click;
            // 
            // comboBox_Produto_Criar_Compra
            // 
            comboBox_Produto_Criar_Compra.FormattingEnabled = true;
            comboBox_Produto_Criar_Compra.Location = new Point(181, 44);
            comboBox_Produto_Criar_Compra.Name = "comboBox_Produto_Criar_Compra";
            comboBox_Produto_Criar_Compra.Size = new Size(121, 23);
            comboBox_Produto_Criar_Compra.TabIndex = 7;
            comboBox_Produto_Criar_Compra.SelectedIndexChanged += comboBox_ID_Produto_Criar_Compra_SelectedIndexChanged;
            // 
            // comboBox_Forncedor_Criar_Compra
            // 
            comboBox_Forncedor_Criar_Compra.FormattingEnabled = true;
            comboBox_Forncedor_Criar_Compra.Location = new Point(181, 73);
            comboBox_Forncedor_Criar_Compra.Name = "comboBox_Forncedor_Criar_Compra";
            comboBox_Forncedor_Criar_Compra.Size = new Size(121, 23);
            comboBox_Forncedor_Criar_Compra.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 161);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 161);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 10;
            label6.Text = "Preço Unitário: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 214);
            label7.Name = "label7";
            label7.Size = new Size(120, 15);
            label7.TabIndex = 11;
            label7.Text = "Total Com Desconto: ";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(75, 187);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 11;
            label8.Text = "Valor Total:";
            // 
            // textBox_Preco_Unitario_Compra
            // 
            textBox_Preco_Unitario_Compra.Location = new Point(182, 158);
            textBox_Preco_Unitario_Compra.Name = "textBox_Preco_Unitario_Compra";
            textBox_Preco_Unitario_Compra.ReadOnly = true;
            textBox_Preco_Unitario_Compra.Size = new Size(100, 23);
            textBox_Preco_Unitario_Compra.TabIndex = 12;
            // 
            // textBox_Valor_Total_Compra
            // 
            textBox_Valor_Total_Compra.Location = new Point(181, 184);
            textBox_Valor_Total_Compra.Name = "textBox_Valor_Total_Compra";
            textBox_Valor_Total_Compra.ReadOnly = true;
            textBox_Valor_Total_Compra.Size = new Size(100, 23);
            textBox_Valor_Total_Compra.TabIndex = 13;
            // 
            // textBox_Total_Desconto_Compra
            // 
            textBox_Total_Desconto_Compra.Location = new Point(181, 211);
            textBox_Total_Desconto_Compra.Name = "textBox_Total_Desconto_Compra";
            textBox_Total_Desconto_Compra.ReadOnly = true;
            textBox_Total_Desconto_Compra.Size = new Size(100, 23);
            textBox_Total_Desconto_Compra.TabIndex = 14;
            // 
            // Form_Criar_Compra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(314, 280);
            Controls.Add(textBox_Total_Desconto_Compra);
            Controls.Add(textBox_Valor_Total_Compra);
            Controls.Add(textBox_Preco_Unitario_Compra);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox_Forncedor_Criar_Compra);
            Controls.Add(comboBox_Produto_Criar_Compra);
            Controls.Add(button_Cancelar_Compra);
            Controls.Add(button_OK_Criar_Compra);
            Controls.Add(numericUpDown_Porcentagem_Desconto);
            Controls.Add(numericUpDown_Quantidade_Comprada);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Criar_Compra";
            Text = "Form_Criar_Compra";
            Load += Form_Criar_Compra_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Quantidade_Comprada).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Porcentagem_Desconto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown_Quantidade_Comprada;
        private NumericUpDown numericUpDown_Porcentagem_Desconto;
        private Button button_OK_Criar_Compra;
        private Button button_Cancelar_Compra;
        private ComboBox comboBox_Produto_Criar_Compra;
        private ComboBox comboBox_Forncedor_Criar_Compra;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox_Preco_Unitario_Compra;
        private TextBox textBox_Valor_Total_Compra;
        private TextBox textBox_Total_Desconto_Compra;
    }
}