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
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
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

        public void RealizaJogada (Posicao origem, Posicao destino)
        {
            ExecutaMovimento(origem, destino);
            Turno++;
            MudaJogador();

        }

        public void ValidarPosicaoOrigem (Posicao pos)
        {
            if (Tab.PecaDoJogo(pos) == null)
            {
                throw new TabuleiroException("Não existe peça na posição de origem escolhida");
            }
            if (JogadorAtual != Tab.PecaDoJogo(pos).cor)
            {
                throw new TabuleiroException("A peça de origem escolhida não é sua");
            }
            if (Tab.PecaDoJogo(pos).ExistemMovimentosPossiveis() == false)
            {
                throw new TabuleiroException("Não existem jogadas possíveis para a peça escolhida");
            }
        }

        public void ValidarPosicaoDestino (Posicao origem, Posicao destino)
        {
            if (Tab.PecaDoJogo(origem).PodeMoverPara(destino) == false)
            {
                throw new TabuleiroException("Posição de destino inválida");
            }
        }

        private void MudaJogador()
        {
            if(JogadorAtual == Cor.Branca)
            {
                JogadorAtual = Cor.Preta;
            }
            else
            {
                JogadorAtual = Cor.Branca;
            }
        }

        private void ColocarPecas()
        {
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('a', 1).PosicaoNaMatriz());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('h', 1).PosicaoNaMatriz());
            Tab.ColocarPeca(new Rei(Tab, Cor.Branca), new PosicaoXadrez('e', 1).PosicaoNaMatriz());

            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('a', 8).PosicaoNaMatriz());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('h', 8).PosicaoNaMatriz());
            Tab.ColocarPeca(new Rei(Tab, Cor.Preta), new PosicaoXadrez('e', 8).PosicaoNaMatriz());
        }


    }
}
