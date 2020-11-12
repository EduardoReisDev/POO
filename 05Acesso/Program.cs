using System;

namespace Acesso
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Produto p = new Produto();
            p.nome = "computador";
            //p. não tem acesso ao valor
        }
    }
}
