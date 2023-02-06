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
                for (int j = 0; j < tab.NumeroColunas; j++)
                {
                    if (tab.PecaDoJogo(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.PecaDoJogo(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
