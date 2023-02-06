using gXadrez_Console;
using Tabuleiro;

internal class Program
{
    private static void Main(string[] args)
    {
        TabuleiroDoJogo  tab = new TabuleiroDoJogo (8, 8);
        Tela.ImprimirTabuleiro(tab);
    }
}