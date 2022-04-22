using System;

namespace ARRAYS_Matrizes_CSharp_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] nome = new string[2, 2];

            for(int linha = 0; linha < 2; linha++)
            {
                for(int coluna = 0; coluna < 2; coluna++)
                {
                    nome[linha, coluna] = Console.ReadLine();
                }
            }

            Console.WriteLine();

            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.WriteLine(nome[linha, coluna] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
