using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP03_Douglas_Lucas.Models
{
    [Table("Produto")]
    public class Product
    {
        [Key]
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("Name")]
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Required field.")]
        [StringLength(100)]
        public string? Name { get; set; }


        [Column("Price")]
        [Display(Name = "Price")]
        [Required(ErrorMessage = "Required field.")]
        [Range(1, Double.PositiveInfinity, ErrorMessage = "The value is invalid.")]
        public decimal Price { get; set; }

        [Column("Unit")]
        [Display(Name = "Unit")]
        [Required(ErrorMessage = "Required field")]
        [Range(1, Double.PositiveInfinity, ErrorMessage = "The value is invalid.")]
        public int Unit { get; set; }

        [Column("Description")]
        [Display(Name = "Description")]
        [StringLength(255, ErrorMessage = "Field exceeded character limit. ")]
        public string? Description { get; set; }


        [Column("CategoryName")]
        [Display(Name = "Category Name")]
        [StringLength(100, ErrorMessage = "Field exceeded character limit")]
        public string? CategoryName { get; set; }
    }
}
