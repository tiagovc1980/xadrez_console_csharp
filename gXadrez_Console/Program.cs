using gXadrez_Console;
using gXadrez_Console.Xadrez;
using Tabuleiro;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            TabuleiroDoJogo tab = new TabuleiroDoJogo(8, 8);

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(tab);
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}