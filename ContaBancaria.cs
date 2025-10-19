using System;

// "public" significa que outras classes (como a "Program") podem ver este molde.
public class ContaBancaria
{
    // --- 1. PROPRIEDADES (Os "Dados" do Molde) ---
    // Estas são as variáveis que CADA objeto "ContaBancaria" terá.
    // Note que elas NÃO são "static". Cada conta tem a sua.
    public string NomeTitular;
    public int NumeroConta;
    public decimal Saldo; // O "Saldo" agora mora aqui!

    
    // --- 2. MÉTODOS (Os "Comportamentos" do Molde) ---

    // Método para sacar. A lógica de saque agora é responsabilidade da conta.
    public void Sacar(decimal valorSaque)
    {
        if (valorSaque <= 0)
        {
            Console.WriteLine("Valor de saque inválido.");
        }
        else if (valorSaque > Saldo)
        {
            Console.WriteLine("Saldo insuficiente.");
        }
        else
        {
            // "Saldo" aqui se refere ao saldo DESTE objeto.
            Saldo = Saldo - valorSaque; 
            Console.WriteLine("Saque realizado com sucesso!");
            Console.WriteLine($"Seu novo saldo é: {Saldo:C}");
        }
    }

    // Método para depositar
    public void Depositar(decimal valorDeposito)
    {
        if (valorDeposito <= 0)
        {
            Console.WriteLine("Valor de depósito inválido.");
        }
        else
        {
            Saldo = Saldo + valorDeposito;
            Console.WriteLine($"Depósito de {valorDeposito:C} realizado.");
            Console.WriteLine($"Seu novo saldo é: {Saldo:C}");
        }
    }

    // Método para ver o saldo
    public void VerSaldo()
    {
        Console.WriteLine($"Saldo de {NomeTitular}: {Saldo:C}");
    }
}