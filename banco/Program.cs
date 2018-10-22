using System;

namespace banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco banco;

            banco = new Banco(123,"Bruno Sette");

            banco.nome = "Bruno Silva Sette";

            Console.WriteLine(banco.getsaldo());

            banco.depositar(505.05);

            Console.WriteLine(banco.getsaldo());

            banco.sacar(500.00);

            Console.WriteLine(banco.getsaldo());




        }
    }
}
