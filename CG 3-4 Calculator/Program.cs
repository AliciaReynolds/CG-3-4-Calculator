using System;

namespace CG_3_4_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            //Coming up with opening sentences have never been my
            //strong suit.  No matter what I have to write.

            Console.WriteLine("Welcome to Alici'a crazy adding machine.");
            Console.WriteLine("You pick the numbers and the operation and we'll give you an answer.");
            Console.WriteLine("First, please provide any number between 1 and a million.");

            var No1 = Console.ReadLine();

            Console.WriteLine("Thank you! Now please provid a second number, again any number between 1 and a million.");

            var No2 = Console.ReadLine();

            var answer = No1 + No2;


            Console.WriteLine(answer);
            Console.ReadLine();

        }
    }
}
