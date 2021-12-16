using menu.Calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class decisao
    {
        public const int SAIDA = 1;
        public const int OPERACAO_MEDIA = 2;
        public const int ADICAO = 3;
        public const int SUBTRACAO = 4;
        public const int RAIZ = 5;
        public static void menu()
        {
            while (true)
            {
                Console.WriteLine("================Escolha sua operação digitando o número================\n");
                Console.WriteLine("| 1 = Sair do Programa | 2 = Calcular Média | 3 = Adição |\n|\n| 4 = Subtração | 5 = Raiz Quadrada |");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (SAIDA == opcao)
                {
                    Environment.Exit(0);
                }
                else if (OPERACAO_MEDIA == opcao)
                {
                    Media.operacaoMedia();
                }
                else if (ADICAO == opcao)
                {
                    Adicao.operacaoAdicao();
                }
                else if (SUBTRACAO == opcao)
                {
                    Subtracao.operacaoSubtracao();
                }
                else if (RAIZ == opcao)
                {
                    Raiz.operacaoRaiz();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
