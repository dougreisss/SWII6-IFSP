using System;
using System.ComponentModel.DataAnnotations;

namespace TP02_Comex.Models
{
    public class Container
    {
        public int IdContainer { get; set; }

        [Required(ErrorMessage = "Container Number is required.")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Container Type is required.")]
        public string ContainerType { get; set; }

        [Required(ErrorMessage = "Container Size is required.")]
        public int? ContainerSize { get; set; }

        public Bl? Bl { get; set; }
    }
}