using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Interface
{
    public class Compra
    {
        public int Id { get; set; }
        [DisplayName("Id do Produto")] public int Id_Produto { get; set; }
        [DisplayName("Id do Fornecedor")] public int Id_Fornecedor { get; set; }
        [DisplayName("Quantidade Comprada")] public int quantidade_Comprada { get; set; }
        [DisplayName("Porcentagem de Desconto")] public float porcentagem_desconto {  get; set; }   

    }
}
