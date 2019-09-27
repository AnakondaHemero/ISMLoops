using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите А");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите N");
            int N = int.Parse(Console.ReadLine());
            int n = 1;
            for(double S = 1.0; n<=N; n++)
            {
                S = Math.Pow(A, n);
                Console.WriteLine("S = {0}", S);
            }
        }
    }
}
