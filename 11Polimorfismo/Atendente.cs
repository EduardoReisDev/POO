using System;
namespace Polimorfismo
{
    public class Atendente : Imposto
    {
        public override void valeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto atendente do vale alimentacao: " + (salario * 0.12));
        }

        public Atendente()
        {
        }
    }
}
