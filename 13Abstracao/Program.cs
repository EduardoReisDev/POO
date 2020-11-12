using System;

namespace Abstracao
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.taxaEmprestimo(1000);

            PessoaJuridica pj = new PessoaJuridica();
            pj.taxaEmprestimo(1000);
        }
    }
}
