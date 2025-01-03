using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApi.Model
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(300)]
        public string Name { get; set; }

        [Required]
        [Range(0, float.MaxValue)]
        public float Price { get; set; }

        [Required]
        public bool Status { get; set; }

        [ForeignKey("CreatedUser")]
        public int CreatedByUserId { get; set; }

        [InverseProperty("CreatedByUser")]
        [JsonIgnore]
        public User? CreatedByUser { get; set; }

        [ForeignKey("UpatedUser")]
        public int? UpdatedByUserId { get; set; }

        [InverseProperty("UpdatedByUser")]
        [JsonIgnore]
        public User? UpdatedByUser { get; set; }
    }
}
