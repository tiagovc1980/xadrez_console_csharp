using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuleiro
{
    internal class TabuleiroDoJogo
    {
        public int NumeroLinhas { get; set; }
        public int NumeroColunas { get; set; }
        private Peca[,] MatrizPecas { get; set; }

        public TabuleiroDoJogo (int numeroLinhas, int numeroColunas)
        {
            NumeroLinhas = numeroLinhas;
            NumeroColunas = numeroColunas;
            MatrizPecas = new Peca[numeroLinhas, numeroColunas];
        }

        public Peca PecaDoJogo (int linha, int coluna)
        {
            return MatrizPecas[linha, coluna];
        }
    }
}
