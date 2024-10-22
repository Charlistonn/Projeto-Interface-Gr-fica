using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Interface
{
    public class Venda
    {
        public int Id { get; set; }
        [DisplayName("Id do Produto")] public int Id_Produto { get; set; }
        [DisplayName("Id do Cliente")] public int Id_Cliente { get; set; }
        [DisplayName("Quantidade Vendida")] public int quantidade_Vendida { get; set; }
        [DisplayName("Porcentagem de Desconto")] public float desconto_Venda { get; set; }
    }
}
