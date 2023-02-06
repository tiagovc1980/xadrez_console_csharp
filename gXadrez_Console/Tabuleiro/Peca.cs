using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuleiro
{
    internal abstract class Peca
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

        public bool ExistemMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();

            for (int i=0; i<tab.NumeroLinhas; i++)
            {
                for (int j=0; j<tab.NumeroColunas; j++)
                {
                    if (mat[i,j] == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis(); 
    }
}
