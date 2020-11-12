using System;
namespace Polimorfismo
{
    public class Imposto
    {

        //metodos
        public virtual void valeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto padrão do vale alimentacao: " + (salario * 0.1));
        }

        public void valeTransporte(double salario)
        {
            Console.WriteLine("Desconto padrão do vale transporte: " + (salario * 0.06));
        }

        public Imposto()
        {
        }
    }
}
