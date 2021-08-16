using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Models
{
    public class Competencia
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int Ano { get; set; }
    }
}
