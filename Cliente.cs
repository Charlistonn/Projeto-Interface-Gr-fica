using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Interface
{
    public  class Cliente
    {
        public int Id { get; set; }
        [DisplayName("Nome do Cliente")] public string nome_Cliente { get; set; }
        [DisplayName("Número de Telefone")] public  string telefone_Cliente { get; set; }
        [DisplayName("Endereço de Email")] public string email_Cliente { get; set; }
        [DisplayName("Endereço Físico")] public string endereco_Cliente { get; set; }

    }
}
