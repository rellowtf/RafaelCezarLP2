using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            string data, mes;

            Console.Write("Insira a data: ");
            data = Console.ReadLine();

            dia = int.Parse(data.Substring(0, 2));

            if (dia < 10)
                mes = data.Substring(5, 3);

            else
                mes = data.Substring(6, 3);


            if (mes == "fev" || mes == "Fev")
                dia = dia + 31;
            else if (mes == "mar" || mes == "Mar")
                dia = dia + 31 + 28;
            else if (mes == "abr" || mes == "Abr")
                dia = dia + (2 * 31) + 28;
            else if (mes == "mai" || mes == "Mai")
                dia = dia + 30 + (2 * 31) + 28;
            else if (mes == "jun" || mes == "Jun")
                dia = dia + 30 + (3 * 31) + 28;
            else if (mes == "jul" || mes == "Jul")
                dia = dia + (2 * 30) + (3 * 31) + 28;
            else if (mes == "ago" || mes == "Ago")
                dia = dia + (2 * 30) + (4 * 31) + 28;
            else if (mes == "set" || mes == "Set")
                dia = dia + (2 * 30) + (5 * 31) + 28;
            else if (mes == "out" || mes == "Out")
                dia = dia + (3 * 30) + (5 * 31) + 28;
            else if (mes == "nov" || mes == "Nov")
                dia = dia + (3 * 30) + (6 * 31) + 28;
            else if (mes == "dez" || mes == "Dez")
                dia = dia + (4 * 30) + (6 * 31) + 28;

            Console.WriteLine("{0}º", dia);
        }
    }
}
