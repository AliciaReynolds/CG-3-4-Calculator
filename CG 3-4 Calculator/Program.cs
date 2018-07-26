using System;

namespace CG_3_4_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            //Coming up with opening sentences have never been my
            //strong suit.  No matter what I have to write.
            //Hope you don't mind a little fun

            Console.WriteLine("Welcome to Alici'a crazy adding machine.");
            Console.WriteLine("You pick the numbers and the operation and we'll give you an answer.");
            Console.WriteLine("First, please provide any number between 1 and a million.");

            //This sets up the app to accept the first inputted number by
            //setting the variable to be given by whomever is inputting and
            //for the code to include that into the equation.

            var No1 = Console.ReadLine();

            Console.WriteLine("Thank you! Now please provid a second number, again any number between 1 and a million.");

            //This is just like above, with setting the variable to be an inputted 
            //number to be used later on in the coding for the calulator part

            var No2 = Console.ReadLine();

            Console.WriteLine("Thank you again for that. Now please choose the operation you would like to use.");
            Console.WriteLine("You may choose one of the following: add, subtract, multiply, or divide.");

            var operation = Console.ReadLine();

            //Intially I forgot this little bit and when I ran the code, it came up with the numbers
            //married and not added, so 13 instead of 4.  Oopps.

            var answer = No1 + No2;


            Console.WriteLine(answer);
            Console.ReadLine();

        }
    }
}
