using System;
namespace Abstracao
{
    public class PessoaJuridica : Padrao
    {
        //metodo obrigatorio
        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine("Taxa de empréstimo para Pessoa Juridica R$ " + (valor * 0.2));
        }

        public PessoaJuridica()
        {
        }
    }
}
