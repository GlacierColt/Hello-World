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
            int index;
            string sindex;
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            Console.WriteLine("Select a section.");
            Console.WriteLine("1. String");
            Console.WriteLine("2. Integer");
            Console.WriteLine("3. Double");
            Console.WriteLine("4. Character");
            Console.WriteLine("5. *******");
            Console.WriteLine("6. *******");
            Console.WriteLine();
            Console.WriteLine("Please type a section number and press enter. (Eg. '1' for a string)");
            sindex = Console.ReadLine();
            if (sindex == null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: The input was invalid, enter a valid integer.");
                Console.ReadLine();
                return;
            }

            bool b;
            b = false;
            if (int.TryParse(sindex,out int value))
            {
                b = true;      
            }

            if (b == false)
            {
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("ERROR: The input was invalid, enter a valid integer.");
                Console.ReadLine();
                return;
            }

            index = int.Parse(sindex);



            string s;
            int i;
            double d;
            char c;

            if (index == 1)
            {
                Console.WriteLine("Enter a string");
                s = Console.ReadLine();
                Console.WriteLine("s: " + s);
                Console.WriteLine();

            }

            if (index == 2)
            {
                Console.WriteLine("Enter a integer");
                s = Console.ReadLine();
                if (s.Length == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: The integer must be at least 1 character long.");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    i = int.Parse(s);
                    Console.WriteLine("i: " + i);
                    Console.WriteLine();
                }
            }

            if (index == 3)
            {
                Console.WriteLine("Enter a double (float)");
                d = double.Parse(Console.ReadLine());
                Console.WriteLine("d: " + d);
                Console.WriteLine();
            }

            if (index == 4)
            {
                Console.WriteLine("Enter a char");
                s = Console.ReadLine();
                if (s.Length != 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: The data you entred was not a valid char data type.");
                    Console.ReadLine();
                    return;
                }
                c = char.Parse(s);
                Console.WriteLine("c: " + c);
                Console.ReadLine();
            }

            if (index > 4)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: The data entered is invalid or is still under construction");
                Console.ReadLine();
                return;
            }





        }

    }
}
