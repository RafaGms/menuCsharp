using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class Adicao
    {
        public static void operacaoAdicao()
        {
            int quantnumero = 0, valores, total = 0, contador = 0;
            do
            {
                Console.WriteLine(" Quantos números voçê deseja somar?(maximo 4):");
                quantnumero = Convert.ToInt32(Console.ReadLine());
            } while (quantnumero >= 5);
            Console.WriteLine();
            List<int> Listanumeros = new List<int>();
            for (int i = 1; i <= quantnumero; i++)
            {
                Console.WriteLine($" digite o {i}º número para somar:");
                valores = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Listanumeros.Add(valores);
                contador++;

                if (contador == 2)
                {
                    total = Listanumeros[0] + Listanumeros[1];
                    Console.WriteLine($" {Listanumeros[0]} + {Listanumeros[1]} = {total}:");
                    Console.WriteLine();
                }
                else if (contador == 3)
                {
                    total = Listanumeros[0] + Listanumeros[1] + Listanumeros[2];
                    Console.WriteLine($" {Listanumeros[0]} + {Listanumeros[1]} + {Listanumeros[2]} = {total}:");
                    Console.WriteLine();
                }
                else if (contador == 4)
                {
                    total = Listanumeros[0] + Listanumeros[1] + Listanumeros[2] + Listanumeros[3];
                    Console.WriteLine($" {Listanumeros[0]} + {Listanumeros[1]} + {Listanumeros[2]} + {Listanumeros[3]} = {total}:(total da conta)");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine(" digite o 4 para fazer outra operação:");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero == 4)
            {
                Console.Clear();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
