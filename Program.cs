using System; 

class Program
{
    static void Main(string[] args)
    {
        // --- 1. DECLARANDO VARIÁVEIS ---
        string nomeCliente = "Rodrigo Pires";
        decimal saldoAtual = 1500.75m;

        Console.WriteLine($"--- Bem-vindo ao Banco Digital, {nomeCliente} ---");
        Console.WriteLine($"Seu saldo atual é: {saldoAtual:C}");
        Console.WriteLine("--------------------------------------");
        
        // --- 2. CAPTURANDO INPUT DO USUÁRIO ---
        // Console.ReadLine() captura o que o usuário digita (sempre como string)
        Console.Write("Digite o valor do saque: "); // Write (sem Line) não pula linha
        string valorSaqueString = Console.ReadLine();

        // Precisamos converter a string para decimal
        // decimal.Parse() tenta "ler" o texto e transformar em número
        decimal valorSaque = decimal.Parse(valorSaqueString);
        
        // --- 3. ESTRUTURA DE DECISÃO (if/else) ---

        // Operadores de Comparação:
        // >  (Maior que)
        // >= (Maior ou igual a)
        // <  (Menor que)
        // <= (Menor ou igual a)
        // == (Igual a)
        // != (Diferente de)

        if (valorSaque <= 0)
        {
            Console.WriteLine("Valor de saque inválido. Tente novamente.");
        }
        else if (valorSaque > saldoAtual)
        {
            Console.WriteLine("Saldo insuficiente para este saque.");
            Console.WriteLine($"Seu saldo é: {saldoAtual:C}");
        }
        else
        {
            // Se chegou aqui, o saque é válido
            // Operadores Matemáticos: +, -, *, /
            saldoAtual = saldoAtual - valorSaque; // ou saldoAtual -= valorSaque;

            Console.WriteLine("Saque realizado com sucesso!");
            Console.WriteLine($"Seu novo saldo é: {saldoAtual:C}");
        }

        Console.WriteLine("--- Obrigado por usar nosso banco! ---");
    }
}