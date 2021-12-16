using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class Media
    {
        public static void operacaoMedia()
        {
            Console.WriteLine();
            Console.WriteLine(" Digite o nome do aluno:");
            string nome = Console.ReadLine();
            Console.WriteLine();
            int totalnotas = 0, nota = 0;
            List<int> notas = new List<int>();
            for (int i = 1; i <= 3; i++)
            {
                do
                {
                    Console.WriteLine($" Digite a {i}º nota do aluno de (0 á 10):");
                    nota = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    totalnotas += nota;
                    notas.Add(nota);
                } while (nota > 10);
            }
            int media = totalnotas / notas.Count;
            Console.WriteLine($" A média do aluno {nome} é de {media}:\n ");
            Console.WriteLine(" digite o 4 para limpar e fazer outra operação:");
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
