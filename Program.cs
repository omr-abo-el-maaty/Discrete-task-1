using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_if_the_number_is_prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("write the first number : ");
            int f = int.Parse(Console.ReadLine());
            Console.Write("write the second number :");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("the prime numbers : ");
            for  (; f <= s; f++)
            {
                if (f < 2) continue;
                bool x = true;
                for (int n = 2 ; n <f; n++)
                {
                    if (f%n==0)
                    {
                       x= false;
                        break;
                    }
                }
                if (x==false)
                {
                    continue;
                }
               Console.WriteLine(f);
            }
            Console.ReadKey();

        }
    }
}
