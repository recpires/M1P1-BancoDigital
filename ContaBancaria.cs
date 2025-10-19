// ContaBancaria.cs
using System;

public class ContaBancaria
{
    // --- 1. PROPRIEDADES (Agora "Encapsuladas") ---

    // Estes são os "campos" (fields) privados.
    // Ninguém de fora pode vê-los ou alterá-los diretamente.
    private string _nomeTitular;
    private int _numeroConta;
    private decimal _saldo;

    // --- 2. CONSTRUTOR ---
    // Este método é chamado automaticamente no "new"
    // Ele FORÇA a criação de uma conta já com dados válidos.
    public ContaBancaria(string nomeTitular, int numeroConta, decimal saldoInicial)
    {
        _nomeTitular = nomeTitular;
        _numeroConta = numeroConta;
        
        // NÃO fazemos "_saldo = saldoInicial;"
        // Usamos nosso próprio método Depositar para validar o saldo inicial!
        Depositar(saldoInicial); 
    }

    // --- 3. MÉTODOS "GETTERS" (Para ler dados privados) ---

    // Método público para "ler" o nome (que é privado)
    public string GetNomeTitular()
    {
        return _nomeTitular;
    }
    
    // Método público para "ler" o saldo (que é privado)
    public decimal GetSaldo()
    {
        return _saldo;
    }

    // --- 4. MÉTODOS DE AÇÃO (Os "Portões" de entrada/saída) ---

    // Método para sacar.
    public void Sacar(decimal valorSaque)
    {
        if (valorSaque <= 0)
        {
            Console.WriteLine("Valor de saque inválido.");
        }
        else if (valorSaque > _saldo) // Agora usamos a variável privada
        {
            Console.WriteLine("Saldo insuficiente.");
        }
        else
        {
            // O _saldo SÓ é alterado aqui dentro.
            _saldo = _saldo - valorSaque; 
            Console.WriteLine("Saque realizado com sucesso!");
            Console.WriteLine($"Seu novo saldo é: {_saldo:C}");
        }
    }

    // Método para depositar
    public void Depositar(decimal valorDeposito)
    {
        if (valorDeposito <= 0)
        {
            Console.WriteLine("Valor de depósito inválido (deve ser > 0).");
        }
        else
        {
            _saldo = _saldo + valorDeposito;
            Console.WriteLine($"Depósito de {valorDeposito:C} realizado.");
            Console.WriteLine($"Seu novo saldo é: {_saldo:C}");
        }
    }

    // VerSaldo agora usa o Getter
    public void VerSaldo()
    {
        Console.WriteLine($"Saldo de {_nomeTitular}: {GetSaldo():C}");
    }
}