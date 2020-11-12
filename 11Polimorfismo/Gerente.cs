using System;
namespace Polimorfismo
{
    public class Gerente : Imposto
    {
        //metodo
        public override void valeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto gerente do vale alimentacao: " + (salario * 0.15));
        }

        public Gerente()
        {
        }
    }
}
