using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        // Usuarios que poderam ser add no sistema

namespace Entities.Entidades
{
    [Table("UsuarioSistemaFinanceiro")]
    public class UsuarioSistemaFinanceiro
    {
        public int Id { get; set; }
        public string EmailUsuario { get; set; }
        public bool Administrador { get; set; }
        public bool SistemaAtual { get; set; }

        
        [ForeignKey("SistemaFinanceiro")]
        // ForeignKey: É uma coluna, ou um conjunto de colunas, em uma tabela
        // que faz referência a uma chave primária ou única em outra tabela
        [Column(Order = 1)]
        public int IdSistema { get; set; }
        public virtual SistemaFinanceiro SistemaFinanceiro { get; set; }
    }
}
