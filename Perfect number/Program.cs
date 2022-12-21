using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Please enter two integers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            for (int i = num1; i <= num2; i++)
            { 
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                   
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                    if (sum==i)
                    {
                        Console.WriteLine(i);
                    }
                }
       
            Console.ReadKey();
        }
    }
}

