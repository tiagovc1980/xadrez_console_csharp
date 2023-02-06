using gXadrez_Console.Xadrez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace gXadrez_Console
{
    internal class Tela
    {
        public static void ImprimirTabuleiro(TabuleiroDoJogo tab)
        {
            for (int i = 0; i < tab.NumeroLinhas; i++)
            {
                Console.Write(8 - i + " ");

                for (int j = 0; j < tab.NumeroColunas; j++)
                {
                    ImprimirPeca(tab.PecaDoJogo(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimirTabuleiro(TabuleiroDoJogo tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.NumeroLinhas; i++)
            {
                Console.Write(8 - i + " ");

                for (int j = 0; j < tab.NumeroColunas; j++)
                {
                    if (posicoesPossiveis[i,j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }

                    ImprimirPeca(tab.PecaDoJogo(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.BackgroundColor = fundoOriginal;
            Console.WriteLine("  a b c d e f g h");
        }


        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);

        }

        public static void ImprimirPeca(Peca p)
        {
            if (p == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (p.cor == Cor.Branca)
                {
                    Console.Write(p);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(p);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
    }
}
