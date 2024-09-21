using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01.Models;
using TP01.Repository;
using TP01.Repository.Interface;

namespace TP01.Services
{
    public class BookController
    {
        // Douglas Reis e Lucas Lusni
        private readonly IBookRepository _bookRepository;

        public BookController()
        {
            this._bookRepository = new BookRepository();
            this.initialLoad();
        }

        private void initialLoad()
        {
            var books = this._bookRepository.GetAll();

            if (books.Count <= 0)
            {
                Author[] authors = {
                    new Author("Robert C. Martin", "robertc@gmail.com", 'm'),
                    new Author("Bob Martin", "bobmartin@gmail.com", 'm')
                };

                Book book = new Book("Codigo Limpo: Habilidades Praticas do Agile Software", authors, 85.70, 1000);

                this._bookRepository.add(book);
            }
        }

        public Task GetBookName(HttpContext httpContext)
        {
            var book = _bookRepository.GetAll().FirstOrDefault();

            return httpContext.Response.WriteAsync(book.GetName());
        }

        public Task GetBooksWithAuthor(HttpContext httpContext)
        {
            var book = _bookRepository.GetAll().FirstOrDefault();

            return httpContext.Response.WriteAsync(book.GetAuthorsName());
        }

        public Task GetAuthorsNames(HttpContext httpContext)
        {
            var book = _bookRepository.GetAll().FirstOrDefault();

            return httpContext.Response.WriteAsync(book.ToString());
        }

        public Task GetHtmlBook(HttpContext context)
        {
            var book = _bookRepository.GetAll().FirstOrDefault();

            var authors = book.GetAuthors().Select(a => $"<li>{a.GetName()}</li>");

            return context.Response.WriteAsync($@"
                <h1>{book.GetName()}</h1>    

                <strong>Autores:</strong>
                <ol>
                    {string.Join("", authors)}
                </ol>
            ");
        }
    }
}
