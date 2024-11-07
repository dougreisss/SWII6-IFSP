using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP03_Douglas_Lucas.Models
{
    [Table("Produto")]
    public class Product
    {
        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }
        [Column("Nome")]
        [StringLength(100)]
        public string? Name { get; set; }
        [Column("Preco")]
        [Range(1, 10000)]
        public decimal Price { get; set; }
        [Column("Unidade")]
        public int Unit { get; set; }
        [Column("Descricao")]
        [StringLength(255)]
        public string? Description { get; set; }
        [Column("Categoria")]
        [StringLength(100)]
        public string? CategoryName { get; set; }
    }
}
