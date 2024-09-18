using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01.Models
{
    public class Book
    {
        private string Name;
        private Author[] Authors;
        private double Price;
        private int Qty;

        public Book(string name, Author[] authors, double price)
        {
            this.Name = name;
            this.Authors = authors; 
            this.Price = price;
        }

        public Book(string name, Author[] authors, double price, int qty)
        {
            this.Name = name;
            this.Authors = authors;
            this.Price = price;
            this.Qty = qty; 
        }

        public string GetName()
        {
            return this.Name;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public Author[] GetAuthors()
        {
            return this.Authors;
        }

        public double GetPrice()
        {
            return this.Price;
        }

        public void SetPrice(double price)
        {
            this.Price = price;
        }

        public int GetQty()
        {
            return this.Qty;
        }

        public void SetQty(int qty)
        {
            this.Qty = qty;
        }

        public override string ToString()
        {
            StringBuilder stringBuilderAuthors = new StringBuilder();  

            foreach (var author in this.Authors)
            {
                stringBuilderAuthors.Append($"{{Author[name = {author.GetName()}, email = {author.GetEmail()}, gender = {author.GetGender()}]}}");
            }

            return $"Book[name = {this.Name}, authors = {stringBuilderAuthors}, ]";
        }

        public string GetAuthorsName()
        {
            StringBuilder stringBuilderAuthors = new StringBuilder();

            foreach(var author in this.Authors)
            {
                stringBuilderAuthors.Append($"{author.GetName()}");
            }

            return stringBuilderAuthors.ToString();
        }
    }
}
