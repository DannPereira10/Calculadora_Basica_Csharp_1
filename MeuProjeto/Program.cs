namespace MeuProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Bem-vindo ao Meu Projeto!");
            Console.WriteLine("Qual o seu Nome?");
            string nome = Console.ReadLine() ?? "Terraqueo";
            Console.WriteLine($"\nOla {nome}, seja bem-vindo ao meu primeiro Projeto em C#");
            Console.WriteLine("Vamos começar com o Basico, usando operações matemáticas.");
            Console.WriteLine("---------------------------------------------------");

            // Inicia o loop de operações matemáticas
            string opcao;

            do
            {
                // Exibe o menu de opções para o usuário
                Console.WriteLine("Escolha umas das opções abaixo para realizar uma operação:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Exponenciação");
                Console.WriteLine("5 - Divisão");
                Console.WriteLine("6 - Resto da Divisão");
                Console.WriteLine("7 - Raiz Quadrada");
                Console.WriteLine("8 - Sair");
                Console.WriteLine("Digite o número da opção desejada: ");
                Console.WriteLine("---------------------------------------------------");
                double num1, num2;
                opcao = Console.ReadLine()?.Trim() ?? "";
                switch (opcao)
                {
                    case "1": // Adição
                        Console.Write("Digite o primeiro Numero: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o Segundo Numero: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"O Resultado da Adição é: {num1 + num2}");
                        Console.WriteLine("----------------------------------------------------");
                        break;
                    case "2": // Subtração
                        Console.Write("Digite o primeiro Numero: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o Segundo Numero: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"O Resultado da Subtração é: {num1 - num2}");
                        Console.WriteLine("----------------------------------------------------");
                        break;
                    case "3": // Multiplicação
                        Console.Write("Digite o primeiro Numero: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o Segundo Numero: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"O Reultado da Multiplicação é: {num1 * num2}");
                        Console.WriteLine("----------------------------------------------------");
                        break;
                    case "4": // Exponenciação
                        Console.Write("Digite o primeiro Numero: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o Segundo Numero: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"O Resultado da Exponenciação é: {Math.Pow(num1, num2)}");
                        Console.WriteLine("----------------------------------------------------");
                        break;
                    case "5":   // Divisão
                        Console.Write("Digite o primeiro Numero: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o Segundo Numero: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"O Resultado da Divisão é: {num1 / num2}");
                        Console.WriteLine("----------------------------------------------------");
                        break;
                    case "6":   // Resto da Divisão
                        Console.Write("Digite o primeiro Numero: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o Segundo Numero: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"O Resultado do Resto da Divisão é: {num1 % num2}");
                        Console.WriteLine("----------------------------------------------------");
                        break;
                    case "7":   // Raiz Quadrada
                        Console.WriteLine("Para calcular a raiz quadrada, digite um número positivo.");
                        Console.Write("Digite o primeiro Numero: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"A Raiz quadrada de {num1} é: {Math.Sqrt(num1)}");
                        Console.WriteLine("----------------------------------------------------");
                        break;
                    case "8":   // Sair
                        Console.WriteLine("Saindo do programa...Até logo!");
                        Console.Clear();
                        Console.WriteLine("Obrigado por usar o Meu Projeto!");
                        return;
                    default:
                        Console.WriteLine("Opção inválida! Por favor, escolha uma opção válida.");
                        break;
                }
            } while (opcao != "8");
        }
    }
}