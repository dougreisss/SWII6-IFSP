using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsApp.DTOs
{
    public class AuthDTO
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
