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
    public partial class Form_Criar_Compra : Form
    {

        private BindingList<Fornecedor> Fornecedores { get; set; }
        public Fornecedor Fornecedor { get { return Fornecedores.FirstOrDefault(f => f.Id == (int)comboBox_Forncedor_Criar_Compra.SelectedValue); } }
        public int Id_Fornecedor { get { return (int)comboBox_Forncedor_Criar_Compra.SelectedValue; } }

        private BindingList<Produto> Produtos { get; set; }
        private Produto Produto { get { return Produtos.FirstOrDefault(p => p.Id == (int)comboBox_Produto_Criar_Compra.SelectedValue); } }
        public int Id_Produto { get { return (int)comboBox_Produto_Criar_Compra.SelectedValue; } }


        public float quantidade_Comprada { get { return (float)numericUpDown_Quantidade_Comprada.Value; } }
        public float porcentagem_desconto { get { return (float)numericUpDown_Porcentagem_Desconto.Value; } }


        private float Preco_Unitario { get { return Produto.preco_Compra; } }
        private float Valor_Total { get { return Preco_Unitario * quantidade_Comprada; } }
        private float Total_Desconto { get { return Total_Desconto * (1 - (porcentagem_desconto / 100)); } }


        public Form_Criar_Compra(BindingList<Fornecedor> fornecedores, BindingList<Produto> produtos)
        {
            InitializeComponent();
            Fornecedores = fornecedores;
            comboBox_Forncedor_Criar_Compra.DataSource = Fornecedores;
            comboBox_Forncedor_Criar_Compra.ValueMember = "Id";
            comboBox_Forncedor_Criar_Compra.DisplayMember = "Nome Empresa";

            Produtos = produtos;
            comboBox_Produto_Criar_Compra.DataSource = Produtos;
            comboBox_Produto_Criar_Compra.ValueMember = "Id";
            comboBox_Produto_Criar_Compra.DisplayMember = "Nome Fornecedor";

        }

        private void Form_Criar_Compra_Load(object sender, EventArgs e)
        {

        }

        private void button_OK_Criar_Compra_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_Cancelar_Compra_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void comboBox_ID_Produto_Criar_Compra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e) // labhel Desconto
        {

        }
    }
}
