using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2_1papka
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число: ");
            string kk = Console.ReadLine();
            float k = float.Parse(kk); 
            Console.WriteLine("Введите степень: ");
            string nn = Console.ReadLine();
            float n = float.Parse(nn);
            Console.WriteLine("Введите точность: ");
            string tt = Console.ReadLine();
            float t = float.Parse(tt);

            double x0 = k / n;
           double x1 = (1 / n) * ((n - 1) * x0 + k / St(x0, (int)n - 1));

            while (Math.Abs(x1 - x0) > t)
            {
                x0 = x1;
                x1 = (1 / n) * ((n - 1) * x0 + k / St(x0, (int)n - 1));
            }


            Console.WriteLine("Результат вычисления методом Ньютона: " +  "{0:##.#############}",x1);
            double x2 = Math.Pow(k, 1 / n);
            Console.WriteLine("Результат вычисления методом Math.Pow: " + "{0:##.#############}", x2);
            Console.ReadKey();
    
       
        }
        static double St(double a, int pow)
        {
            double result = 1;
            for (int i = 0; i < pow; i++) result *= a;
            return result;
        }
    }
}
