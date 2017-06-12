using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double t1, t2, t3;
            string nome;
            int n, i;

            Console.WriteLine("informe o numero de competidores");
            n = int.Parse(Console.ReadLine());

            Competidor[] competidores = new Competidor[n];

            for(i=0; i <= n; i++)
            {
                Competidor corredor = new Competidor();
                Console.WriteLine("informe o nome");
                nome = Console.ReadLine();

                Console.WriteLine("informe o t1");
                t1 = int.Parse(Console.ReadLine());

                Console.WriteLine("informe o t2");
                t2 = int.Parse(Console.ReadLine());

                Console.WriteLine("informe o t3");
                t3 = int.Parse(Console.ReadLine());

                competidores[i] = corredor;
            }


        }
    }
}
