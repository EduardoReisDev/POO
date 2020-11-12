using System;
namespace Abstracao
{
    public class PessoaFisica : Padrao
    {
        //metodo obrigatorio
        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine("Taxa de empréstimo para Pessoa Física R$ " + (valor * 0.1));
        }

        public PessoaFisica()
        {

        }
    }
}
