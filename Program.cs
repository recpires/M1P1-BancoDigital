using System;

class Program
{
    // --- VARIÁVEL GLOBAL (ou "Campo da Classe") ---
    // Tiramos o saldo de dentro do "Main" e colocamos aqui.
    // O "static" permite que todos os métodos "static" (como o Main e o RealizarSaque)
    // possam enxergar e modificar essa variável.
    static decimal saldoAtual = 1500.75m;
    static string nomeCliente = "Rodrigo Pires";


    // --- PONTO DE ENTRADA (MAIN) ---
    // A responsabilidade do Main agora é controlar o "menu" principal do banco.
    static void Main(string[] args)
    {
        Console.WriteLine($"--- Bem-vindo ao Banco Digital, {nomeCliente} ---");

        // --- NOSSO LOOP PRINCIPAL ---
        bool continuar = true; // Nossa variável de controle do loop
        
        while (continuar == true) // Ou simplesmente "while (continuar)"
        {
            // 1. Mostrar o menu de opções
            Console.WriteLine(); // Linha em branco para organizar
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1. Ver Saldo");
            Console.WriteLine("2. Realizar Saque");
            Console.WriteLine("3. Sair");
            Console.Write("Digite sua opção: ");
            
            string opcao = Console.ReadLine();

            // --- ESTRUTURA DE DECISÃO (switch) ---
            // "switch" é uma alternativa mais limpa ao "if/else" para menus.
            switch (opcao)
            {
                case "1":
                    VerSaldo(); // Chama o método que criamos
                    break; // Pára a execução do "switch"

                case "2":
                    RealizarSaque(); // Chama o método que criamos
                    break;

                case "3":
                    continuar = false; // Isso fará o loop "while" parar na próxima verificação
                    Console.WriteLine("Encerrando... Obrigado por usar nosso banco!");
                    break;

                default: // Equivale ao "else" final
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }


    // --- NOSSOS MÉTODOS AUXILIARES ---

    // Método 1: Apenas vê o saldo
    static void VerSaldo()
    {
        Console.WriteLine($"Seu saldo atual é: {saldoAtual:C}");
    }

    // Método 2: Lógica de Saque
    static void RealizarSaque()
    {
        Console.Write("Digite o valor do saque: ");
        string valorSaqueString = Console.ReadLine();
        decimal valorSaque = decimal.Parse(valorSaqueString);

        // A lógica de validação que já tínhamos
        if (valorSaque <= 0)
        {
            Console.WriteLine("Valor de saque inválido.");
        }
        else if (valorSaque > saldoAtual)
        {
            Console.WriteLine("Saldo insuficiente.");
        }
        else
        {
            // Atualiza o saldo (que agora é uma variável "global" da classe)
            saldoAtual -= valorSaque;
            Console.WriteLine("Saque realizado com sucesso!");
            Console.WriteLine($"Seu novo saldo é: {saldoAtual:C}");
        }
    }
}