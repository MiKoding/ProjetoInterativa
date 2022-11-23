using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoInterativa.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o preço do produto")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }


        [Display(Name="Fabricante")]
        public string CategoriaFabricante { get; set; }
        public string FabricanteNome { get; set; }
        public virtual Fabricante Fabricante { get; set; }
    }
}
