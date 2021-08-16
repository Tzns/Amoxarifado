using System.ComponentModel.DataAnnotations;

namespace Almoxarifado.Models
{
    public class SaidaTipo
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