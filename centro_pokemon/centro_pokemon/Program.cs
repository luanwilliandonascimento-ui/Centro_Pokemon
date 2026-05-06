using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n Digite a opção escolhida: ");
                Console.ResetColor();

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        cadastroPokemon(); //abre a função
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
        static void cadastroPokemon()
        {
            Console.Clear(); //limpa tela
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Digite o nome do seu Pokemon");
            string nomePokemon = Console.ReadLine(); // string = textos

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n Digite o tipo do seu Pokemon");
            string tipoPokemon = Console.ReadLine(); // string = textos

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n Digite o tamanho do seu Pokemon");
            double alturaPokemon = double.Parse(Console.ReadLine()); // double = casa decimal

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n Digite o peso do seu Pokemon");
            double pesoPokemon = double.Parse(Console.ReadLine()); // double = casa decimal

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("quantas fraquezas ele tem?: ");
            int qtdFraqueza = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdFraqueza; i++)
            {
                Console.WriteLine($"Fraqueza {i} : "); // {i} coloca variavel no texto
                string fraquezaPokemon = Console.ReadLine(); // string = textos

            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("quantas evoluções ele tem?: ");
            int qtdEvolucao = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdEvolucao; i++)
            {
                Console.WriteLine($"Evolução {i} : "); // {i} coloca variavel no texto
                string evolucaoPokemon = Console.ReadLine(); // string = texto
             }

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("Parabéns!! Pokemon cadastrado com sucesso! ");
            System.Threading.Thread.Sleep(4000); // espera 3 seg
            Console.ResetColor();
















        }

    }

}
