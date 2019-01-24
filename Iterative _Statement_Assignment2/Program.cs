/*    Author: Tracey McCombs
	    Date: 1/24/2019
	    Comments: This C# Console application code demonstrates the use of
	              iterative statements after getting input from users. 
	*/
         
using System;

namespace Iterative__Statement_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for input

            Console.WriteLine("Enter an Integer value between 1 and 100 to execute an iterative statement: ");

            /*
            Use the try catch block to validate user input.
               If the user provides bad input, the catch block
               will handle the error and a message will be displayed.
               */

            try
            {
                //this variable will capture input from user

                string input = Console.ReadLine();

                //this variable will be used to perform the various iterative statements and is parsed as an integer

                int input_value = int.Parse(input);

                Console.WriteLine("The integer value you entered is " + input_value);
                      

                // here is the For Loop

                for (int i = 1; i <= input_value; i++) 
                    {
                    Console.WriteLine("This is the current interger value in the loop " + i.ToString());
                    }
                Console.WriteLine("Press any key to exit...");

                //pause the program to view before closing
                Console.ReadKey(true);

            } //end of try

            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");

                //pause the program to view before closing
                Console.ReadKey(true);

            }//end of catch


        }//end static void
        }//end class
}//End namespace
