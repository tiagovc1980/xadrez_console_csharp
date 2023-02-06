using gXadrez_Console;
using gXadrez_Console.Xadrez;
using Tabuleiro;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            PartidaDeXadrez partidaDeXadrez = new PartidaDeXadrez();

            while (!partidaDeXadrez.PartidaTerminada)
            {
                try
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partidaDeXadrez.Tab);
                    Console.WriteLine();
                    Console.WriteLine("Turno: " + partidaDeXadrez.Turno);
                    Console.WriteLine("Aguardando jogada: " + partidaDeXadrez.JogadorAtual);


                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().PosicaoNaMatriz();
                    partidaDeXadrez.ValidarPosicaoOrigem(origem);

                    bool[,] PosicoesPossiveis = partidaDeXadrez.Tab.PecaDoJogo(origem).MovimentosPossiveis();

                    Console.Clear();
                    Tela.ImprimirTabuleiro(partidaDeXadrez.Tab, PosicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().PosicaoNaMatriz();
                    partidaDeXadrez.ValidarPosicaoDestino(origem, destino);

                    partidaDeXadrez.RealizaJogada(origem, destino);
                }
                catch (TabuleiroException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }

            }
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}