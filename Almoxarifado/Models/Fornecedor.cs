using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Models
{
    public class Fornecedor
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(14)]
        public string CNPJ { get; set; }

        [Required]
        [MaxLength(150)]
        public string Endereco { get; set; }

        [Required]
        public string Numero { get; set; }

        [MaxLength(150)]
        public string Complemento { get; set; } = "";

        [Required]
        [MaxLength(150)]
        public string Bairro { get; set; }
              

        [Required]
        [MaxLength(150)]
        public string Cidade { get; set; }

        [Required]
        [MaxLength(9)]
        public string CEP { get; set; }







    }
}
