using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace menu.Calculos
{
    class Raiz
    {
         public static void operacaoRaiz()
        {
            Console.WriteLine();
            Console.WriteLine(" Digite o número que deseja saber a raiz quadrada:");
            double valor = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            double raiz = Math.Sqrt(valor);
            Console.WriteLine($" A raiz quadrada de {valor} é {raiz.ToString("F2", CultureInfo.InvariantCulture)}");
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
