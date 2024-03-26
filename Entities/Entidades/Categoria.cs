using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{
    [Table("Categoria")]
    public class Categoria : Base
    {
        [ForeignKey("SistemaFinanceiro")]
        // ForeignKey: É uma coluna, ou um conjunto de colunas, em uma tabela
        // que faz referência a uma chave primária ou única em outra tabela
        [Column(Order = 1)]
        public int IdSistema { get; set; }
        //public virtual SistemaFinanceiro SistemaFinanceiro { get; set; }
    }
}
