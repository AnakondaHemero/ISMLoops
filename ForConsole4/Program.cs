using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите А");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите B");
            int B = int.Parse(Console.ReadLine());
            if (A < B)
            {
                for (int S = 0; A <= B; A++)
                {
                    S = A*A+B*B;
                    Console.WriteLine("S = {0}", S);
                }

            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}
