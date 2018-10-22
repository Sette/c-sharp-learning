using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat;
            int n =2;
            mat = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                string[] linha = Console.ReadLine().Split(" ");

                for (int j = 0; j < n; j++)
                {
                    mat [i,j] = int.Parse(linha[j]);
                }
            }

            Console.ReadLine();

            Console.WriteLine("Matriz : ------------");
            Console.WriteLine(mat);
        }
    }
}
