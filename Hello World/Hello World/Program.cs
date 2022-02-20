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
            string s;
            int i;
            double d;
            char c;

            Console.WriteLine("Hello World");
            Console.WriteLine();
            Console.WriteLine("Enter a string");
            s = Console.ReadLine();
            Console.WriteLine("s: " + s);
            Console.WriteLine();
            Console.WriteLine("Enter a integer");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("i: " + i);
            Console.ReadLine();


        }

    }
}
