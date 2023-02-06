using gXadrez_Console;
using gXadrez_Console.Xadrez;
using Tabuleiro;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.PosicaoNaMatriz());
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}