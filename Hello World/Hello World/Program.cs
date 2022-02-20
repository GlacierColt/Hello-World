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
            Console.WriteLine();

            Console.WriteLine("Enter a double (float)");
            d = double.Parse(Console.ReadLine());
            Console.WriteLine("d: " + d);
            Console.WriteLine();

            Console.WriteLine("Enter a char");
            s = Console.ReadLine();
            if (s.Length != 1)
            {
                Console.Clear();
                Console.WriteLine("ERROR: The data you entred was not a valid char data type.");
                Console.ReadLine();
                return;
            }
            c = char.Parse(s);
            Console.WriteLine("c: " + c);
            Console.ReadLine();



        }

    }
}
