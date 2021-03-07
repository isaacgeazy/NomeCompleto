using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, sobrenm;

            Console.Write("Seu nome: ");
            nome = Convert.ToString(Console.ReadLine());
            Console.Write("Seu sobrenome: ");
            sobrenm = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Nome Completo: {nome} {sobrenm}");
            Console.WriteLine($"Nome de Catálogo: {sobrenm.ToUpper()}, {nome}");
     
        }
    }
}
