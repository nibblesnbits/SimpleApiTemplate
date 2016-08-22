using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectAPI;
using Microsoft.Owin.Hosting;

namespace ConsoleHostProject
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://localhost:8080"))
            {
                Console.ReadLine();
            }
        }
    }
}
