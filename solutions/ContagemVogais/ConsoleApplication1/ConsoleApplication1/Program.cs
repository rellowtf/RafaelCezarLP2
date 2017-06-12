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
            string s;
            char posição;
            int i, vogal = 0;

            Console.WriteLine("digita ai");
            s = Console.ReadLine();

            for(i = 0; i < s.Length; i++)
            {
                posição = s[i];
                if (posição == 'a' || posição == 'A')
                    vogal++;
                else if (posição == 'e' || posição == 'E')
                    vogal++;
                else if (posição == 'i' || posição == 'I')
                    vogal++;
                else if (posição == 'o' || posição == 'O')
                    vogal++;
                else if (posição == 'u' || posição == 'U')
                    vogal++;
            }
            Console.WriteLine("são {0} vogais", vogal);
        }
    }
}
