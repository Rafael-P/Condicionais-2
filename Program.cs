using System;

namespace Condicionais_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual sua idade ?");
            int idade = int.Parse(Console.ReadLine());

            if(idade >=18){
                Console.WriteLine("Você gostaria de participar do time de CS GO? - Sim ou Não");
                string resposta = Console.ReadLine();
                if(resposta == "Sim"){
                    Console.WriteLine("Compareça a secretaria - Falar com a SARA");
                }else{
                    Console.WriteLine("Blz! Passar bem.");
                }
            }else{
                Console.WriteLine("Você gostaria de participar do time de lol? Sim ou Não");
                string resposta = Console.ReadLine();
                if(resposta == "Sim"){
                    Console.WriteLine("Comparecer a secretaria - Falar com o Jucelino");

                }else{
                    Console.WriteLine("Muito Obrigado");
                }
            }

        }//FIM DO MAIN
    }
}
