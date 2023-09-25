using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlings
{
    internal class ArrayMisMatchException
    {
        public void ArrayMismatch()
        {
            string[] ar = { "Amit", "Kumar" };
            int[] arr = { 1, 2 };
            try
            {
                Array.Copy(ar, arr, 2);
            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine("ArrayMismatchException");
                Console.WriteLine(ex.Message);
            }

        }
    }
}
