using System.ComponentModel.DataAnnotations;

namespace UtilsApp.DTOs
{
    public class ProductDTO
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Preço")]
        public float Price { get; set; }

        [Display(Name = "Status")]
        public bool Status { get; set; }

        [Display(Name = "Criado por")]
        public int CreatedByUserId { get; set; }

        [Display(Name = "Atualizado por")]
        public int? UpdatedByUserId { get; set; }
    }
}
