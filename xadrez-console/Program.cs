﻿using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colcoarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colcoarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colcoarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                tab.colcoarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));


                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();


        }
    }
}
