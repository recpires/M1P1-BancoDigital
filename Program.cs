// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // --- CRIAÇÃO DO OBJETO (Agora via Construtor) ---
        // Somos OBRIGADOS a passar os dados iniciais.
        // O objeto já "nasce" pronto.
        ContaBancaria contaDoRodrigo = new ContaBancaria(
            nomeTitular: "Rodrigo Pires", 
            numeroConta: 1234, 
            saldoInicial: 1500.75m
        );

        // --- TENTE ISSO E VEJA O ERRO! ---
        // contaDoRodrigo._saldo = 99999; // ERRO! '_saldo' is inaccessible due to its protection level
        // Console.WriteLine(contaDoRodrigo._nomeTitular); // ERRO!
        // Nosso encapsulamento funcionou!

        // --- O JEITO CORRETO DE LER O DADO ---
        Console.WriteLine($"--- Bem-vindo ao Banco Digital, {contaDoRodrigo.GetNomeTitular()} ---");

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