using System;
using tabuleiro;
using xadrez;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
             try
             {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab);

                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerposicaoXadrez().ToPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerposicaoXadrez().ToPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }
                
                Tela.ImprimirTabuleiro(partida.tab);

             }
             catch(TabuleiroException e)
             {
                 Console.WriteLine(e.Message);
             }

             

           
            Console.WriteLine();
        }
    }
}
