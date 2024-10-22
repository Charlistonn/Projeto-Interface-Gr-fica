namespace Proj.Interface
{
    partial class Form_Criar_Venda
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
            numericUpDown_ID_Produto = new NumericUpDown();
            numericUpDown_ID_Cliente = new NumericUpDown();
            numericUpDown_Quantidade_Vendida = new NumericUpDown();
            numericUpDown_Porcentagem_Desconto = new NumericUpDown();
            Ok_Criar_Venda = new Button();
            Ok_Cancelar_Venda = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_ID_Produto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_ID_Cliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Quantidade_Vendida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Porcentagem_Desconto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 83);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "ID do Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 120);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "ID do Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 156);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 1;
            label3.Text = "Quantidade Vendida";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 200);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 1;
            label4.Text = "Desconto (%)";
            // 
            // numericUpDown_ID_Produto
            // 
            numericUpDown_ID_Produto.Location = new Point(176, 81);
            numericUpDown_ID_Produto.Name = "numericUpDown_ID_Produto";
            numericUpDown_ID_Produto.Size = new Size(120, 23);
            numericUpDown_ID_Produto.TabIndex = 2;
            numericUpDown_ID_Produto.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDown_ID_Cliente
            // 
            numericUpDown_ID_Cliente.Location = new Point(176, 118);
            numericUpDown_ID_Cliente.Name = "numericUpDown_ID_Cliente";
            numericUpDown_ID_Cliente.Size = new Size(120, 23);
            numericUpDown_ID_Cliente.TabIndex = 3;
            numericUpDown_ID_Cliente.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDown_Quantidade_Vendida
            // 
            numericUpDown_Quantidade_Vendida.Location = new Point(177, 154);
            numericUpDown_Quantidade_Vendida.Name = "numericUpDown_Quantidade_Vendida";
            numericUpDown_Quantidade_Vendida.Size = new Size(120, 23);
            numericUpDown_Quantidade_Vendida.TabIndex = 4;
            numericUpDown_Quantidade_Vendida.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDown_Porcentagem_Desconto
            // 
            numericUpDown_Porcentagem_Desconto.DecimalPlaces = 2;
            numericUpDown_Porcentagem_Desconto.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown_Porcentagem_Desconto.Location = new Point(177, 198);
            numericUpDown_Porcentagem_Desconto.Name = "numericUpDown_Porcentagem_Desconto";
            numericUpDown_Porcentagem_Desconto.Size = new Size(120, 23);
            numericUpDown_Porcentagem_Desconto.TabIndex = 5;
            numericUpDown_Porcentagem_Desconto.TextAlign = HorizontalAlignment.Right;
            // 
            // Ok_Criar_Venda
            // 
            Ok_Criar_Venda.BackColor = Color.Cyan;
            Ok_Criar_Venda.FlatStyle = FlatStyle.Popup;
            Ok_Criar_Venda.Location = new Point(72, 265);
            Ok_Criar_Venda.Name = "Ok_Criar_Venda";
            Ok_Criar_Venda.Size = new Size(75, 23);
            Ok_Criar_Venda.TabIndex = 6;
            Ok_Criar_Venda.Text = "Ok";
            Ok_Criar_Venda.UseVisualStyleBackColor = false;
            Ok_Criar_Venda.Click += Ok_Criar_Venda_Click;
            // 
            // Ok_Cancelar_Venda
            // 
            Ok_Cancelar_Venda.BackColor = Color.Red;
            Ok_Cancelar_Venda.FlatStyle = FlatStyle.Popup;
            Ok_Cancelar_Venda.ForeColor = SystemColors.ButtonHighlight;
            Ok_Cancelar_Venda.Location = new Point(177, 265);
            Ok_Cancelar_Venda.Name = "Ok_Cancelar_Venda";
            Ok_Cancelar_Venda.Size = new Size(75, 23);
            Ok_Cancelar_Venda.TabIndex = 7;
            Ok_Cancelar_Venda.Text = "Cancelar ";
            Ok_Cancelar_Venda.UseVisualStyleBackColor = false;
            Ok_Cancelar_Venda.Click += Ok_Cancelar_Venda_Click;
            // 
            // Form_Criar_Venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(333, 293);
            Controls.Add(Ok_Cancelar_Venda);
            Controls.Add(Ok_Criar_Venda);
            Controls.Add(numericUpDown_Porcentagem_Desconto);
            Controls.Add(numericUpDown_Quantidade_Vendida);
            Controls.Add(numericUpDown_ID_Cliente);
            Controls.Add(numericUpDown_ID_Produto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Criar_Venda";
            Text = "Form_Criar_Venda";
            Load += Form_Criar_Venda_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_ID_Produto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_ID_Cliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Quantidade_Vendida).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Porcentagem_Desconto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown_ID_Produto;
        private NumericUpDown numericUpDown_ID_Cliente;
        private NumericUpDown numericUpDown_Quantidade_Vendida;
        private NumericUpDown numericUpDown_Porcentagem_Desconto;
        private Button Ok_Criar_Venda;
        private Button Ok_Cancelar_Venda;
    }
}