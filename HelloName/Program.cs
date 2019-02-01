/* Author: Mariel Lanza
 * Date: 1/30/2019
   Comments: This C# Console application code demonstrates Arrays. On this project
   I used the Auto Populated Array and it will execute the size of 25 elements with 
   no user input. This will be displayed 25 times using the FOR LOOP.
   
 */
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The TRY + CATCH block will verify user input
               CATCH will handle bad input and will display an error message
            */
            try
            {   // This array will automatically auto populated            
                int[] addup = new int[26];

                int pop_array = 1; // This variable will populate the array starting from the whole number 1

                // Execute the Array applying the FOR LOOP
                for(int i=1; i < 26; i++) // This will increment and add up 1 in the loop until it reaches 25
                {
                    addup[i] = pop_array;
                    Console.WriteLine("Element value=" + i);

                    Console.ReadKey(true); // Pause 
                }
            }
            catch
            {
                Console.WriteLine("An error was found. Please try again...");
                Console.ReadKey(true); // Pause 
            } // End of catch 
        } // ENd of try
    } // End of main
}  // End of namespace
