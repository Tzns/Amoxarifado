using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Models
{
    public class Estoque
    {
        [Key]
        [Required]
        [ForeignKey("Produto")]
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }

        [Required]
        public long Quantidade { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal PrecoTotal { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal PrecoMedio { get; set; }


    }
}
