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
            //Console.Write("Hi everyone\n");
            //Console.Write("Type in a word: ");
            //string input;
            //input = Console.ReadLine();
            //Console.WriteLine($"{ input} is correct");
            //Console.ReadKey();

            Console.WriteLine("Give me a number between 0 and 10 (can have decimals: ");
            double input_one = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give me another number between 0 and 10 (can have decimals: "); //note that the input line goes one line below.
            double input_two = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"{input_one} + {input_two} equals {input_one + input_two}");
            Console.WriteLine($"{input_one} - {input_two} equals {input_one - input_two}");
            Console.WriteLine($"{input_one} * {input_one} equals {input_one * 2}");
            Console.WriteLine($"{input_one} mod {input_two} equals {input_one % input_two}");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine();
            Console.Write("Give me a number to compare (0 to 10, no decimals): ");
            int input_three = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give me another number to compare (0 to 10, no decimals): ");
            int input_four = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"1. I'll add 1 to the first input {input_three}: {++input_three}");//affects the value of the variable before printing it
            Console.WriteLine($"2. I'll subtract 1 to the second input {input_four}: {input_four--} (won't be seen)"); //affects the value of the variable after printing it
            Console.WriteLine($"3. The addition of the first, twice, is: {input_three + input_three}");
            Console.WriteLine($"4. The addition of the second, twice, is: {input_four + input_four}");
            Console.ReadLine();
        }
    }
}
