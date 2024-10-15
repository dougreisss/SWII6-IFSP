using System;
using System.ComponentModel.DataAnnotations;

namespace TP02_Comex.Models
{
    public class Bl
    {
        [Required(ErrorMessage = "IdBL is required.")]
        public int IdBL { get; set; }

        [Required(ErrorMessage = "BL Number is required.")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Consignee is required.")]
        public string Consignee { get; set; }

        [Required(ErrorMessage = "Ship is required.")]
        public string Navio { get; set; }
    }
}
