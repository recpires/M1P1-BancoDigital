// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // --- MUDANÇA PRINCIPAL ---
        // Não estamos mais criando uma "Conta", e sim uma "ContaPoupanca"
        ContaPoupanca contaDoRodrigo = new ContaPoupanca(
            nomeTitular: "Rodrigo Pires (Poupança)", 
            numeroConta: 1234, 
            saldoInicial: 1500.75m,
            taxaDeJuros: 0.005m // 0.5%
        );

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
            Console.WriteLine("4. Adicionar Rendimento (Poupança)"); // Nova opção!
            Console.WriteLine("5. Sair");
            Console.Write("Digite sua opção: ");
            
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    // Este método foi HERDADO da classe "Conta"
                    contaDoRodrigo.VerSaldo(); 
                    break;

                case "2":
                    // Este método foi HERDADO da classe "Conta"
                    Console.Write("Digite o valor do saque: ");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    contaDoRodrigo.Sacar(valorSaque);
                    break;

                case "3":
                    // Este método foi HERDADO da classe "Conta"
                    Console.Write("Digite o valor do depósito: ");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    contaDoRodrigo.Depositar(valorDeposito);
                    break;
                
                case "4":
                    // Este método SÓ EXISTE em "ContaPoupanca"
                    contaDoRodrigo.AdicionarRendimento();
                    break;

                case "5":
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