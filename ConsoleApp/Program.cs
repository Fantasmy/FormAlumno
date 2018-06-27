using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string v1 = System.Configuration.ConfigurationManager.AppSettings["k1"];
            string v2 = System.Configuration.ConfigurationManager.AppSettings["k2"];
            string v3 = System.Configuration.ConfigurationManager.AppSettings["k3"];
            Console.WriteLine(v1 + "" + v2 + "" + v3);
        }
    }
}

