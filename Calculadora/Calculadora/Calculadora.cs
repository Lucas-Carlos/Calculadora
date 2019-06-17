using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    //Classe
    class Calculadora
    {
        //Atributos.
        private double numero1;
        private double numero2;

        //Encapsulação dos atributos.
        public double Numero1 { get => numero1; set => numero1 = value; }
        public double Numero2 { get => numero2; set => numero2 = value; }

        //Método Somar.
        public double Somar()
        {
            return (this.Numero1 + this.Numero2);
        }

        //Método Subtrair.
        public double Subtrair()
        {
            return (this.Numero1 - this.Numero2);
        }

        //Metodo Multiplicar.
        public double Multiplicar()
        {
            return (this.Numero1 * this.Numero2);
        }

        //Método Dividir.
        public double Dividir()
        {
            return (this.Numero1 / this.Numero2);
        }

        //Método Elevar.
        public double Elevar()
        {
            return (Math.Pow(this.Numero1, this.Numero2));
        }

        //Método de Porcentagem.
        public double Porcentagem ()
        {
            return (this.Numero1 * this.Numero2 / 100);

            /* Este método de porcentagem funciona da seguinte forma: Utilize a caixa de texto 1 (txtn1) para inserir
            a quantidade em porcentagem desejada, e a caixa de texto 2 (txtn2) para saber de qual número extrair a porcentagem.
            Exemplo:
                        txtn1           txtn2     =      txtresult
                         50              200      =         100    --> Ou seja, 50% de 200 é igual a 100.
             */
        }
    }
}