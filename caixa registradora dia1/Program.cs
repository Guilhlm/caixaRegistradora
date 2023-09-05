using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caixa_registradora_dia1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu, loop, menuloop;
            menuloop = 1;
            loop = 1;
            string Cadastro, infotipo, infopreco, infopeso;



            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\r\n   _____   _         _                                        _                _____                           _    /\\/|         \r\n  / ____| (_)       | |                                      | |              / ____|                         | |  |/\\/          \r\n | (___    _   ___  | |_    ___   _ __ ___     __ _        __| |   ___       | (___     ___   _   _           | |   __ _    ___  \r\n  \\___ \\  | | / __| | __|  / _ \\ | '_ ` _ \\   / _` |      / _` |  / _ \\       \\___ \\   / _ \\ | | | |      _   | |  / _` |  / _ \\ \r\n  ____) | | | \\__ \\ | |_  |  __/ | | | | | | | (_| |     | (_| | | (_) |      ____) | |  __/ | |_| |     | |__| | | (_| | | (_) |\r\n |_____/  |_| |___/  \\__|  \\___| |_| |_| |_|  \\__,_|      \\__,_|  \\___/      |_____/   \\___|  \\__,_|      \\____/   \\__,_|  \\___/ \r\n                                                                                                                                 \r\n                                                                                                                                 \r\n");
            Console.ForegroundColor= ConsoleColor.White;

            while (menuloop == 1)
            {

                Console.WriteLine("Menu: ");
                Console.WriteLine("1- Cadastrar Novos Produtos");
                Console.WriteLine("2- Realizar Venda de Produtos");
                Console.WriteLine("3- Gerar relatorio ");
                Console.Write('\n');
                Console.Write("Escolha a Opção: ");
                Console.Write('\n');

                menu = int.Parse(Console.ReadLine());

                if (menu == 1)
                {
                    while (loop == 1)
                    {
                        Console.Write('\n');
                        Console.WriteLine("Qual produto vamos cadastrar?");
                        Cadastro = (Console.ReadLine());

                        Console.Write('\n');
                        Console.WriteLine("O produto a ser cadastrado é " + Cadastro);

                        Console.Write('\n');
                        Console.WriteLine("Atualize as informaçoes pedidas");

                        Console.Write('\n');
                        Console.Write("TIPO:");
                        infotipo = (Console.ReadLine());

                        Console.Write("PREÇO:");
                        infopreco = (Console.ReadLine());

                        Console.Write("PESO:");
                        infopeso = (Console.ReadLine());


                        Console.Write('\n');
                        Console.WriteLine("O produto cadastrado é " + Cadastro);

                        Console.Write('\n');
                        Console.WriteLine("As informações estão corretas!");

                        Console.Write('\n');
                        Console.WriteLine("TIPO:" + infotipo);

                        Console.Write('\n');
                        Console.WriteLine("PREÇO:" + infopreco);

                        Console.Write('\n');
                        Console.WriteLine("PESO:" + infopeso);

                        Console.Write('\n');

                        Console.WriteLine("temos mais produtos para cadastro?");
                        Console.Write('\n');

                        Console.WriteLine("1 = Sim / 2 = NÃO ");
                        loop = int.Parse(Console.ReadLine());


                    }

                }
                else if (menu == 2)
                {

                }
                else if (menu == 3)
                {

                }
                else
                {
                    Console.WriteLine("Selecione uma opção valida");
                }

                Console.WriteLine("Gostaria de voltar para o menu?");
                Console.Write('\n');

                Console.WriteLine("1 = Sim / 2 = NÃO ");
                menuloop = int.Parse(Console.ReadLine());


            }

            Console.Write("PRESS ENTER TO FINISH");
            Console.ReadKey();
        }
    }
}
