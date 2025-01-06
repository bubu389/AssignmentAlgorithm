//HND 1 Progrmming 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAlgorithm
{
    internal class BubbleSort
    {
        public static void BubbleSortMethod(int[] arr) { 
        
            int size = arr.Length; // size is now equal to the size of the inputted arr value length

            // Nested For Loop
            for (int i = 0; i < size; i++) {

                for (int j = 0; j < size - i - 1; j++) {

                    if (arr[j] > arr[j + 1]) { 
                        
                        // Swapping of elements in ascending order
                        int temp = arr[j+ 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;

                    }
                
                }

            }
        }
    }
}
