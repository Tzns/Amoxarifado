using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Models
{
    public class ProdutoUnidade
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(5)]
        public string Sigla { get; set; }

        [Required]
        [MaxLength(100)]
        public string Descricao { get; set; }
    }
}
