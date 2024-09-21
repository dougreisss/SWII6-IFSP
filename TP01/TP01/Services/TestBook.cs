using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01.Models;

namespace TP01.Services
{
    public class TestBook
    {
        public void TestMethod()
        {
            Console.WriteLine("----------------------------------------------");

            Author author1 = new Author("Robert Cecil", "robertcecil@gmail.com", 'm');
            Author author2 = new Author("Mick Morgan", "mickmorgan@gmail.com", 'm');

            Author[] authors = { author1, author2 };

            Book book = new Book("Código Limpo: Habilidades práticas do Agile Software", authors, 29.99, 100);

            Console.WriteLine("Book name: " + book.GetName());
            Console.WriteLine("Authors: " + book.GetAuthorsName());
            Console.WriteLine("Book price: " + book.GetPrice());
            Console.WriteLine("Quantity available: " + book.GetQty());

            book.SetPrice(70.00);
            book.SetQty(82);

            Console.WriteLine("New book price: " + book.GetPrice());
            Console.WriteLine("New quantity available: " + book.GetQty());

            Console.WriteLine(book.ToString());
            Console.WriteLine("----------------------------------------------");
        }
    }
}
