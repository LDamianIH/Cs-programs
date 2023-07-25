using System;
using System.ComponentModel.DataAnnotations;
using System.Net.WebSockets;
using System.Runtime.InteropServices;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1 --");                  //without jumping to next line
            Console.WriteLine("Hello World");
            /* As c++ we can use a \x in a string to make a new line, tab, backspace etc 
            \n - new line
            \t - tab character
            \b - backspace
             */

            //Declarations
            int x;
            //initializations
            x = 10;
            //declaration and initialization
            int y = 12;
            double z = x + y;
            bool alive = true;
            char symbol = '@';    //only 1 symbol
            string name = "Damian";

            Console.WriteLine("Hi " + name + "are you " + z + " years old?");
            if (alive)
            {
                Console.WriteLine("Your username is " + symbol + name);
            }

            //the constants cannot be modified
            const double pi = 3.14159;
            Console.WriteLine("The value of pi is " + pi);

            /*type casting converting a value to a different data type, different data types can do 
            different things. We can convert a string true to a bool and also a string symbol to a char*/
            double a = 5.34;
            int b = Convert.ToInt32(a);     /*To convert to double we use ToDouble(variable) and also with 
                                             other data types*/

            Console.WriteLine("\nThe round value of a is: " + b);
            Console.WriteLine("And his original data type is: " + a.GetType() + "\n");

            // To get an input we need to define the variable first
            Console.WriteLine("Write something");
            String something = Console.ReadLine();

            Console.WriteLine("Printing something: " + something + "\n");

            //Operations with the class Math 
            Console.Write("Write one number: ");
            String strn1 = Console.ReadLine();      //to read an integer we need to 
            double n1 = Convert.ToDouble(strn1);        //convert it to an integer
            Console.WriteLine("The square of your number is: " + Math.Pow(n1,2));
            Console.WriteLine("The square root of your number is: " + Math.Sqrt(n1));
            Console.WriteLine("Your number rounded is: " + Math.Round(n1));
            
            Console.Write("Write another number: ");
            String strn2 = Console.ReadLine();
            double n2 = Convert.ToDouble(strn2);
            Console.WriteLine("The maximum number of these two is " + Math.Max(n1, n2));
            Console.WriteLine("And the minimum is " + Math.Min(n1, n2) + "\n");

            //Random numbers
            Random rand = new Random();

            int randnum = rand.Next(1, 7);
            double randdouble = rand.NextDouble();
            Console.WriteLine("Firs random number: " + randnum);
            Console.WriteLine("Second random number. " + randdouble);

            //string methods
            Console.WriteLine("Enter something to make it in upper case");
            String something2 = Console.ReadLine();
            something2 = something2.ToUpper();
            Console.WriteLine(something2);

            Console.WriteLine("Enter something to make it in lower case");
            String something3 = Console.ReadLine();
            something3 = something3.ToLower();
            Console.WriteLine(something3);

            //we can replace some character in a string and also insert a character (in c# the first index is 0)
            something3 = something3.Replace("a", "x");
            Console.WriteLine("The a letters were replaced by x's " + something3);
            something3 = something3.Insert(0, "@");
            Console.WriteLine("An @ was inserted in the position 0 " + something3);
            Console.WriteLine("The final lenght of the last string is " + something3.Length);

            //with substring method we can make another string from a string taking a section of this
            Console.WriteLine("Write your full name: ");
            String fullname = Console.ReadLine();
            Console.WriteLine("The first 5 characters of your full name are: " + fullname.Substring(0, 5));


            Console.ReadKey();      //To finish the program when we press any key
        }
    }
}