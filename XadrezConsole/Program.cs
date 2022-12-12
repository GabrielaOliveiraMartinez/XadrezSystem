
using tabuleiro;
using XadrezConsole;
using Xadrez;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro t = new Tabuleiro(8, 8);
        
        t.ColocarPeca(new Torre(Cor.Preta, t), new Posicao(0,0));
        t.ColocarPeca(new Torre(Cor.Preta, t), new Posicao(1, 3));
        t.ColocarPeca(new Rei(Cor.Preta , t), new Posicao(2,4));


        Tela.ImprimirTabuleiro(t);

        Console.ReadLine();
    }
}