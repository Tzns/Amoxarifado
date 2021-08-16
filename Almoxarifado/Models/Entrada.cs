using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Models
{
    public class Entrada
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "smalldatetime")]
        public DateTime Data { get; set; }

        [Required]
        [ForeignKey("Fornecedor")]
        public int FornecedorId { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }

        [Required]
        public string Documento { get; set; }

        public string Empenho { get; set; } = "";

        [Required]
        [ForeignKey("EntradaTipo")]
        public int EntradaTipoId { get; set; }
        public virtual EntradaTipo EntradaTipo { get; set; }









    }
}
