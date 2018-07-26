using System;

namespace CG_3_4_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Coming up with opening sentences have never been my
            strong suit.  No matter what I have to write.
            Hope you don't mind a little fun*/

            Console.WriteLine("Welcome to Alici'a crazy adding machine.");
            Console.WriteLine("You pick the numbers and the operation and we'll give you an answer.");
            Console.WriteLine("First, please provide any number between 1 and a million.");

            /*This sets up the app to accept the first inputted number by
            setting the variable to be given by whomever is inputting and
            for the code to include that into the equation.
            Also, apparently whenever you get input from a user, the program
            seems to deem it as a 'string' input.  Did NOT realize that.  
            That took me near a half an hour to figure out and had to look onto
            past assignment (read the rectangle assignment) to finally figure it out
            after MUCH alterations*/

            var No1 = Console.ReadLine();
            int input1 = Convert.ToInt32(No1);

            Console.WriteLine("Thank you! Now please provid a second number, again any number between 1 and a million.");

            /*This is just like above, with setting the variable to be an inputted 
            number to be used later on in the coding for the calulator part*/

            var No2 = Console.ReadLine();
            int input2 = Convert.ToInt32(No2);

            Console.WriteLine("Thank you again for that. Now please choose the operation you would like to use.");
            Console.WriteLine("You may choose one of the following: add, subtract, multiply, or divide.");

            var operation = Console.ReadLine();
            
            if (operation == "add")
            {
               var answeradd = input1 + input2;
                Console.WriteLine(answeradd);
            }

            else if (operation == "subtract")
            {
               var answersub = (input1 - input2);
                Console.WriteLine(answersub);
            }
            
            else if (operation == "multiply")
            {
                var answermult = (input1 * input2);
                Console.WriteLine(answermult);
            }

            else if (operation == "divide")
            {
                var answerdiv = (input1 / input2);
                Console.WriteLine(answerdiv);
            }

            else
            {
                Console.WriteLine("Sorry. I did not understand you. You fail.")
            }

                       
            Console.ReadLine();

        }
    }
}
