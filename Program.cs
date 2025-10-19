using System; // Precisamos disso para usar o "Console"

class Program
{
    static void Main(string[] args)
    {
        // --- 1. DECLARANDO VARIÁVEIS ---
        // Vamos guardar os dados de um cliente e sua conta

        string nomeCliente = "Rodrigo Pires";
        string cpfCliente = "123.456.789-00";
        int idadeCliente = 35; // Exemplo de int
        decimal saldoAtual = 1500.75m; // O 'm' indica que é um tipo "decimal"
        bool clienteAtivo = true; // Exemplo de bool

        // --- 2. EXIBINDO OS DADOS (Concatenação e Interpolação) ---
        
        // Forma 1: Concatenação (estilo antigo)
        Console.WriteLine("--- Ficha do Cliente (Concatenação) ---");
        Console.WriteLine("Nome: " + nomeCliente);
        Console.WriteLine("Saldo: " + saldoAtual);
        Console.WriteLine("--------------------------------------");
        Console.WriteLine(); // Linha em branco

        // Forma 2: Interpolação (muito melhor e mais moderna!)
        // Use o $ antes das aspas.
        Console.WriteLine("--- Ficha do Cliente (Interpolação) ---");
        Console.WriteLine($"Nome do Cliente: {nomeCliente}");
        Console.WriteLine($"CPF: {cpfCliente} | Idade: {idadeCliente}");
        Console.WriteLine($"Saldo Atual: {saldoAtual:C}"); // O ":C" formata como moeda!
        Console.WriteLine($"Cliente está Ativo? {clienteAtivo}");
        Console.WriteLine("--------------------------------------");
    }
}