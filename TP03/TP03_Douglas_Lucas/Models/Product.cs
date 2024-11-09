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
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Column("Name")]
        [StringLength(100)]
        [Display(Name = "Name")]
        public string? Name { get; set; }
        [Column("Price")]
        [Range(1, 10000)]
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        [Column("Unit")]
        [Display(Name = "Unit")]
        public int Unit { get; set; }
        [Column("Description")]
        [StringLength(255)]
        [Display(Name = "Description")]
        public string? Description { get; set; }
        [Column("CategoryName")]
        [StringLength(100)]
        [Display(Name = "Category Name")]
        public string? CategoryName { get; set; }
    }
}
