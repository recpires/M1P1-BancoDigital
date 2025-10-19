// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria contaDoRodrigo = new ContaBancaria(
            nomeTitular: "Rodrigo Pires", 
            numeroConta: 1234, 
            saldoInicial: 1500.75m
        );

        // --- MUDANÇA PRINCIPAL ---
        // Antes: contaDoRodrigo.GetNomeTitular()
        // Agora: contaDoRodrigo.NomeTitular
        // (Parece um campo, mas está a chamar o "get" da propriedade!)
        Console.WriteLine($"--- Bem-vindo ao Banco Digital, {contaDoRodrigo.NomeTitular} ---");
        Console.WriteLine($"Conta N.º: {contaDoRodrigo.NumeroConta}");

        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1. Ver Saldo");
            Console.WriteLine("2. Realizar Saque");
            Console.WriteLine("3. Realizar Depósito");
            Console.WriteLine("4. Sair");
            Console.Write("Digite sua opção: ");
            
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    contaDoRodrigo.VerSaldo(); 
                    break;

                case "2":
                    Console.Write("Digite o valor do saque: ");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    contaDoRodrigo.Sacar(valorSaque);
                    break;

                case "3":
                    Console.Write("Digite o valor do depósito: ");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    contaDoRodrigo.Depositar(valorDeposito);
                    break;

                case "4":
                    continuar = false;
                    Console.WriteLine("Encerrando... Obrigado por usar nosso banco!");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}