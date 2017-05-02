using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string modelo, classifRodagem, classifPotencia;
            double km, potencia;
            
            Console.WriteLine("Qual o modelo do veículo?");
            modelo = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Qual a potência do veículo?");
            potencia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual a quilometragem do veículo?");
            km = Convert.ToDouble(Console.ReadLine());

            if (km <= 5000)
                classifRodagem = "Novo";
            else if (km <= 30000)
                classifRodagem = "Seminovo";
            else
                classifRodagem = "Velho";

            if (potencia < 120)
                classifPotencia = "Popular";
            else if (potencia <= 200)
                classifPotencia = "Forte";
            else
                classifPotencia = "Potente";

            Console.WriteLine("{0} - {1} - {2}", modelo, classifRodagem, classifPotencia);
        }
    }
}