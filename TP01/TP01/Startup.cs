using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01.Services;

namespace TP01
{
    public class Startup
    {
        // Douglas Reis e Lucas Lusni
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }
        public void Configure(IApplicationBuilder app)
        {
            var builder = new RouteBuilder(app);

            BookController bookController = new BookController();   

            builder.MapRoute("Book/GetBookName", bookController.GetBookName);
            builder.MapRoute("Book/GetBooksWithAuthor", bookController.GetBooksWithAuthor);
            builder.MapRoute("Book/GetAuthorNames", bookController.GetAuthorsNames);
            builder.MapRoute("Book/ApresentarLivro", bookController.GetHtmlBook);

            var routers = builder.Build();
            app.UseRouter(routers);
        }
    }
}
