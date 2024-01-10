using System;

namespace Aula03
{
    class Aula03{
        static void Main(string[] args)
        {
            // byte n1 = 10; // 0 e 255
            // int num = - 10; // 5 ou -5
            // char letra = 'c'; // '8'
            // float valor = 5.3f;
            // string nome = "Lika";

            // var aux = nome;

            // System.Console.WriteLine("Valor da variável: "+ aux + "...");

            int num1, num2, res;
            // int num1, num2;
            // Posso usar dessas outras formas.
            // int num1 = 0, num2 = 10;

            num1 = 10;
            num2 = 2;
            res = num1 * num2;

            System.Console.WriteLine("A multiplicação de " + num1 + " com " + num2 + " é igual a: " + res);

        }
    }
}
