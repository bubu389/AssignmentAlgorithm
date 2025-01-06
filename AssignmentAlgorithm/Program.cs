// .Net Libraries
// Ryan Vassallo HND 1 Programming 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAlgorithm // namespace covers anything within the project
{
    internal class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("Please Enter the size of the sorting arrray: "); // Print Statement.

            int size = int.Parse(Console.ReadLine()); // Creating a variable called size, then converting the users string(Text) to int.

            Console.WriteLine("Please Submit the Array Elements to be sorted. All submitted numeric numbers should be seperated with a space"); // Print Statement

            int[] inputArray = new int[size]; // Configuring the Array with the size the user gave.

            string[] userInput = Console.ReadLine().Split(' '); // Creating a string array that captures the ser input after splitting th values

            // For LOOP

            for (int i = 0; i < size; i++) // 0 , 1 , 2 , 3 , 4 = 5 numbers
            {
                inputArray[i] = int.Parse(userInput[i]); // Assigning the user input to the inputArray list
                Console.WriteLine(userInput[i]); // prints everything inside of the array 
            }
            

        }
    }
}
