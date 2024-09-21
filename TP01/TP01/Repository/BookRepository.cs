using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01.Models;
using TP01.Repository.Interface;

namespace TP01.Repository
{
    // Douglas Reis e Lucas Lusni
    public class BookRepository : IBookRepository
    {
        private static readonly string nameDatabaseCSV = "books.csv";

        private List<Book> _books;

        public BookRepository()
        {
            this.LoadBooksCsv();
        }

        public List<Book> GetAll()
        {
            return this._books.ToList();
        }

        public void add(Book book)
        {
            using (var file = File.AppendText(BookRepository.nameDatabaseCSV))
            {
                var authorsJson = JsonConvert.SerializeObject(book.GetAuthors());
                file.WriteLine($"{book.GetName()};{authorsJson};{book.GetPrice()};{book.GetQty()}");
            }
        }

        private void LoadBooksCsv()
        {
            var books = new List<Book>();

            if (!File.Exists(BookRepository.nameDatabaseCSV))
            {
                using (var createFile = File.CreateText(BookRepository.nameDatabaseCSV)) { };
            }

            using (var file = File.OpenText(BookRepository.nameDatabaseCSV))
            {
                while (!file.EndOfStream)
                {
                    var textBook = file.ReadLine();

                    if (string.IsNullOrEmpty(textBook))
                    {
                        continue;
                    }

                    var infosBook = textBook.Split(';');

                    var authors = ConvertAuthor(infosBook[1]);

                    var book = new Book(
                        infosBook[0],
                        authors,
                        Convert.ToDouble(infosBook[2]),
                        Convert.ToInt32(infosBook[3])
                    );

                    books.Add(book);
                }
            }

            this._books = books;
        }

        private Author[] ConvertAuthor(string authorsJson)
        {
            var authors = JsonConvert.DeserializeObject<Author[]>(authorsJson);
            return authors;
        }

    }
}
