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
    public partial class Form_Criar_Produto : Form
    {
        public string nome_Produto { get { return textBox_Nome_Produto2.Text; } }
        public string nome_Fornecedor { get { return textBox_Nome_Fornecedor_1.Text; } }
        public float preco_Compra { get { return (float)numericUpDown_Preco_Compra_1.Value; } }
        public float preco_Venda { get { return (float)numericUpDown_Preco_Venda2.Value; } }
        public Form_Criar_Produto()
        {
            InitializeComponent();
        }

        private void Form_Criar_Produto_Load(object sender, EventArgs e)
        {

        }

        private void Ok_Criar_Prod_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancelar_Criar_Prod_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
            this.Close();
        }
    }
}
