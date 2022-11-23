using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoInterativa.Models
{
    [Table("Fabricante")]
    public class Fabricante
    {
        [Key]
        public int FabricanteId { get; set; }
        [Required]
        [Display(Name="Nome do Fabricante")]
        public string FabricanteName { get; set; }
        [Display(Name ="Segunda Categoria")]
        public string Categoria1 { get; set; }
        [Display(Name ="Primeira Categoria")]
        public string Categoria2 { get; set; }
        [Display(Name = "Terceira Categoria")]
        public string Categoria3 { get; set; }

        public virtual List<Produto> Produtos { get; set; }
    }
}
