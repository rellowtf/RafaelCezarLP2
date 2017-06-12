using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        struct carro
        {
            public int pot;
            public int numero;
            public string nome;
            public double km;
        }
        static void Main(string[] args)
        {
            carro veiculo;
            int i;

            Console.WriteLine("Informe a quantidade de carros");
            veiculo.numero = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < veiculo.numero; i++)
            {
                Console.WriteLine("Informe o nome do carro");
                veiculo.nome = Console.ReadLine();

                Console.WriteLine("Informe a quilometragem do carro");
                veiculo.km = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a potencia do carro");
                veiculo.pot = int.Parse(Console.ReadLine());

                Console.WriteLine(Classificar(veiculo.nome, veiculo.km, veiculo.pot));

            }
        }

        public static string Classificar(string modelo, double km, int potencia)
        {
            string T, P;

            if (km <= 5000)
                T = "novo";

            else if (km <= 30000)
                T = "seminovo";

            else
                T = "velho";

            if (potencia < 120)
                P = "popular";

            else if (potencia <= 200)
                P = "forte";

            else
                P = "potente";

            return String.Format("{0} - {1} - {2}", modelo, T, P);

        }

    }
}
