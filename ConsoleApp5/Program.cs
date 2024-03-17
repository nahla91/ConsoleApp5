using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static int DeciemalToOCTAL (int d)
        {
            if (d == 0)
            {
                return 0;

            }
            else 
                return(d%2+10*DeciemalToOCTAL (d/2));


        }



        static void Main(string[] args)
        {
            int d = 22;
            Console.WriteLine(DeciemalToOCTAL(d));
            Console.ReadKey();
        }
    }
}
