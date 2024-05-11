using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMI24H_Labb5_gr11
{ /// <summary>
  /// This class is used to implement the algorithms defined in the ISearcher interface.
  /// When you have implemented the algorithms, you should be able to test them by instantiating
  /// a Searcher object and call the methods.
  /// </summary>
    internal class Search:Isearch
    {
        public int BinarySearch(int[] array, int target)
        {
            //Replace the following code snippet with your implementation
            {
                if (array?.Any() != true)
                {
                    return -1;
                }
                int min = 0;
                int max = array.Length - 1;

                while (min <= max)
                {
                    int mid = (min + max) / 2;

                    if (array[mid] == target)
                    {
                        return mid;
                    }

                    else if (target < array[mid])
                    {
                        max = mid - 1;
                    }
                    else
                    {
                        min = mid + 1;
                    }
                }

                return -1;
            }
        }


        

        
        public int JumpSearch(int[] array, int target)
        {

            int n = array.Length;
            int blockSize = (int)MySqrt(n);

            int start = 0;
            int end = blockSize - 1;
            while (start < n && array[end] < target)
            {
                start = end + 1;
                end += blockSize;

                if (end >= n)
                    end = n - 1;
            }

            for (int i = start; i <= end; i++)
            {
                if (array[i] == target)
                    return i;
            }

            return -1;
        }

        private static int MySqrt(int x)
        {
            int guess = x / 2;
            int prevGuess;
            do
            {
                prevGuess = guess;
                guess = (prevGuess + x / prevGuess) / 2;
            } while (Abs(guess - prevGuess) >= 1);

            return guess;
        }

        private static int Abs(int x)
        {
            return x < 0 ? -x : x;
        }

        
        public int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                    return i;// Return the index of the element if found
            }

            return -1; // Element not found
        }
    }

}

