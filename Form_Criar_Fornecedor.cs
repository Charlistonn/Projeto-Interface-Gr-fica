using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj.Interface
{
    public partial class Form_Criar_Fornecedor : Form
    {
        public string nome_Fornecedor { get { return textBox_Nome_Fornecedor.Text; } }
        public string telefone_Fornecedor { get { return textBox_Telefone_Fornecedor.Text; } }
        public string email_Fornecedor { get { return textBox_Email_Fornecedor.Text; } }
        public string endereco_Fornecedor { get { return textBox_Endereço_Fisico_Fornecedor.Text; } }
        public Form_Criar_Fornecedor()
        {
            InitializeComponent();
        }

        private void Form_Criar_Fornecedor_Load(object sender, EventArgs e)
        {

        }

        private void button_Ok_Criar_Fornecedor_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_Cancelar_Fornecedor_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
            this.Close();
        }
    }
}
