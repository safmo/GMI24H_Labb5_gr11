using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMI24H_Labb5_gr11
{ /// <summary>
  /// This class is used to implement the algorithms defined in the ISorter interface.
  /// When you have implemented the algorithms, you should be able to test them by instantiating
  /// a Sorter object and call the methods.
  /// </summary>
    class Sorter : Isort
    {
        private Isort _sorterImplementation;

        public int[] BubbleSort(int[] arr)
        {
            //Replace the following code snippet with your implementation
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }

            return arr;
        }





        public int[] SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int position = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[position])
                        position = j;
                (arr[i], arr[position]) = (arr[position], arr[i]);
            }

            return arr;
        }

        public void HeapSort(int[] arr)
        {
            BuildHeap(arr); // Build the initial heap

            for (int i = arr.Length - 1; i > 0; i--)
            {
                Swap(arr, 0, i); // Swap the root (largest element) with the last element
                Heapify(arr, i, 0); // Restore heap property after swapping
            }
        }

        private void BuildHeap(int[] arr)
        {
            // Start from the last non-leaf node and perform heapify operation
            // to ensure that every subtree rooted at i is a max heap
            for (int i = arr.Length / 2 - 1; i >= 0; i--)
                Heapify(arr, arr.Length, i);
        }

        private void Heapify(int[] arr, int n, int i)
        {
            int largest = i; // Assume the current element is the largest
            int left = 2 * i + 1; // Calculate the left child index
            int right = 2 * i + 2; // Calculate the right child index

            // Check if the left child is larger than the current largest element
            if (left < n && arr[left] > arr[largest])
                largest = left;

            // Check if the right child is larger than the current largest element
            if (right < n && arr[right] > arr[largest])
                largest = right;

            // If the largest element is not the current element,
            // swap them and recursively heapify the affected subtree
            if (largest != i)
            {
                Swap(arr, i, largest);
                Heapify(arr, n, largest);
            }
        }
        
        public int[] InsertionSort(int[] arr)
        {
            //Replace the following code snippet with your implementation
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;

            }

            return new int[] { };
        }
        
        public void QuickSort(int[] arr, int low, int high)
        {
            // Recursive function to sort the array using QuickSort algorithm

            if (low < high)
            {
                // Partition the array and get the pivot index
                int pivotIndex = Partition(arr, low, high);

                // Recursively sort the left partition
                QuickSort(arr, low, pivotIndex - 1);

                // Recursively sort the right partition
                QuickSort(arr, pivotIndex + 1, high);
            }
        }

        private int Partition(int[] arr, int low, int high)
        {
            // Helper function to partition the array and return the pivot index

            // Choose the pivot element (last element in the array)
            int pivot = arr[high];

            // Initialize the index of the smaller element
            int i = low - 1;

            // Iterate through the array
            for (int j = low; j < high; j++)
            {
                // If the current element is smaller than the pivot
                if (arr[j] < pivot)
                {
                    // Increment the index of the smaller element
                    i++;

                    // Swap the current element with the element at the smaller index
                    Swap(arr, i, j);
                }
            }

            // Swap the pivot element with the element next to the smaller index
            Swap(arr, i + 1, high);

            // Return the pivot index
            return i + 1;
        }

        private void Swap(int[] arr, int i, int j)
        {
            // Helper function to swap two elements in the array

            (arr[i], arr[j]) = (arr[j], arr[i]);
        }


        public void Display(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }


        
    }

    
}

