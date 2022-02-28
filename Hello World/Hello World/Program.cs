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
            byte index;
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
            if (byte.TryParse(sindex,out byte value))
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

            index = byte.Parse(sindex);



            string s;
            int i;
            double d;
            char c;

            if (index == 1)
            {
                Console.Clear();
                Console.WriteLine("Enter a string");
                s = Console.ReadLine();
                Console.WriteLine("s: " + s);
                Console.ReadLine();
                return;

            }

            if (index == 2)
            {
                Console.Clear();
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
                    Console.WriteLine("C# is dumb so this is what it think 45/2 is... Use doubles to get decimal points.");
                    Console.WriteLine(45 / 2);  //Note, the result is 22 not 22.5
                                                // Console.WriteLine(45.00/2.00); <-- This is how you get with decimals
                    Console.WriteLine("Use a % sign to check if something has a remiander. 45 % 2 =");
                    Console.WriteLine(45 % 2);
                    Console.WriteLine(++i);
                    Console.WriteLine(i++);
                    Console.WriteLine(i);
                    Console.WriteLine(i--);
                    Console.WriteLine(--i);
                    Console.WriteLine(i);
                    const int n = 5;
                    Console.WriteLine(n);
                    Console.ReadLine();
                    return;
                  
                }
            }

            if (index == 3)
            {
                Console.Clear();
                Console.WriteLine("Enter a double (float)");
                d = double.Parse(Console.ReadLine());
                Console.WriteLine("d: " + d);
                Console.WriteLine(d.ToString("C")); //"C","F","C3"
                Console.WriteLine("{0,20}", d); // <-- Aligns to the right //0 is the place holder for d.
                Console.WriteLine("{0,-18}", d); // <-- Aligns to the left 
                Console.ReadLine();
                return;
            }

            if (index == 4)
            {
                Console.Clear();
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
                return;
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
