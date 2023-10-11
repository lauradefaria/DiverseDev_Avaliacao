/******************************************************************************

                            Avaliação DiverseDev
                                  Questão 3

*******************************************************************************/

using System;
namespace Questao3
{
    class Program{
        static void Main(){
          
            try
            {
                //Frase digitada pelo usuário
                Console.Write("Digite uma frase: ");
                string frase = Console.ReadLine();

                if (ContemApenasLetrasEEspacos(frase))
                {
                    // Dividir a frase em palavras utilizando o método 'split'
                    string[] palavras = frase.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                    int maiusculas = 0, minusculas = 0, maiusculaInicio = 0, minusculaInicio = 0;
                    int totalPalavras = palavras.Length;

                    //Para cada palavra na string 'palavras'
                    foreach (string palavra in palavras)
                    {
                        if (palavra.Length > 0)
                        {
                            //Verifica se a primeira letra é maiuscula ou não -> Se o primeiro caractere é maiusculo/minusculo
                            if (char.IsUpper(palavra[0]))
                                maiusculaInicio++;
                            else
                                minusculaInicio++;

                            //Verifica se a palavra é completamente maiúscula ou não -> Compara a versão da palavra original com a versão toda em maiusculo/minusculo
                            if (palavra.Equals(palavra.ToLower()))
                                minusculas++;
                            else if (palavra.Equals(palavra.ToUpper()))
                                maiusculas++;
                        }
                    }

                    Console.WriteLine("Palavras maiúsculas: " + maiusculas);
                    Console.WriteLine("Palavras minúsculas: " + minusculas);
                    Console.WriteLine("Palavras iniciadas com letra maiúscula: " + maiusculaInicio);
                    Console.WriteLine("Palavras iniciadas com letra minúscula: " + minusculaInicio);
                    Console.WriteLine("Total de palavras: " + totalPalavras);
                }
                else                 //Caso não seja apenas umas string
                {
                    Console.WriteLine("Erro: A entrada não é uma frase válida.");
                }
            }
            catch (Exception)        //Caso ocorra algum erro inesperado
            {
                Console.WriteLine("Ocorreu um erro inesperado. Certifique-se de fornecer uma entrada válida.");
            }
            
        }

        static bool ContemApenasLetrasEEspacos(string texto)   //Verifica se a string contém apenas letras e espaços em branco
        {
            foreach (char c in texto)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))  //Realiza a verificação
                    return false;
            }
            return true;
        }
    }
}       
