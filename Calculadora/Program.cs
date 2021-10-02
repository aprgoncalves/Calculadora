using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string Opcao;
            bool Sucesso = false;
            short Menu = 1;

            do
            {
                if (Sucesso == false)
                {
                    Menu = 1;
                    Opcao = MenuPrincipal();
                }
                else
                {
                    Menu = 2;
                    Opcao = MenuSegundario();
                    if (Opcao == "0")
                        Sucesso = false;
                }

                if (Opcao == "99")
                    return;

                Sucesso = AcoesSelecaoMenu(Menu, Opcao, null, null);

            } while (1 == 1);
        }

        static string MenuPrincipal()
        {
            Console.WriteLine("======== MENU ========");
            Console.WriteLine("1  - Soma");
            Console.WriteLine("2  - Subtração");
            Console.WriteLine("3  - Multiplicação");
            Console.WriteLine("4  - Divisão");
            Console.WriteLine("99 - Sair");
            Console.WriteLine("======================");
            Console.WriteLine("Selecione uma das opções acima:");

            string opcao = Console.ReadLine().Trim();
            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Opção Selecionada: Soma");
                    break;
                case "2":
                    Console.WriteLine("Opção Selecionada: Subtração");
                    break;
                case "3":
                    Console.WriteLine("Opção Selecionada: Multiplicação");
                    break;
                case "4":
                    Console.WriteLine("Opção Selecionada: Divisão");
                    break;
                case "99":
                    Console.WriteLine("Opção Selecionada: Sair");
                    break;
                default:
                    Console.WriteLine("Valor Inválido");
                    break;
            }

            return opcao;
        }

        static string MenuSegundario()
        {
            Console.WriteLine("==== MENU ====");
            Console.WriteLine("0  - Retornar");
            Console.WriteLine("99 - Sair");
            Console.WriteLine("==============");

            string opcao = Console.ReadLine().Trim();
            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Opção Selecionada: Retornar");
                    break;
                case "99":
                    Console.WriteLine("Opção Selecionada: Sair");
                    break;
                default:
                    Console.WriteLine("Valor Inválido");
                    break;
            }

            return opcao;
        }

        static bool AcoesSelecaoMenu(short menu, string opcao, string valor1, string valor2)
        {
            double num1 = 0;
            double num2 = 0;
            double resultado = 0;
            bool sucesso = false;

            if ((menu == 1) && (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4"))
            {
                if (string.IsNullOrEmpty(valor1))
                {
                    Console.WriteLine("Informe o PRIMEIRO valor:");
                    valor1 = Console.ReadLine().Trim();
                    if (!(double.TryParse(valor1, out num1)))
                    {
                        Console.WriteLine("PRIMEIRO valor Inválido!");
                        return sucesso;
                    }
                }

                if (string.IsNullOrEmpty(valor2))
                {
                    Console.WriteLine("Informe o SEGUNDO valor:");
                    valor2 = Console.ReadLine().Trim();
                    if (!(double.TryParse(valor2, out num2)))
                    {
                        Console.WriteLine("SEGUNDO valor Inválido!");
                        return sucesso;
                    }
                }

                if (opcao == "1")
                    resultado = num1 + num2;
                if (opcao == "2")
                    resultado = num1 - num2;
                if (opcao == "3")
                    resultado = num1 * num2;
                if (opcao == "4")
                    resultado = num1 / num2;

                Console.WriteLine("Resultado: " + resultado.ToString());
                sucesso = true;
            }

            return sucesso;
        }

    }
}
