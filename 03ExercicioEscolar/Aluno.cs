using System;
namespace ExercicioEscolar
{
    public class Aluno
    {
        //Atributos
        public string nome;
        public double nota1, nota2;

        //metodos

        //média
        public double media()
        {
            return (nota1 + nota2) / 2;
        }

        //situação
        public string sitaucao(double media)
        {
            return media >= 7 ? "aprovado" : "reprovado";

        }

        //mensagem
        public void mensagem()
        {
            //obter media
            double obterMedia = media();

            //obter sitacao
            string obterSituacao = sitaucao(obterMedia);

            //mensagem
            Console.WriteLine(nome + " estah " + obterSituacao + " com media " + obterMedia);
        }


        public Aluno()
        {
        }
    }
}
