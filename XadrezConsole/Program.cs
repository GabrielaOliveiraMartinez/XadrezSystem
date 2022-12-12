
using tabuleiro;
using XadrezConsole;
using Xadrez;

class Program
{
    static void Main(string[] args)
    {
        //try
        //{
        //    Tabuleiro t = new Tabuleiro(8, 8);

        //    t.ColocarPeca(new Torre(Cor.Preta, t), new Posicao(0, 0));
        //    t.ColocarPeca(new Torre(Cor.Preta, t), new Posicao(1, 3));
        //    t.ColocarPeca(new Rei(Cor.Preta, t), new Posicao(0, 2));


        //    Tela.ImprimirTabuleiro(t);

        //}
        //catch(TabuleiroException t) 
        //{
        //    Console.WriteLine(t.Message);   
        //}

        PosicaoXadrez px = new PosicaoXadrez('a', 1);

        Console.WriteLine(px);

        Console.WriteLine(px.toPosicao());
      

        Console.ReadLine();
    }
}