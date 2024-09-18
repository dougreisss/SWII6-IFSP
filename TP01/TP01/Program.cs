using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebHost host = new WebHostBuilder()
                                .UseKestrel()
                                .UseStartup<Startup>()
                                .Build();
            host.Run();
        }
    }
}
