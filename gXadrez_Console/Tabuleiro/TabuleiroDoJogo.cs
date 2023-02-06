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

        public Peca PecaDoJogo (Posicao pos)
        {
            return MatrizPecas[pos.Linha, pos.Coluna];
        }

        public bool ExistePeca (Posicao pos)
        {
            ValidarPosicao(pos);
            return PecaDoJogo(pos) != null;
        }

        public void ColocarPeca (Peca p, Posicao pos)
        {
            if (ExistePeca (pos))
            {
                throw new TabuleiroException("Já existe uma peça nesta posição!");
            }
            MatrizPecas[pos.Linha, pos.Coluna] = p;
            p.posicao = pos;
        }

        public Peca RetirarPeca(Posicao pos)
        {
            if (PecaDoJogo(pos) == null)
            {
                return null;
            }
            else
            {
                Peca aux = PecaDoJogo(pos);
                aux.posicao = null;
                MatrizPecas[pos.Linha, pos.Coluna] = null;
                return aux;
            }
        }

        public bool PosicaoValida (Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= NumeroLinhas || pos.Coluna < 0 || pos.Coluna >= NumeroColunas)
            {
                return false;
            }
            return true;
        }

        public void ValidarPosicao (Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida");
            }
        }
    }
}
