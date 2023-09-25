using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlings
{
    internal class DivideByZeroExceptions
    {
        public void DividedByZero() 
        {
            int a = 0;
            // int b = 10 / a;
            //if (a != 0)
            // {
            //     int b = 10 / a;
            // }
            try
            {
                int b = 10 / a;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
