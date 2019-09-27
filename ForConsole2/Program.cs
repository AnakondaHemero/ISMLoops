using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int N = int.Parse(Console.ReadLine());
            int n = 1;
            
            for(double S=0; n<=N; n++)
            {
                S = 1.0 / n;
                Console.WriteLine("S = {0}", S);
            }
        }
    }
}
