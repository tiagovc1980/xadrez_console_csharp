using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public TabuleiroDoJogo tab { get; protected set; }

        public Peca (TabuleiroDoJogo tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            QteMovimentos = 0;
        }

        public void IncrementarQtdadeMovimentos()
        {
            QteMovimentos++;
        }
    }
}
