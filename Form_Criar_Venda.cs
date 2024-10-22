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
    public partial class Form_Criar_Venda : Form
    {
        public int Id_Produto { get { return (int)numericUpDown_ID_Produto.Value; } }
        public int Id_Cliente { get { return (int)numericUpDown_ID_Cliente.Value; } }
        public int quantidade_Vendida { get { return (int)numericUpDown_Quantidade_Vendida.Value; } }
        public int desconto_Venda { get { return (int)numericUpDown_Porcentagem_Desconto.Value; } }
        public Form_Criar_Venda()
        {
            InitializeComponent();
        }

        private void Form_Criar_Venda_Load(object sender, EventArgs e)
        {

        }

        private void Ok_Criar_Venda_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Ok_Cancelar_Venda_Click(object sender, EventArgs e)
        {
            this .DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
