using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01.Models
{
    public class Author
    {
        private string Name;
        private string Email;
        private char Gender;
        
        // to do 

        // set authors


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
    }
}
