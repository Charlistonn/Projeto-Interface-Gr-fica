using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Interface
{
    public class Produto
    {
        public int Id { get; set; }
        [DisplayName("Nome do Produto")] public string nome_Produto { get; set; }
        [DisplayName("Nome do Fornecedor")] public string nome_Fornecedor { get; set; }
        [DisplayName("Preço da Compra")] public float preco_Compra {  get; set; }
        [DisplayName("Preço da da Venda")] public float preco_Venda { get; set; }
        [DisplayName("Preço unitario")] public float Preco_Unitario { get; set; }
        [DisplayName("Valor Total")] public float Valor_Total { get; set; }
        [DisplayName("Desconto Total")] public float Total_Desonto { get; set; }

    }
}
