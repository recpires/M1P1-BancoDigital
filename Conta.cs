// Conta.cs (Arquivo renomeado)
using System;

public class Conta // Classe renomeada
{
    // --- 1. PROPRIEDADES ---
    public string NomeTitular { get; private set; }
    public int NumeroConta { get; private set; }

    // --- MUDANÇA AQUI ---
    // De "private" para "protected". 
    // Agora as classes filhas (como ContaPoupanca) podem aceder a este campo.
    protected decimal _saldo; 
    
    public decimal Saldo
    {
        get { return _saldo; }
    }

    // --- 2. CONSTRUTOR ---
    public Conta(string nomeTitular, int numeroConta, decimal saldoInicial) // Construtor renomeado
    {
        NomeTitular = nomeTitular; 
        NumeroConta = numeroConta;
        _saldo = 0;
        Depositar(saldoInicial); 
    }

    // --- 3. MÉTODOS ---
    // (Os métodos Sacar, Depositar e VerSaldo continuam exatamente iguais por enquanto)

    public void Sacar(decimal valorSaque)
    {
        if (valorSaque <= 0)
        {
            Console.WriteLine("Valor de saque inválido.");
        }
        else if (valorSaque > _saldo) 
        {
            Console.WriteLine("Saldo insuficiente.");
        }
        else
        {
            _saldo = _saldo - valorSaque; 
            Console.WriteLine("Saque realizado com sucesso!");
            Console.WriteLine($"Seu novo saldo é: {Saldo:C}"); 
        }
    }

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
            Console.WriteLine($"Seu novo saldo é: {Saldo:C}");
        }
    }

    public void VerSaldo()
    {
        Console.WriteLine($"Saldo de {NomeTitular}: {Saldo:C}");
    }
}