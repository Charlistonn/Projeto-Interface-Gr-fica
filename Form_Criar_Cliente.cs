using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj.Interface
{
    public partial class Form_Criar_Cliente : Form
    {
        public string nome_Cliente { get { return textBox_Nome_Cliente.Text; } }
        public string numero_Telefone { get { return textBox_Numero_Telefone.Text; } }
        public string endereco_Email { get { return textBox_Email_Cliente.Text; } }
        public string endereco_Fisico { get { return textBox_Endereco_Fisico.Text; } }
        public Form_Criar_Cliente()
        {
            InitializeComponent();
        }

        private void Form_Criar_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void Ok_Criar_Cliente_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancelar_Criar_Cliente_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
            this.Close();
        }
    }
}
