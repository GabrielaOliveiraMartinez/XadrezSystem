
using tabuleiro;
using XadrezConsole;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro t = new Tabuleiro(8, 8);

        Tela.ImprimirTabuleiro(t);

        Console.ReadLine();
    }
}