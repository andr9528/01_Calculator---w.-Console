using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Calculator;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Exit = false;

            do
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1 = Add");
                Console.WriteLine("2 = Sum");
                Console.WriteLine("3 = Subtract");
                Console.WriteLine("4 = Multiply");
                Console.WriteLine("5 = Power");
                Console.WriteLine("6 = Factorial");
                Console.WriteLine("7 = Exit");
                int input1 = Convert.ToInt32(Console.ReadLine());

                // Console.WriteLine("You choose " + input1);

                switch (input1)
                {
                    case 1:
                        Console.WriteLine("You have chosen to add, I accept 2 numbers");
                        Console.WriteLine("Give me the first number");
                        int input2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The first number is " + input2 + ", What is your Second number?");
                        int input3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("So you wish add " + input2 + " + " + input3 + " together");
                        Console.WriteLine("Your result is " + Calculator.Add(input2, input3));
                        Console.ReadLine();
                        break;
                    /*
                     case 2

                     case 3

                     case 4

                     case 5

                     case 6
                     */
                    case 7:
                        Exit = true;
                        break;
                    default:
                        Console.WriteLine("Something Went Wrong");
                        break;
                } 
            } while (Exit == false);
        }
    }
}
