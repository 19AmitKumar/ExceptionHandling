using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlings
{
    //Exception:A problem occur during the execution of aprogram is refer to as a exception
    //it allows to control to passed part of problem
    //it will prevent the crashing of a program
    internal class Program
    {
        static void Main(string[] args)
        {
            //DivideByZeroExceptions divideByZeroException = new DivideByZeroExceptions();
            //divideByZeroException.DividedByZero();

            //FileNotException f = new FileNotException();
            //f.FileNot();

            //IndexOutOfRange i=new IndexOutOfRange();
            //i.index();

            ArrayMisMatchException a=new ArrayMisMatchException();
            a.ArrayMismatch();

            Console.ReadLine();
        }
    }
}
