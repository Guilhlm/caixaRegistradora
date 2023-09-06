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
            string Cadastro, infotipo, infopreco, infopeso;
            menuloop = 1;
            loop = 1;
            string produto1 = " ", produto2 = " ", produto3 = " ", produto4 = "  ";
            int quantidade1 = 10, quantidade2 = 20, quantidade3 = 33, quantidade4 = 230;
            int valor1 = 4, valor2 = 9, valor3 = 10, valor4 = 1;


            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\r\n   _____   _         _                                        _                _____                           _    /\\/|         \r\n  / ____| (_)       | |                                      | |              / ____|                         | |  |/\\/          \r\n | (___    _   ___  | |_    ___   _ __ ___     __ _        __| |   ___       | (___     ___   _   _           | |   __ _    ___  \r\n  \\___ \\  | | / __| | __|  / _ \\ | '_ ` _ \\   / _` |      / _` |  / _ \\       \\___ \\   / _ \\ | | | |      _   | |  / _` |  / _ \\ \r\n  ____) | | | \\__ \\ | |_  |  __/ | | | | | | | (_| |     | (_| | | (_) |      ____) | |  __/ | |_| |     | |__| | | (_| | | (_) |\r\n |_____/  |_| |___/  \\__|  \\___| |_| |_| |_|  \\__,_|      \\__,_|  \\___/      |_____/   \\___|  \\__,_|      \\____/   \\__,_|  \\___/ \r\n                                                                                                                                 \r\n                                                                                                                                 \r\n");
            Console.ForegroundColor= ConsoleColor.Yellow;

            while (menuloop == 1)
            {            

                Console.WriteLine("Menu: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write('\n');
                Console.WriteLine("1- Cadastrar Novos Produtos");
                Console.WriteLine("2- Realizar Venda de Produtos");
                Console.WriteLine("3- Gerar relatorio ");
                Console.WriteLine("4- pagamento");
                Console.Write('\n');
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Escolha a Opção: ");
                

                

                menu = int.Parse(Console.ReadLine());

                Console.Clear();

                if (menu == 1)
                {
                    while (loop == 1)
                    {

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\r\n                     _                 _                          _                                       _           _                 \r\n                    | |               | |                        | |                                     | |         | |                \r\n   ___    __ _    __| |   __ _   ___  | |_   _ __    ___       __| |   ___     _ __    _ __    ___     __| |  _   _  | |_    ___    ___ \r\n  / __|  / _` |  / _` |  / _` | / __| | __| | '__|  / _ \\     / _` |  / _ \\   | '_ \\  | '__|  / _ \\   / _` | | | | | | __|  / _ \\  / __|\r\n | (__  | (_| | | (_| | | (_| | \\__ \\ | |_  | |    | (_) |   | (_| | |  __/   | |_) | | |    | (_) | | (_| | | |_| | | |_  | (_) | \\__ \\\r\n  \\___|  \\__,_|  \\__,_|  \\__,_| |___/  \\__| |_|     \\___/     \\__,_|  \\___|   | .__/  |_|     \\___/   \\__,_|  \\__,_|  \\__|  \\___/  |___/\r\n                                                                              | |                                                       \r\n                                                                              |_|                                                       \r\n");

                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.Write('\n');
                        Console.WriteLine("Qual o nome do produto que vamos cadastrar?");
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

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("temos mais produtos para cadastro? ");
                        Console.Write('\n');

                        Console.Write("1 = Sim / 2 = NÃO ");
                        loop = int.Parse(Console.ReadLine());

                        Console.Clear();

                    }

                }
                else if (menu == 2)
                {
                    int menu2;
                    int loop2 = 1;

                    while (loop2 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\r\n                                     _                                  \r\n                                    | |                                 \r\n _ __ ___    ___  _ __   _   _    __| |  __ _    ___   __ _  ___   __ _ \r\n| '_ ` _ \\  / _ \\| '_ \\ | | | |  / _` | / _` |  / __| / _` |/ __| / _` |\r\n| | | | | ||  __/| | | || |_| | | (_| || (_| | | (__ | (_| |\\__ \\| (_| |\r\n|_| |_| |_| \\___||_| |_| \\__,_|  \\__,_| \\__,_|  \\___| \\__,_||___/ \\__,_|\r\n                                                                        \r\n                                                                        \r\n                                                                        \r\n                                                                        \r\n                                                                        \r\n                                                                        \r\n                                                                        \r\n                                                                        \r\n                                                                        \r\n                                                                        \r\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                     

                        Console.WriteLine("");
                        Console.WriteLine("SALGADOS");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("");                        
                        Console.WriteLine("1- calabresa");
                        Console.WriteLine("2- carne");


                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("");
                        Console.WriteLine("REFRIGERANTE");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("");
                        Console.WriteLine("3- refrigerante coca-cola");


                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("");
                        Console.WriteLine("DOCE");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("");
                        Console.WriteLine("4- bala");

                        Console.WriteLine();
                        Console.Write("escolha uma opçao: ");

                        menu2 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\r\n _  _  ____  __ _  _  _        ____   __          ___   __   ____   __  \r\n( \\/ )(  __)(  ( \\/ )( \\      (    \\ / _\\        / __) / _\\ / ___) / _\\ \r\n/ \\/ \\ ) _) /    /) \\/ (       ) D (/    \\      ( (__ /    \\\\___ \\/    \\\r\n\\_)(_/(____)\\_)__)\\____/      (____/\\_/\\_/       \\___)\\_/\\_/(____/\\_/\\_/\r\n              \r\n              \r\n               \r\n          \r\n");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        if (menu2 == 1)
                        {
                            Console.WriteLine("salgado de calabresa " + produto1 + " - valor " + valor1);

                        }
                        else if (menu2 == 2)
                        {
                            Console.WriteLine("salgado de carne" + produto2 + " - valor " + valor2);
                        }
                        else if (menu2 == 3)
                        {
                            Console.WriteLine("coquinha" + produto3 + " - valor " + valor3);
                        }
                        else if (menu2 == 4)
                        {
                            Console.WriteLine("balinha " + produto4 + " - valor " + valor4);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;

                            Console.WriteLine("Voce selecionou uma opçao invalida");
                        }

                        Console.Write('\n');
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("algo a mais SR? ");
                        Console.Write('\n');


                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("1 = Sim / 2 = NÃO ");
                        loop2 = int.Parse(Console.ReadLine());

                        Console.Clear();
                    }

                    

                }
                else if (menu == 3)
                {
                    int menu3;



                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\r\n             _         _                 _        \r\n            | |       | |               (_)       \r\n _ __   ___ | |  __ _ | |_   ___   _ __  _   ___  \r\n| '__| / _ \\| | / _` || __| / _ \\ | '__|| | / _ \\ \r\n| |   |  __/| || (_| || |_ | (_) || |   | || (_) |\r\n|_|    \\___||_| \\__,_| \\__| \\___/ |_|   |_| \\___/ \r\n                                                  \r\n                                                  \r\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("Bem vindo ao relatorio");

                    Console.WriteLine("");

                    Console.WriteLine("Estoque do : " + produto1 + " - estoque " + quantidade1 + " - valor " + valor1);

                    Console.WriteLine("Estoque do : " + produto2 + " - estoque: " + quantidade2 + " - valor" + valor2);

                    Console.WriteLine("Estoque do : " + produto3 + " - estoque: " + quantidade3 + " - valor" + valor3);

                    Console.WriteLine("Estoque do : " + produto4 + " - estoque: " + quantidade4 + " - valor" + valor4);

                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.WriteLine("");

                    break;

                    menu3 = int.Parse(Console.ReadLine());

                    

                }
                else if (menu == 4)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\r\n ____   __    ___   __   _  _  ____  __ _  ____   __   ____ \r\n(  _ \\ / _\\  / __) / _\\ ( \\/ )(  __)(  ( \\(_  _) /  \\ / ___)\r\n ) __//    \\( (_ \\/    \\/ \\/ \\ ) _) /    /  )(  (  O )\\___ \\\r\n(__)  \\_/\\_/ \\___/\\_/\\_/\\_)(_/(____)\\_)__) (__)  \\__/ (____/\r\n                                                            \r\n                                                            \r\n                                                            \r\n                                                            \r\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    int pagamento;
                    int conta;
                    int notapaga;
                    int troco;

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("quanto deu sua comanda: ");
                    conta = int.Parse(Console.ReadLine());

                    Console.WriteLine("");

                    Console.Write("qual sera sua fomrma de pagamento? ");

                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("");
                    Console.WriteLine("1- pix");
                    Console.WriteLine("2- debito");
                    Console.WriteLine("3- credito");
                    Console.WriteLine("4- dinheiro");

                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("DIGITE: ");

                    Console.WriteLine("");

                    pagamento = int.Parse(Console.ReadLine());
                   

                    if (pagamento == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("voce escolheu pix ");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("a chave pix eh:  O PAULO NAO ME AJUDA NUNCA");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("TRANSAÇAO APROVADA");
                        Console.WriteLine("");
                    }
                    else if (pagamento == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("voce escolher debito");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("sua comanda deu " + conta + " por favor digite a senha: ");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("TRANSAÇAO APROVADA");
                        Console.WriteLine("");


                    }
                    else if (pagamento == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("voce escolheu credito ");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("sua comanda deu " + conta + " por favor digite a senha: ");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("TRANSAÇAO APROVADA");
                        Console.WriteLine("");


                    }
                    else if (pagamento == 4)
                    {
                        

                        Console.WriteLine("");

                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("voce escolheu dinheiro qual nota ira usar? ");
                        notapaga = int.Parse(Console.ReadLine());

                        Console.WriteLine("");

                        troco = notapaga - conta;

                        if (notapaga >= conta)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("TRANSAÇAO APROVADA");

                            Console.WriteLine("");

                            Console.WriteLine("seu troco eh de: " + troco);

                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("SEU DINHEIRO EH INSUFICIENTE");

                            Console.WriteLine("");
                        }
                    }
                    
                   


                }else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    Console.WriteLine("Selecionou uma opção valida");

                    Console.WriteLine("");
                }

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Gostaria de voltar para o menu? ");
                Console.Write('\n');

                Console.WriteLine("1 = Sim / 2 = NÃO ");
                menuloop = int.Parse(Console.ReadLine());


            }

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("PRESS ENTER TO FINISH");
            Console.ReadKey();
        }
    }
}
