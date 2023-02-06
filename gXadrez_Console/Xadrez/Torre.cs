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

        private bool PodeMover(Posicao pos)
        {
            Peca p = tab.PecaDoJogo(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[tab.NumeroLinhas, tab.NumeroColunas];
            Posicao pos = new Posicao(0, 0);

            //acima
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna);

            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.PecaDoJogo(pos) != null && tab.PecaDoJogo(pos).cor != cor)
                {
                    break;
                }
                pos.Linha = pos.Linha - 1;
            }
            //abaixo
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna);

            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.PecaDoJogo(pos) != null && tab.PecaDoJogo(pos).cor != cor)
                {
                    break;
                }
                pos.Linha = pos.Linha + 1;
            }

            //direita
            pos.DefinirValores(posicao.Linha, posicao.Coluna + 1);

            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.PecaDoJogo(pos) != null && tab.PecaDoJogo(pos).cor != cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna + 1;
            }

            //esquerda
            pos.DefinirValores(posicao.Linha, posicao.Coluna - 1);

            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.PecaDoJogo(pos) != null && tab.PecaDoJogo(pos).cor != cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna - 1;
            }


            return mat;
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
