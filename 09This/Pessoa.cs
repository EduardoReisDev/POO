using System;
namespace This
{
    public class Pessoa
    {

        //atributo
        private string nome = "Tatiana";

        //construtor
        public Pessoa(string nome)
        {
            Console.WriteLine(nome);
            Console.WriteLine(this.nome);
        }
    }
}
