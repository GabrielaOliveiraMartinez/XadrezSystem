using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace Xadrez
{
    public class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tabuleiro) : base(tabuleiro,cor)
        {
        }

        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tabuleiro.peca(pos);

            return p != null || p.cor != cor;

        }
        public override bool[,] MovimentosPossiveis()
        {
            bool[,] m = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao pos = new Posicao(0, 0);

            //Norte
            pos.definirValores(pos.Linha - 1, pos.Coluna);

            if (tabuleiro.posicaoValida(pos)&& podeMover(pos))
            {
                m[pos.Linha, pos.Coluna] = true;
            }

            //Nordeste
            pos.definirValores(pos.Linha - 1, pos.Coluna + 1);

            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                m[pos.Linha, pos.Coluna] = true;
            }

            //Leste
            pos.definirValores(pos.Linha, pos.Coluna + 1);

            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                m[pos.Linha, pos.Coluna] = true;
            }

            //Sudeste
            pos.definirValores(pos.Linha + 1, pos.Coluna + 1);

            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                m[pos.Linha, pos.Coluna] = true;
            }

            //Sul
            pos.definirValores(pos.Linha + 1, pos.Coluna );

            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                m[pos.Linha, pos.Coluna] = true;
            }

            //Sudoeste
            pos.definirValores(pos.Linha + 1, pos.Coluna - 1);

            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                m[pos.Linha, pos.Coluna] = true;
            }

            //Oeste
            pos.definirValores(pos.Linha, pos.Coluna - 1);

            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                m[pos.Linha, pos.Coluna] = true;
            }

            //Noroeste
            pos.definirValores(pos.Linha - 1, pos.Coluna - 1);

            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                m[pos.Linha, pos.Coluna] = true;
            }


            return m;
        }
    }
}
