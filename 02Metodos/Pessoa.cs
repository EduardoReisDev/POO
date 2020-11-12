using System;

namespace Metodos
{
    class Pessoa
    {
        //Método 01
        public void apresentar()
        {
            Console.WriteLine("Olah");
        }

        //Método 02
        public void apresentar(string nome)
        {
            Console.WriteLine("Olah " + nome);
        }

        //Método 03
        public void apresentar(string nome, int idade)
        {
            Console.WriteLine("Olah " + nome + ", sua idade eh " + idade);
        }
    }
}
