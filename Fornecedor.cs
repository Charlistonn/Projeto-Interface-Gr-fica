using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Interface
{
    public class Fornecedor
    {
        public int Id { get; set; }
        [DisplayName("Nome Fornecedor")] public string nome_Fornecedor { get; set; }
        [DisplayName("Número de Telefone")] public string telefone_Fornecedor { get; set; }
        [DisplayName("Endereço de Email")] public string email_Fornecedor { get; set; }
        [DisplayName("Endereço Físico")] public string endereco_Fornecedor { get; set;}
    }
}
