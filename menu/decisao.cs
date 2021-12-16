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
        public static void menu()
        {
            while (true)
            {
                Console.WriteLine(" Digite o número 1 para sair do programa:\n" +
                    " Digite o número 2 para fazer Média de notas:\n" +
                    " Digite o número 3 para fazer uma adição:\n" +
                    " Digite o número 4 para fazer uma subtração:\n");
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
                }else if (SUBTRACAO == opcao)
                {
                    Subtracao.operacaoSubtracao();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
