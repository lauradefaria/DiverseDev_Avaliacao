/******************************************************************************

                            Avaliação DiverseDev
                                  Questão 2

*******************************************************************************/

using System;
namespace Questao2
{
    class Program{
        static void Main(){
          
            try
            {
                //Recebe os dois valores inteiros
                Console.Write("Digite o primeiro número (N1): ");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o segundo número (N2): ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                int multiplicacao = 0;
                int divisao = 0;

                //Se os sinais forem diferentes (positivo e negativo), o resultado será negativo, do contrário é positivo
                int sinal = (n1 < 0) ^ (n2 < 0) ? -1 : 1;

                // Cálculo da multiplicação
                for (int i = 0; i < Math.Abs(n2); i++)
                {
                    multiplicacao += Math.Abs(n1);
                }

                multiplicacao *= sinal;        //Multiplica por 1 ou -1
                Console.WriteLine("Multiplicação: " + multiplicacao);
                
                //Se o divisor (N2) for igual a zero
                if (n2 == 0)
                {
                    Console.WriteLine("Erro: Divisão por zero.");
                }
                else
                {
                    // Cálculo da divisão inteira
                    n1 = Math.Abs(n1);
                    n2 = Math.Abs(n2);

                    while (n1 >= n2)
                    {
                        n1 -= n2;
                        divisao++;
                    }

                    divisao *= sinal;          //Multiplica por 1 ou -1
                    Console.WriteLine("Divisão Inteira: " + divisao);
                }
            }
            catch (FormatException)           //Caso o número não seja um inteiro
            {
                Console.WriteLine("Por favor, digite números inteiros válidos.");
            }
            catch (OverflowException)         //Caso o valor esteja fora do alcance numérico suportado pelo tipo de dado
            {
                Console.WriteLine("Os números inseridos são muito grandes para serem processados.");
            }
        }
    }
}       

