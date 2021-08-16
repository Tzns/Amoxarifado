using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Models
{
    public class Saida
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "smalldatetime")]
        public DateTime Data { get; set; }
             
        [Required]
        public string Documento { get; set; }
            

        [Required]
        [ForeignKey("SaidaTipo")]
        public int SaidaTipoId { get; set; }
        public virtual SaidaTipo SaidaTipo { get; set; }
    }
}
