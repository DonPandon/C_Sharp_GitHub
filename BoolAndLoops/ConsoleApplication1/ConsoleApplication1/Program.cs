using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Give me a number: ");
            //double inputOne = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Give me another number: ");
            //double inputTwo = Convert.ToDouble(Console.ReadLine());
            //bool result = inputOne == inputTwo;   //the result of the boolean operation is stored in "result"
            //Console.WriteLine();
            //Console.WriteLine($"Both numbers are equal: {result}");
            //Console.ReadKey();

            Console.WriteLine("Truth table: AND");
            bool A = false, B = false;
            Console.WriteLine($"A\tB\tY");
            Console.WriteLine($"{A}\t{B}\t{A && B}");
            A = true;
            Console.WriteLine($"{A}\t{B}\t{A && B}");
            A = false;
            B = true;
            Console.WriteLine($"{A}\t{B}\t{A && B}");
            A = true;
            Console.WriteLine($"{A}\t{B}\t{A && B}");

            Console.WriteLine("\nTruth table: OR");
            A = false;
            B = false;
            Console.WriteLine($"A\tB\tY");
            Console.WriteLine($"{A}\t{B}\t{A || B}");
            A = true;
            Console.WriteLine($"{A}\t{B}\t{A || B}");
            A = false;
            B = true;
            Console.WriteLine($"{A}\t{B}\t{A || B}");
            A = true;
            Console.WriteLine($"{A}\t{B}\t{A || B}");

            Console.WriteLine("\nTruth table: NAND");
            A = false;
            B = false;
            Console.WriteLine($"A\tB\tY");
            Console.WriteLine($"{A}\t{B}\t{!(A && B)}");
            A = true;
            Console.WriteLine($"{A}\t{B}\t{!(A && B)}");
            A = false;
            B = true;
            Console.WriteLine($"{A}\t{B}\t{!(A && B)}");
            A = true;
            Console.WriteLine($"{A}\t{B}\t{!(A && B)}");

            Console.WriteLine("\nTruth table: NOR");
            A = false;
            B = false;
            Console.WriteLine($"A\tB\tY");
            Console.WriteLine($"{A}\t{B}\t{!(A || B)}");
            A = true;
            Console.WriteLine($"{A}\t{B}\t{!(A || B)}");
            A = false;
            B = true;
            Console.WriteLine($"{A}\t{B}\t{!(A || B)}");
            A = true;
            Console.WriteLine($"{A}\t{B}\t{!(A || B)}");


            Console.ReadKey();

        }
    }
}
