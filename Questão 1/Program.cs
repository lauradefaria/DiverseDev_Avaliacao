/******************************************************************************

                            Avaliação DiverseDev
                                  Questão 1

*******************************************************************************/

using System;
namespace Questao1
{
    class Program{
        static void Main(){
          
          //Variáveis para quantidade que será descoberta
          int pares = 0, impares = 0, positivos = 0, negativos = 0, neutros = 0;
          
          //Recebe e identifica os 5 valores
           for (int i = 0; i < 5; i++)
          {
            try
            {
                Console.Write($"Digite o {i + 1}º valor: ");
                int valor = Convert.ToInt32(Console.ReadLine());

                //Se o resto da divisão por dois é zero -> Par
                if (valor % 2 == 0)
                    pares++;
                //Se o resto da divisão por dois não é zero -> Impar
                else if (valor % 2 != 0)
                    impares++;

                //Se maior que zero -> Positivo
                if (valor > 0)
                    positivos++;
                //Se menor que zero -> Negativo
                else if (valor < 0)
                    negativos++;
            }
            catch (FormatException) //Caso o número não seja um inteiro
            {
                Console.WriteLine("Por favor, digite um valor inteiro válido.");
                i--;                // Para repetir a leitura do valor inválido.
            }
        }

        //Zero é neutro, então seriam os números que sobraram dos 5 recebidos
        neutros = 5 - (pares+impares);

        //Imprimir resultados
        Console.WriteLine("Quantidade de valores pares: " + pares);
        Console.WriteLine("Quantidade de valores ímpares: " + impares);
        Console.WriteLine("Quantidade de valores positivos: " + positivos);
        Console.WriteLine("Quantidade de valores negativos: " + negativos);
        //Console.WriteLine("Quantidade de valores iguais a zero (neutros): " + neutros);
    }
  }
}

