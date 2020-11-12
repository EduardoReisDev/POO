using System;

namespace IMC
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Pessoa ps = new Pessoa();
            ps.altura = 1.68;
            ps.peso = 64;
            ps.mensagem();
        }
    } 
}
