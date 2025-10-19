using System;

class Program
{
    // A única responsabilidade do "Main" é iniciar o programa
    // e gerenciar o menu.
    static void Main(string[] args)
    {
        // --- CRIAÇÃO DO OBJETO ---
        // Aqui estamos "construindo" uma ContaBancaria a partir do nosso molde.
        // A palavra-chave "new" cria a instância na memória.
        ContaBancaria contaDoRodrigo = new ContaBancaria();

        // Agora, vamos definir os dados (Propriedades) DESSE objeto
        contaDoRodrigo.NomeTitular = "Rodrigo Pires";
        contaDoRodrigo.NumeroConta = 1234;
        contaDoRodrigo.Saldo = 1500.75m; // Definindo o saldo inicial

        // E se eu quisesse outra conta? Fácil:
        // ContaBancaria contaDoAluno = new ContaBancaria();
        // contaDoAluno.NomeTitular = "Aluno";
        // contaDoAluno.Saldo = 50.00m;
        // (Elas são independentes!)

        Console.WriteLine($"--- Bem-vindo ao Banco Digital, {contaDoRodrigo.NomeTitular} ---");

        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1. Ver Saldo");
            Console.WriteLine("2. Realizar Saque");
            Console.WriteLine("3. Realizar Depósito"); // Adicionamos uma nova opção
            Console.WriteLine("4. Sair");
            Console.Write("Digite sua opção: ");
            
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    // Chamamos o método do *objeto*
                    contaDoRodrigo.VerSaldo(); 
                    break;

                case "2":
                    Console.Write("Digite o valor do saque: ");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    // Chamamos o método do *objeto*
                    contaDoRodrigo.Sacar(valorSaque);
                    break;

                case "3":
                    Console.Write("Digite o valor do depósito: ");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    // Chamamos o método do *objeto*
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