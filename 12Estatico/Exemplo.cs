using System;
namespace Estatico
{
    public class Exemplo
    {
        //atributo estatico
        public static string nome = "Edu";

        //Metodo estatico
        public static void soma (int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }

        public Exemplo()
        {
        }
    }
}
