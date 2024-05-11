using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMI24H_Labb5_gr11
{
    /// <summary>
    /// This interface is used to define which algorithms that can be implemented in the Searcher class
    /// and their parameters.
    /// </summary>
    internal interface Isearch
    {
        int LinearSearch(int[] array, int target);
        int BinarySearch(int[] array, int target);
        int JumpSearch(int[] array, int target);
    }
}
