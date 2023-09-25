using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlings
{
    internal class FileNotException
    {
        public void FileNot() 
        {
            //var file = "Amit.txt";
            //var text = File.ReadAllText(file);
            //Console.WriteLine(text);
            var file = "Amit.txt";
            try
            {
                
                var text = File.ReadAllText(file);
                Console.WriteLine(text);

            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
