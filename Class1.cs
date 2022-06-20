using CST117_IC08_console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity10
{
    class Program
    {
        static void Main(string[] args)
        {            
            Set A = new Set();
            Set B = new Set();
            //neither Set A or Set B's namespace could be found, resulting in a compilation error. 
            //updating both initializations of the Set class too correct the error (using CST117_IC08_console;)


            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.Union(B));           
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

        }
    }
}

