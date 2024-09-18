using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01.Models;

namespace TP01.Services
{
    public class BookController
    {
        public Task GetBookName(HttpContext httpContext)
        {
            var authors = new Author[1];

            var book = new Book("teste", authors, 10);

            return httpContext.Response.WriteAsync(book.GetName());
        }

        public Task GetBooksWithAuthor(HttpContext httpContext)
        {
            var authors = new Author[1];

            var book = new Book("teste", authors, 10);

            return httpContext.Response.WriteAsync(book.ToString());
        }

        public Task GetAuthors(HttpContext httpContext)
        {
            var authors = new Author[1];

            authors[0] = new Author();

            var book = new Book("teste", authors, 10);

            return httpContext.Response.WriteAsync(book.ToString());
        }
    }
}
