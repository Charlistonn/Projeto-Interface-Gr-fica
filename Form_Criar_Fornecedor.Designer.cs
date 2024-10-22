namespace Proj.Interface
{
    partial class Form_Criar_Fornecedor
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
            textBox_Nome_Fornecedor = new TextBox();
            textBox_Telefone_Fornecedor = new TextBox();
            textBox_Email_Fornecedor = new TextBox();
            textBox_Endereço_Fisico_Fornecedor = new TextBox();
            button_Ok_Criar_Fornecedor = new Button();
            button_Cancelar_Fornecedor = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 72);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 115);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 160);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 203);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 0;
            label4.Text = "Endereço Físico";
            // 
            // textBox_Nome_Fornecedor
            // 
            textBox_Nome_Fornecedor.Location = new Point(154, 72);
            textBox_Nome_Fornecedor.Name = "textBox_Nome_Fornecedor";
            textBox_Nome_Fornecedor.Size = new Size(100, 23);
            textBox_Nome_Fornecedor.TabIndex = 1;
            // 
            // textBox_Telefone_Fornecedor
            // 
            textBox_Telefone_Fornecedor.Location = new Point(154, 112);
            textBox_Telefone_Fornecedor.Name = "textBox_Telefone_Fornecedor";
            textBox_Telefone_Fornecedor.Size = new Size(100, 23);
            textBox_Telefone_Fornecedor.TabIndex = 2;
            // 
            // textBox_Email_Fornecedor
            // 
            textBox_Email_Fornecedor.Location = new Point(154, 157);
            textBox_Email_Fornecedor.Name = "textBox_Email_Fornecedor";
            textBox_Email_Fornecedor.Size = new Size(100, 23);
            textBox_Email_Fornecedor.TabIndex = 3;
            // 
            // textBox_Endereço_Fisico_Fornecedor
            // 
            textBox_Endereço_Fisico_Fornecedor.Location = new Point(154, 200);
            textBox_Endereço_Fisico_Fornecedor.Name = "textBox_Endereço_Fisico_Fornecedor";
            textBox_Endereço_Fisico_Fornecedor.Size = new Size(100, 23);
            textBox_Endereço_Fisico_Fornecedor.TabIndex = 4;
            // 
            // button_Ok_Criar_Fornecedor
            // 
            button_Ok_Criar_Fornecedor.BackColor = Color.Cyan;
            button_Ok_Criar_Fornecedor.FlatStyle = FlatStyle.Popup;
            button_Ok_Criar_Fornecedor.Location = new Point(51, 271);
            button_Ok_Criar_Fornecedor.Name = "button_Ok_Criar_Fornecedor";
            button_Ok_Criar_Fornecedor.Size = new Size(75, 23);
            button_Ok_Criar_Fornecedor.TabIndex = 5;
            button_Ok_Criar_Fornecedor.Text = "Ok";
            button_Ok_Criar_Fornecedor.UseVisualStyleBackColor = false;
            button_Ok_Criar_Fornecedor.Click += button_Ok_Criar_Fornecedor_Click;
            // 
            // button_Cancelar_Fornecedor
            // 
            button_Cancelar_Fornecedor.BackColor = Color.Red;
            button_Cancelar_Fornecedor.FlatStyle = FlatStyle.Popup;
            button_Cancelar_Fornecedor.ForeColor = SystemColors.ButtonHighlight;
            button_Cancelar_Fornecedor.Location = new Point(169, 271);
            button_Cancelar_Fornecedor.Name = "button_Cancelar_Fornecedor";
            button_Cancelar_Fornecedor.Size = new Size(75, 23);
            button_Cancelar_Fornecedor.TabIndex = 6;
            button_Cancelar_Fornecedor.Text = "Cancelar";
            button_Cancelar_Fornecedor.UseVisualStyleBackColor = false;
            button_Cancelar_Fornecedor.Click += button_Cancelar_Fornecedor_Click;
            // 
            // Form_Criar_Fornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(319, 301);
            Controls.Add(button_Cancelar_Fornecedor);
            Controls.Add(button_Ok_Criar_Fornecedor);
            Controls.Add(textBox_Endereço_Fisico_Fornecedor);
            Controls.Add(textBox_Email_Fornecedor);
            Controls.Add(textBox_Telefone_Fornecedor);
            Controls.Add(textBox_Nome_Fornecedor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Criar_Fornecedor";
            Text = "Form_Criar_Fornecedor";
            Load += Form_Criar_Fornecedor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_Nome_Fornecedor;
        private TextBox textBox_Telefone_Fornecedor;
        private TextBox textBox_Email_Fornecedor;
        private TextBox textBox_Endereço_Fisico_Fornecedor;
        private Button button_Ok_Criar_Fornecedor;
        private Button button_Cancelar_Fornecedor;
    }
}