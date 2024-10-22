using System.ComponentModel;

namespace Proj.Interface
{
    public partial class Form1 : Form
    {
        public BindingList<Produto> produtos { get; set; }
        public BindingList<Cliente> clientes { get; set; }
        public BindingList<Venda> vendas { get; set; }
        public BindingList<Compra> compras { get; set; }
        public BindingList<Fornecedor> fornecedores { get; set; }

        public Form1()
        {
            InitializeComponent();
            produtos = new BindingList<Produto>();
            clientes = new BindingList<Cliente>();
            vendas = new BindingList<Venda>();
            compras = new BindingList<Compra>();
            fornecedores = new BindingList<Fornecedor>();

            this.dataGridView1.DataSource = produtos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Adicionar_Produto_1_Click(object sender, EventArgs e)
        {
            Form_Criar_Produto fcp = new Form_Criar_Produto();
            var resultado = fcp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Produto produto = new Produto();
                if (produtos.Count == 0) produto.Id = 1;
                else produto.Id = produtos.Max(p => p.Id) + 1;

                produto.nome_Produto = fcp.nome_Produto;
                produto.nome_Fornecedor = fcp.nome_Fornecedor;
                produto.preco_Compra = fcp.preco_Compra;
                produto.preco_Venda = fcp.preco_Venda;

                produtos.Add(produto);
            }

        }

        private void Remover_Produto_2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                produtos.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void Adicionar_Cliente_Click(object sender, EventArgs e)
        {
            Form_Criar_Cliente fcc = new Form_Criar_Cliente();
            var resultado = fcc.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Cliente cliente = new Cliente();
                if (clientes.Count == 0) cliente.Id = 1;
                else cliente.Id = clientes.Max(c => c.Id) + 1;

                cliente.nome_Cliente = fcc.nome_Cliente;
                cliente.telefone_Cliente = fcc.numero_Telefone;
                cliente.email_Cliente = fcc.endereco_Email;
                cliente.endereco_Cliente = fcc.endereco_Fisico;

                clientes.Add(cliente);
            }
        }

        private void Remover_Cliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                clientes.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }

        }

        private void Adicionar_Venda_Click(object sender, EventArgs e)
        {
            Form_Criar_Venda fcv = new Form_Criar_Venda();
            var resultado = fcv.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Venda venda = new Venda();
                if (vendas.Count == 0) venda.Id = 1;
                else venda.Id = vendas.Max(v => v.Id) + 1;

                venda.Id_Produto = fcv.Id_Produto;
                venda.Id_Cliente = fcv.Id_Cliente;
                venda.quantidade_Vendida = fcv.quantidade_Vendida;
                venda.desconto_Venda = fcv.desconto_Venda;

                vendas.Add(venda);


            }
        }

        private void Remover_Venda_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                vendas.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void button_Adicionar_Compra_Click(object sender, EventArgs e)

        {
            if (fornecedores.Count ==0)
            {
                MessageBox.Show("Voçê Precisa Cadastrar Fornecedores antes de efetuar uma compra.!");
                return;
            }
            if (produtos.Count ==0)
            {
                MessageBox.Show("Você Precisa Cadastrar um Produto antes de efetuar uma compra.!");
                return;
            }

            Form_Criar_Compra fcc = new Form_Criar_Compra(fornecedores, produtos);
            var resultado = fcc.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Compra compra = new Compra();
                if (compras.Count == 0) compra.Id = 1;
                else compra.Id = compras.Max(m => m.Id) + 1;



                compra.Id_Produto = fcc.Id_Produto;
                compra.Id_Fornecedor = fcc.Id_Fornecedor;
                compra.quantidade_Comprada = (int) fcc.quantidade_Comprada;
                compra.porcentagem_desconto = fcc.porcentagem_desconto;

                compras.Add(compra);

            }
        }

        private void button_Remover_Compra_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                compras.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void button_Adicionar_Fornecedor_Click(object sender, EventArgs e)
        {
            Form_Criar_Fornecedor fcf = new Form_Criar_Fornecedor();
            var resultado = fcf.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Fornecedor fornecedor = new Fornecedor();
                if (fornecedores.Count == 0) fornecedor.Id = 1;
                else fornecedor.Id = fornecedores.Max(f => f.Id) + 1;

                fornecedor.nome_Fornecedor = fcf.nome_Fornecedor;
                fornecedor.telefone_Fornecedor = fcf.telefone_Fornecedor;
                fornecedor.email_Fornecedor = fcf.email_Fornecedor;
                fornecedor.endereco_Fornecedor = fcf.endereco_Fornecedor;

                fornecedores.Add(fornecedor);

            }
        }

        private void button_Remover_Fornecedor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                fornecedores.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void button_Produto_Figura3_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = produtos; }

        private void button_Cliente_Figura_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = clientes; }

        private void Button_Figura_Venda_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = vendas; }

        private void button_Figura_Compra_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = compras; }

        private void button_Figura_Fornecedor_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = fornecedores; }

              
    }
}

