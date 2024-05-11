using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMI24H_Labb5_gr11
{ /// <summary>
/// This interface is used to define which algorithms that can be implemented in the Sorter class
/// </summary>
    internal interface Isort
    {
        int[] BubbleSort(int[] arr);
        int[] InsertionSort(int[] arr);
        int[] SelectionSort(int[] arr);
        void HeapSort(int[] arr);
        void QuickSort(int[] arr, int low, int high);
    }
}
