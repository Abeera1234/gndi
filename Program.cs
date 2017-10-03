using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int num = 2;
            Console.WriteLine("---- First 10 Prime Number ----");

            while (count != 10)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine("Prime : " + num);
                    count++;
                }
                num++;
            }
            Console.ReadKey();
        }
    }

}
   
