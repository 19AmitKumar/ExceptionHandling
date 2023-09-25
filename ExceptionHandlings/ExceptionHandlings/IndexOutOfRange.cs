using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlings
{
    internal class IndexOutOfRange
    {
        public void index()
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            try
            {
                Console.WriteLine(arr[6]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index is out of Bond");
                Console.WriteLine(e.Message);
            }


        }
    }
}
