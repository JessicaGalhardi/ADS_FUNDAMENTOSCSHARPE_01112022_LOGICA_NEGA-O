using System;

namespace Negacao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Valores apresentados no diagnóstico de um paciente.

                string sintomasGripais = "positivo";
                int temperaturaCorporal = 40;
                string testeAntigeno = "positivo";

                //_________________________________________________________________________________________
                //Expressões lógicas para definir se um paciente deve ou não fazer quarentena!
                
                if(!(testeAntigeno=="negativo") && !(sintomasGripais== "negativo") && !(temperaturaCorporal<=37.8))
                {
                    Console.WriteLine("Este paciente precisa fazer 30 dias de quarentena!");
                }
                else
                {
                    Console.WriteLine("Este paciente não precisa quarentena!");

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao executar a aplicação!" + ex);//Em caso de erro é exibida a mensagem junto com o erro apresentado.
            }
        }
    }

}
