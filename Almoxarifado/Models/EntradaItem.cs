using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Models
{
    public class EntradaItem
    {      
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Entrada")]
        public int EntradaId { get; set; }
        public virtual Entrada Entrada { get; set; }

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
