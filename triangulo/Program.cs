using System;

namespace triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
           Produto produto;
           produto = new Produto("Celular",500.50);
           Console.WriteLine(produto);
        }
    }
}
