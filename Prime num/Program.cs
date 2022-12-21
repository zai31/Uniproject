using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2;
            
            Console.WriteLine("Inter two integers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Prime numbers are:");
            for (int i = num1; i <= num2; i++)
            {
                bool prime = true;
                int m = i / 2;
                if (i <= 1)
                {
                    prime = false;
                }
                for (int j = 2; j <= m; ++j)
                {

                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }

                }


                if (prime == true)
                {
                    Console.WriteLine(i);
                }
            }
                Console.ReadKey();
            
        }
    }
}
