using System;
namespace IMC
{
    public class Pessoa
    {

        public double imc, peso, altura;
        public string msg;

        public double calculo()
        { 
            imc = peso/(altura * altura);

            return imc;
        }

        public string situacao(double calculo)
        {
            if(imc < 18.5)
            {
                msg = "Abaixo do peso";
            }

            else if(imc < 25)
            {
                msg = "Peso normal";
            }

            else if(imc < 30)
            {
                msg = "acima do peso";
            }

            else if(imc < 35)
            {
                msg = "obesidade 1";
            }

            else if(imc < 40)
            {
                msg = "obesidade 2";
            }

            else
            {
                msg = "obesidade 3";
            }

            return msg;
        }

        public void mensagem()
        {
            //oberter media
            double obterMedia = calculo();

            //obter situacao
            string obterIMC = situacao(obterMedia);

            Console.WriteLine("O seu IMC Eh:" + obterIMC + "("+ obterMedia+")");
        }
    }
}
