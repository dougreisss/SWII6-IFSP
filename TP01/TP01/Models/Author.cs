using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01.Models
{
    // Douglas Reis e Lucas Lusni
    public class Author
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }

        public Author(string name, string email, char gender)
        {
            this.Name = name;
            this.Email = email;
            this.Gender = gender;
        }

        public string GetName()
        {
            return this.Name; 
        }

        public string GetEmail() 
        {
            return this.Email;
        }

        public char GetGender() 
        {
            return this.Gender; 
        }

        public override string ToString()
        {
            return $"Author[name={this.Name}, email={this.Email}, gender={this.Gender}]";
        }
    }
}
