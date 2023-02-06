using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace gXadrez_Console.Xadrez
{
    internal class PartidaDeXadrez
    {
        public TabuleiroDoJogo Tab { get; private set; }
        private int Turno { get; set; }
        private Cor JogadorAtual { get; set; }
        public bool PartidaTerminada { get; private set; }


        public PartidaDeXadrez()
        {
            Tab = new TabuleiroDoJogo (8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            PartidaTerminada = false;
            ColocarPecas();
        }

       
        public void ExecutaMovimento (Posicao origem, Posicao destino)
        {
            Peca p = Tab.RetirarPeca (origem);
            p.IncrementarQtdadeMovimentos();
            Peca pecaCapurada = Tab.RetirarPeca(destino);
            Tab.ColocarPeca(p, destino);
        }

        private void ColocarPecas()
        {
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('a', 1).PosicaoNaMatriz());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('h', 1).PosicaoNaMatriz());


            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('a', 8).PosicaoNaMatriz());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('h', 8).PosicaoNaMatriz());
        }


    }
}
