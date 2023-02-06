using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace gXadrez_Console.Xadrez
{
    internal class PosicaoXadrez
    {
        public char LetraNaColuna { get; set; }
        public int NumeroNaLinha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            LetraNaColuna= coluna;
            NumeroNaLinha= linha;
        }

        public Posicao PosicaoNaMatriz ()
        {
            return new Posicao(8 - NumeroNaLinha, LetraNaColuna - 'a');
        }

        public override string ToString()
        {
            return "" + LetraNaColuna + NumeroNaLinha;
        }
    }
}
