using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {                
                int result = 1;

                for (int i = 1; i <= number; i++)
                {
                    result = result * i;
                }

                Console.WriteLine("Result = {0}", result);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }

            Console.ReadLine();
        }
    }
}
