using System;
using System.Collections.Generic;

namespace menu
{
    class Program
    {
        public const int SAIDA = 1;
        public const int OPERACAO_MEDIA = 2;
        public const int ADICAO = 3;

        public static void menu()
        {
            while (true)
            {
                Console.WriteLine(" Digite o número 1 para sair do programa:\n" +
                    " Digite o número 2 para fazer Média de notas:\n" +
                    " Digite o número 3 para fazer adição:\n");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (SAIDA == opcao)
                {
                    break;
                }
                else if (OPERACAO_MEDIA == opcao)
                {
                    media();
                }
                else if (ADICAO == opcao)
                {
                    adicao();
                }
                
            }
        }
        public static void media()
        {
            Console.WriteLine(" Digite o nome do aluno:");
            string nome = Console.ReadLine();
            Console.WriteLine();
            int totalnotas = 0, nota =0;
            List<int> notas = new List<int>();
            for (int i = 1; i <=3; i++)
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

        public static void adicao()
        {
            Console.WriteLine(" Quantas números deseja somar ?:");
            double repeticao = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double total =0;
            List<double> nums = new List<double>();
            for(double i =1; i<=repeticao; i++)
            {
                Console.WriteLine($"digite o {i}º número:");
                double numeros = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                total += numeros;
                nums.Add(numeros);
            }
            Console.WriteLine($" Sua soma deu {total}");
            Console.WriteLine();
            foreach (double numeros in nums)
            {
                Console.WriteLine($" Os numeros somado é {numeros}");
            }
            Console.WriteLine();
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
            static void Main(string[] args)
            {
                menu();
            }
        
    }
}
