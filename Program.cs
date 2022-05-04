using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double delta;
            double raiz;

            Console.WriteLine("Digite o valor de A");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de B");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de C");
            c = Convert.ToDouble(Console.ReadLine());

            delta = b * 2 - 4 * a * c;

            raiz = Math.Sqrt(delta);

            

            if (delta < 0 )
            {
              Console.WriteLine("O programa foi encerrado pois Delta é negativo");
            }
            if (delta == 0)
            {
                Console.WriteLine("O valor de delta é: " + delta);
            }
            else if (delta > 0)
            {
                Console.WriteLine("x' = " + (-b + raiz / 2 * a));
                Console.WriteLine("x'' = " + (-b - raiz / 2 * a));
            }

        }
    }
}
