using System;

namespace Senha_DecisaoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            string senhaSistema = "1234abcd";
            string senhaUsuario;

            Console.WriteLine("--- Senha ---\n");

            Console.WriteLine("Seja bem vindo a plataforma!");
            Console.Write("Digite a senha: ");
            senhaUsuario = Console.ReadLine().ToLower();
            
            


            if (senhaSistema != senhaUsuario)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Senha incorreta tente novamente.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Acesso validado com sucesso!!!");
            }

            Console.ResetColor();

            
        }
    }
}
