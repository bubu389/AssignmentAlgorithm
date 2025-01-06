// .Net Libraries
// HND 1 Programming 
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

            Console.WriteLine("Please Submit the Array Elements to be sorted. All submitted numeric numbers should be seperated with a space: "); // Print Statement
            Console.WriteLine(); // Printing an Empty Line for neatness

            int[] inputArray = new int[size]; // Configuring the Array with the size the user gave.

            string[] userInput = Console.ReadLine().Split(' '); // Creating a string array that captures the ser input after splitting th values

            // For LOOP
            Console.WriteLine(); // Printing an Empty Line for neatness

            Console.WriteLine("The Inputted Array Elements are: "); // Print Statement

            Console.WriteLine(); // Printing an Empty Line for neatness

            for (int i = 0; i < size; i++) 
            {
                inputArray[i] = int.Parse(userInput[i]); // Assigning the user input to the inputArray list

                Console.WriteLine(userInput[i]); // prints everything inside of the array in a vertical line
            }
            
            BubbleSort myBubbleSort = new BubbleSort(); // Creating an instance of the BubbleSort class

            BubbleSort.BubbleSortMethod(inputArray); // Calling the BubbleSortMethod from the BubbleSort class

            Console.WriteLine(); // Printing an Empty Line for neatness

            Console.WriteLine("The Sorted Array is: "); // Print Statement

            // For LOOP

            string sortedString = ""; // Creating a string variable called sortedString

            for (int k = 0; k < size; k++) 
            {
                sortedString = (sortedString +  inputArray[k] + ", "); // sorting the array in one variable called sortedString
            }

            Console.WriteLine(); // Printing an Empty Line for neatness

            Console.WriteLine(sortedString); // Prints the sorted array in a horizontal line

            Console.ReadLine(); // End of Program
        }

    }
}
