using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace centro_pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 4) //!= diferente
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine(@"
██████╗░░█████╗░██╗░░██╗███████╗███╗░░░███╗░█████╗░███╗░░██╗
██╔══██╗██╔══██╗██║░██╔╝██╔════╝████╗░████║██╔══██╗████╗░██║
██████╔╝██║░░██║█████═╝░█████╗░░██╔████╔██║██║░░██║██╔██╗██║
██╔═══╝░██║░░██║██╔═██╗░██╔══╝░░██║╚██╔╝██║██║░░██║██║╚████║
██║░░░░░╚█████╔╝██║░╚██╗███████╗██║░╚═╝░██║╚█████╔╝██║░╚███║
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚══╝");
                Console.ResetColor();
                Console.WriteLine("\n Seja bem vindo ao centro Pokemon!");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n 1- Cadastrar pokemon");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n 2- Consultar pokemon");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n 3- Apagar pokemon");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n 4- sair ");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        break;






                    case 2:
                        break;






                    case 3:
                        break;







                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Tchau brigado :)");
                        System.Threading.Thread.Sleep(2000);
                        Console.ResetColor();

                        break;



                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Opção invalida!!!!");
                        Console.ResetColor();
                        System.Threading.Thread.Sleep(2000); // espera 2 seg
                       
                        break;
                }



            }
        }
    }
}