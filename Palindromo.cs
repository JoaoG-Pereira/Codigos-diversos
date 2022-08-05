//Linguagem: C#

using System;

namespace Palindromo
{
    class Palindromo
    {
        static void Main(string[] args)
        {
            //Números de 4 dígitos
            int num1;
            int num2;

            long resultado;
            long maior = 0; //Maior palíndromo

            for (num1 = 9999; num1 > 999; num1--)
            {
                for (num2 = 9999; num2 > 999; num2--)
                {
                    resultado = num1 * num2;

                    if (palindromo(resultado))
                    {
                        //Novo maior encontrado
                        if (resultado > maior)
                        {
                            maior = resultado;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("Maior palíndromo: " + maior.ToString());
        }

        //Verifica se é um palíndromo
        private static bool palindromo(long num)
        {
            string numStr = num.ToString();
            int digito; //Percorre cada caractere do número

            //Compara caracteres em posições opostas
            for (digito = 0; digito < numStr.Length; digito++)
            {
                //Caracteres diferentes encontrados
                if (numStr[digito] != numStr[(numStr.Length - digito) - 1])
                {
                    return false;
                }
            }

            //Nenhum caractere diferente
            return true;
        }
    }
}
