using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFinder.Api;
using Microsoft.Owin.Hosting;

namespace AutoFinder.SelfHost
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine("http server listening on 9000.  Press enter to stop.");
                Console.ReadLine();
            }


        }
    }

}
