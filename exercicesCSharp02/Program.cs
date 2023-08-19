using System;

namespace VerificarIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());



            if (idade < 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sem permissão!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Permissão concedida!");
            }

            Console.ResetColor();
    
        }
    }
}
