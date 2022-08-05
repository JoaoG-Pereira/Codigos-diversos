using System;

	class Palindromo
	{
		static void Main(string[] args)
		{
			//Números de 4 dígitos
			int num1;
			int num2;

			//Maior palíndromo encontrado
			long maior = 0;

			string resultado;
			string contDigitos; //Número de dígitos do resultado

			for (num1 = 9999; num1 > 1000; num1--)
			{
				for (num2 = 9999; num2 > 1000; num2--)
				{
					resultado = (num1 * num2).ToString;

					//Verifica se o número é um palíndromo
					contDigitos = resultado.Length;
					if (contDigitos % 2 != 0) contDigitos++;

					if (resultado.Substring(0, contDigitos) == resultado.Substring(resultado.Length - contDigitos)) {
						Console.WriteLine(resultado);
					}
				}
			}


		}
	}