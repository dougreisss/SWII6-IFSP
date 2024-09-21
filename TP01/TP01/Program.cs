using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01.Services;

namespace TP01
{
    public class Program
    {
        static void Main(string[] args)
        {
            BookController bookController = new BookController();

            TestBook testBook = new TestBook();

            testBook.TestMethod();

            IWebHost host = new WebHostBuilder()
                                .UseKestrel()
                                .UseStartup<Startup>()
                                .Build();
            host.Run();
        }
    }
}
