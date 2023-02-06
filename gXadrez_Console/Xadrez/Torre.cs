using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace gXadrez_Console.Xadrez
{
    internal class Torre : Peca
    {
        public Torre(TabuleiroDoJogo tab, Cor cor) : base (tab, cor) { }

        public override string ToString()
        {
            return "T";
        }
    }
}
