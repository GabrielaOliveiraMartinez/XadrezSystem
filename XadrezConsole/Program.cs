
using tabuleiro;
using XadrezConsole;
using Xadrez;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            PartidaDeXadrez partidaDeXadrez = new PartidaDeXadrez();

            while (!partidaDeXadrez.terminada)
            {
                Console.Clear();

                Tela.ImprimirTabuleiro(partidaDeXadrez.tab);

                Console.WriteLine();

                Console.WriteLine("Origem: ");
                Posicao origem = Tela.lerPosicaoXadrez().toPosicao();



                Console.WriteLine("Destino: ");
                Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                partidaDeXadrez.ExecutaMovimento(origem, destino);
            }
           

        }
        catch (TabuleiroException t)
        {
            Console.WriteLine(t.Message);
        }

        //PosicaoXadrez px = new PosicaoXadrez('a', 1);

        //Console.WriteLine(px);

        //Console.WriteLine(px.toPosicao());


        Console.ReadLine();
    }
}