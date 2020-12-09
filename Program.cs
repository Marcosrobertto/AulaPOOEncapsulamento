using System;
using Encapsulamento.Classes;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();
            m.NomeTitular = "Marcos Roberto";
            m.Numero = "123456778"; // Aqui foi utilizado o set
            m.Bandeira = "MasterCard";
            m.Cvv = "544";
            
            Console.WriteLine($"O titular: {m.NomeTitular}");
            Console.WriteLine($"Possuí o token: {m.Token}");
            Console.WriteLine($"Possuí a bandeira: {m.Bandeira}");
            Console.WriteLine($"Número: {m.Numero}");
            Console.WriteLine($"CVV: {m.Cvv}");
            Console.WriteLine($"Limite: {m.Limite}");
            
        }
    }
}
