using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //Delegates are created here
    public delegate string MyDelegate(int arg1, int arg2);

    //used for composable delegates that passes information between delegates
    public delegate void MyDelegateTwo(int arg1, ref int arg2);

    //classes can also be used for delegates
    class MyClassForDelegates
    {
        //Delegates can be bound to instance members as well as static class functions
        public string instanceMethod1(int arg1, int arg2)
        {
            return ((arg1 + arg2) * arg1).ToString();
        }

    }




    //This is the class for the run-time program
    class Program
    {

        //functions to be used for the delegate
        static string func1(int a, int b){
            return (a + b).ToString();//Creo que esto es el metodo que convierte el resultado numerico en un string, que es lo que la funcion va a regresar
        }
        static string func2(int a, int b){
            return (a * b).ToString();
        }
        //NOTE: each of this functions match the delegate's signature (the way it is declared)


        //functions to be used for the composable delegate
        static void func3(int a, ref int b)
        {
            string result = (a + b).ToString();//Creo que esto es el metodo que convierte el resultado numerico en un string, que es lo que la funcion va a regresar
            b += 20;    //notice this change
            Console.WriteLine("The number is: " + result);
        }
        static void func4(int a, ref int b)
        {
            string result = (a * b).ToString();
            Console.WriteLine("The number is: " + result);
        }

        static void Main(string[] args)
        {
            //Delegates are "placeholders" for functionss that will be called at some point
            //Just as a variable can hold a string, a variable can be used to hold a reference for a function
            //Delegates can be called in order and changed?
            //events: used to broadcast and listen to messages (triggers?)
            //those who listen to events are called listeners or subscribers

            //Delegatea are "like" C+ function pointers or JS callbakcs
            //C# checks signatures
            //can be used to define callback functions
            //Can be dinamically switched at runtime

            //public delegate int MyDelegate(int i, string s);

            //these lines test the static functions
            MyDelegate f = func1; //f assigned to a specific function (that matches the signature)
            Console.WriteLine("The number is: " + f(10, 20));
            f = func2;
            Console.WriteLine("the number is now: " + f(10, 20));
            //output should be 30 and 200

            //these lines test the instance of the class for delegates
            MyClassForDelegates mc = new MyClassForDelegates();
            f = mc.instanceMethod1;
            Console.WriteLine("The number is: " + f(10, 20));
            //outut should be 300


            //Anonymous Delegates
            // instead of explicitely ddecllaring and naming a delegate function, they can be created as anonymous functions
            // This can be usefull if the delegate is a one-off function, or a function small enough to be declared in-line in order to improve the redability of the code.
            MyDelegate aF = delegate (int arg1, int arg2)
            {
                return (arg1 + arg2).ToString();
            };//don't forget the semi colon
            Console.WriteLine("The value is: " + aF(20, 30));
            //the result should be 50


            //COMPOSABLE DELEGATES
            //delegates can be chained together. They will be called in the order that it wwas added to the chain.
            //things to keep in mind:
            //1. Unhandled exceptions will skipp remaining delegates
            //2. Only the LAST return value will be returned to the calling function
            //3. To pass results from one delegate to another, use ref variables.

            MyDelegate f1 = func1;
            MyDelegate f2 = func2;
            MyDelegate f1f2 = f1 + f2;  //this is the delegate chain

            Console.WriteLine("Check the results:" + f1f2(10, 20));
            //notice only the last function pops a result.
            //if each function had its own direct output (part of the function) they will be printed individually

            //now, subtract a delegate from a chain
            f1f2 -= f2;
            Console.WriteLine("unchained delegate: " + f1f2(10, 20));

            Console.WriteLine("-----------\n\n");

            int a = 10, b = 20;
            MyDelegateTwo cF1 = func3;
            MyDelegateTwo cF2 = func4;
            MyDelegateTwo cF1F2 = cF1 + cF2;

            Console.WriteLine("The value of b is: {0}", b);
            cF1F2(a, ref b); //passing by reference
            Console.WriteLine("The value of b is: {0}", b);

            Console.ReadKey();

        }
    }
}
