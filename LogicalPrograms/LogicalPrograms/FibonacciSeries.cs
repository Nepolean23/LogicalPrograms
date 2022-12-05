using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public static void Fibonacci()
        {

            int val1 = 0;int val2 = 1; int val3;
            Console.WriteLine("Enter a number for fibonacci series");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("0+1");
            for (int i=2;i<=num;i++)
            { 
                val3 = val1 + val2;   
                Console.Write("+"+val3);
                val1 = val2;
                val2 = val3;

            }
        }
    }
}
