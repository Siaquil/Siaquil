using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sololearn 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (i % 15 == 0)
                    Console.Write("FizzBuzz" + " ");

                else if (i % 3 == 0)
                    Console.Write("Fizz" + " ");

                else if (i % 5 == 0)
                    Console.Write("Buzz" + " ");

                else
                    Console.Write(i + " ");
            }
        }
    }
}
