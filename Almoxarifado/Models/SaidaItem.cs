using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Models
{
    public class SaidaItem
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Saida")]
        public int SaidaId { get; set; }
        public virtual Saida Saida{ get; set; }

        [Required]
        [ForeignKey("Produto")]
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }

        [Required]
        public long Quantidade { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal ValorTotal { get; set; }

        [Required]
        [Column(TypeName = "real")]
        public decimal PrecoMedio { get; set; }
    }
}
