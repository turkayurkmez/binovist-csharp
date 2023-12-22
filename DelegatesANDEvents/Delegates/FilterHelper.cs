using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public static class FilterHelper
    {

        //public delegate bool Criteria(int number);
        public static int[] Filter(int[] array, Func<int, bool> criteria)
        {
            List<int> result = new List<int>();
            foreach (int number in array)
            {
                if (criteria(number))
                {
                    result.Add(number);
                }
            }
            return result.ToArray();
        }
    }
}
