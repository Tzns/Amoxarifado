using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Almoxarifado.Models
{
    public class Produto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [ForeignKey("ProdutoGrupo")]
        public int GrupoId { get; set; }
        public virtual ProdutoGrupo PrudutoGrupo { get; set; }

        [Required]
        [ForeignKey("ProdutoUnidade")]
        public int UnidadeId { get; set; }
        public virtual ProdutoUnidade PrudutoUnidade { get; set; }

        [Required]
        public int Codigo { get; set; }

        [Required]
        [MaxLength(100)]
        public string Descricao { get; set; }

        
        public long? ContaContabil { get; set; }

        [Required]
        public int PontoPedido { get; set; }

        
        public long? CAEDespesa { get; set; }








    }
}