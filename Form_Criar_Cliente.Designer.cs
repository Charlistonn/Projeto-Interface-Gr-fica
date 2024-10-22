namespace Proj.Interface
{
    partial class Form_Criar_Cliente
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
            textBox_Nome_Cliente = new TextBox();
            textBox_Numero_Telefone = new TextBox();
            textBox_Email_Cliente = new TextBox();
            textBox_Endereco_Fisico = new TextBox();
            Ok_Criar_Cliente = new Button();
            Cancelar_Criar_Cliente = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 81);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 119);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 160);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 207);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 0;
            label4.Text = "Endereço Físico";
            // 
            // textBox_Nome_Cliente
            // 
            textBox_Nome_Cliente.Location = new Point(136, 81);
            textBox_Nome_Cliente.Name = "textBox_Nome_Cliente";
            textBox_Nome_Cliente.Size = new Size(100, 23);
            textBox_Nome_Cliente.TabIndex = 1;
            // 
            // textBox_Numero_Telefone
            // 
            textBox_Numero_Telefone.Location = new Point(140, 118);
            textBox_Numero_Telefone.Name = "textBox_Numero_Telefone";
            textBox_Numero_Telefone.Size = new Size(100, 23);
            textBox_Numero_Telefone.TabIndex = 2;
            // 
            // textBox_Email_Cliente
            // 
            textBox_Email_Cliente.Location = new Point(139, 160);
            textBox_Email_Cliente.Name = "textBox_Email_Cliente";
            textBox_Email_Cliente.Size = new Size(100, 23);
            textBox_Email_Cliente.TabIndex = 3;
            // 
            // textBox_Endereco_Fisico
            // 
            textBox_Endereco_Fisico.Location = new Point(159, 205);
            textBox_Endereco_Fisico.Name = "textBox_Endereco_Fisico";
            textBox_Endereco_Fisico.Size = new Size(100, 23);
            textBox_Endereco_Fisico.TabIndex = 4;
            // 
            // Ok_Criar_Cliente
            // 
            Ok_Criar_Cliente.BackColor = Color.Cyan;
            Ok_Criar_Cliente.FlatStyle = FlatStyle.Popup;
            Ok_Criar_Cliente.Location = new Point(49, 270);
            Ok_Criar_Cliente.Name = "Ok_Criar_Cliente";
            Ok_Criar_Cliente.Size = new Size(75, 23);
            Ok_Criar_Cliente.TabIndex = 5;
            Ok_Criar_Cliente.Text = "Ok";
            Ok_Criar_Cliente.UseVisualStyleBackColor = false;
            Ok_Criar_Cliente.Click += Ok_Criar_Cliente_Click;
            // 
            // Cancelar_Criar_Cliente
            // 
            Cancelar_Criar_Cliente.BackColor = Color.Red;
            Cancelar_Criar_Cliente.FlatStyle = FlatStyle.Popup;
            Cancelar_Criar_Cliente.ForeColor = SystemColors.ButtonHighlight;
            Cancelar_Criar_Cliente.Location = new Point(165, 270);
            Cancelar_Criar_Cliente.Name = "Cancelar_Criar_Cliente";
            Cancelar_Criar_Cliente.Size = new Size(75, 23);
            Cancelar_Criar_Cliente.TabIndex = 6;
            Cancelar_Criar_Cliente.Text = "Cancelar";
            Cancelar_Criar_Cliente.UseVisualStyleBackColor = false;
            Cancelar_Criar_Cliente.Click += Cancelar_Criar_Cliente_Click;
            // 
            // Form_Criar_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(304, 298);
            Controls.Add(Cancelar_Criar_Cliente);
            Controls.Add(Ok_Criar_Cliente);
            Controls.Add(textBox_Endereco_Fisico);
            Controls.Add(textBox_Email_Cliente);
            Controls.Add(textBox_Numero_Telefone);
            Controls.Add(textBox_Nome_Cliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Criar_Cliente";
            Text = "Form_Criar_Cliente";
            Load += Form_Criar_Cliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_Nome_Cliente;
        private TextBox textBox_Numero_Telefone;
        private TextBox textBox_Email_Cliente;
        private TextBox textBox_Endereco_Fisico;
        private Button Ok_Criar_Cliente;
        private Button Cancelar_Criar_Cliente;
    }
}