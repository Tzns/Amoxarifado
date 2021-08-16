using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Models
{
    public class EntradaTipo
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int Codigo { get; set; }

        [Required]
        public string Descricao { get; set; }

    }
}
