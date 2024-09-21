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
        public Author[] Authors { get; set; }
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
            var authors = string.Join(", ", this.Authors.Select(a => a.ToString()));
            return $"Book[name={this.Name}, authors={{{authors}}}, price={this.Price}, qty={this.Qty}]";
        }

        public string GetAuthorsName()
        {
            var authorNames = this.Authors.Select(a => a.GetName()).ToArray();
            return string.Join(", ", authorNames);
        }
    }
}
