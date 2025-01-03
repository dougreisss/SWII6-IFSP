using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApi.Model
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        public string Password { get; set; }

        [Required]
        public bool Status { get; set; }

        [InverseProperty("CreatedByUser")]
        [JsonIgnore]
        public ICollection<Product>? CreatedByUser { get; set; }

        [InverseProperty("UpdatedByUser")]
        [JsonIgnore]
        public ICollection<Product>? UpdatedByUser { get; set; }
    }
}
