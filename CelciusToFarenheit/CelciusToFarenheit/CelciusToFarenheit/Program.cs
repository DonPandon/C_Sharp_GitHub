using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelciusToFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            double conversion = 0.0;
            string temporal;

            do
            {
                Console.Clear();     // limpiar la pantalla
                input = 0;
                conversion = 0;
                Console.WriteLine("Unit to Convert:\n1) Celcius to Farenheit.\n2) Farenheit to Celcius.\n3)Exit.");//testing 1 line printing
                try //to avoid odd symbols during conversion
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    input = 0; //no need for issues
                    Console.WriteLine("--input not valid, try again--");
                }

                if (input == 1)
                {
                    Console.Write("::Value to convert: ");
                    try //to avoid odd symbols during conversion
                    {
                        conversion = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        conversion = 0.0; //no need for issues
                        Console.WriteLine("--input not valid, try again--");
                        //break;
                    }
                    conversion = 1.8 * conversion + 32;
                    Console.WriteLine($"Value converted: {conversion} °F");

                }

                if (input == 2)
                {
                    Console.Write("::Value to convert: ");
                    temporal = Console.ReadLine();
                    if (double.TryParse(temporal, out conversion))  //method used to test input
                    {
                        conversion = (5.0 / 9.0) * (conversion - 32);
                        Console.WriteLine($"Value converted: {conversion} °C");
                    }
                    else
                        Console.WriteLine("--input not valid, try again--");
                }


                Console.ReadKey();  //get a hold on the screen

            } while (input != 3);   //screen format
        }
    }
}
