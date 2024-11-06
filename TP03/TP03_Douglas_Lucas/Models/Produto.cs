using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP03_Douglas_Lucas.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }
        [Column("Nome")]
        [StringLength(100)]
        public string? Nome { get; set; }
        [Column("Preco")]
        [Range(1, 10000)]
        public decimal Preco { get; set; }
        [Column("Unidade")]
        public int Unidade { get; set; }
        [Column("Descricao")]
        [StringLength(255)]
        public string? Descricao { get; set; }
        [Column("Categoria")]
        [StringLength(100)]
        public string? Categoria { get; set; }
    }
}
