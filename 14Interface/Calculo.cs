using System;
namespace Interface
{
    public class Calculo :IPadrao
    {
        public Calculo()
        {
        }

        public void somar(int n1, int n2)
        {
            Console.WriteLine("A soma é " + (n1 + n2));
        }

        public void subtrair(int n1, int n2)
        {
            Console.WriteLine("A subtracao é " + (n1 - n2));
        }
    }
}
