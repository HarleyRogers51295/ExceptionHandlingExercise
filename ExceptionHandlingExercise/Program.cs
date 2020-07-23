using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr DONE
            char[] arr = { '1', '2', '3', '4', '5', '6', 'A', 'B', 'C' };
            // Create a list called numbers that will hold integers  DONE
            List<int> numbers = new List<int>();
            // Create an string variable with an empty string initializer - name it str DONE
            string str = " ";

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse() DONE
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------
          
            //TODO START HERE:

            // Make a foreach loop to iterate through your character array
            foreach (char elements in arr)
            {
                // Now create a try catch
                try
                {
                    // Inside your try block
                    // set your string variable to each array element in your char[] to .ToString()
                    str = elements.ToString();
                    // Now, using int.Parse, parse your string variable and store in an int variable
                    int num = int.Parse(str);
                    // Then add each int to your list
                    numbers.Add(num);
                }
                catch ( Exception ex)
                {
                    // catch your Exception:
                    // in the scope of your catch you can use the following, 

                    Console.WriteLine($"Unable to Parse '{elements}'"); //character will be the name of each item in your collection

                    foreach (var num in numbers)
                    {
                        Console.WriteLine(num);
                    }
                }
            }


            
        }
    }
}
