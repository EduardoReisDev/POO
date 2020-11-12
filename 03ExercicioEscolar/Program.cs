using System;

namespace ExercicioEscolar
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //instanciar objeto da classe aluno

            Aluno a = new Aluno();
            a.nome = "Eduardo";
            a.nota1 = 4;
            a.nota2 = 6;
            a.mensagem();
        }
    }
}
