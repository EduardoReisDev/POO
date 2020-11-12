using System;
namespace Construtor
{
    public class Pessoa
    {
        public Pessoa()
        {
            Console.WriteLine("Construtor executado");
        }

        public Pessoa(string nome)
        {
            Console.WriteLine("Ola" + nome);
        }
    }
}
