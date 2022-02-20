using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sline;
            Console.WriteLine("Hello World.");
            Console.WriteLine("Please write a line to be dispalyed and saved in sline:");
            sline = Console.ReadLine();
            Console.WriteLine("sline: " + sline);
            Console.ReadLine(); 
        }

    }
}
