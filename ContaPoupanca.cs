// ContaPoupanca.cs
using System;

// A sintaxe ": Conta" significa:
// "ContaPoupanca É UMA Conta"
// Ela herda tudo de "Conta"
public class ContaPoupanca : Conta
{
    // Esta é uma propriedade específica da ContaPoupanca
    public decimal TaxaDeJuros { get; private set; }

    // --- CONSTRUTOR DA CLASSE FILHA ---
    // Ela precisa receber os dados da "mãe" (titular, numero, saldo)
    // e os seus próprios (taxaDeJuros)
    
    // A sintaxe ": base(...)" chama o construtor da classe "Mãe" (Conta)
    // e passa os dados para ela.
    public ContaPoupanca(string nomeTitular, int numeroConta, decimal saldoInicial, decimal taxaDeJuros)
        : base(nomeTitular, numeroConta, saldoInicial)
    {
        // A "base" já cuidou de NomeTitular, NumeroConta e Saldo.
        // O construtor da filha só precisa se preocupar com o que é novo.
        TaxaDeJuros = taxaDeJuros;
    }

    // --- MÉTODO ESPECÍFICO DA FILHA ---
    public void AdicionarRendimento()
    {
        // Calcula o rendimento
        decimal rendimento = _saldo * TaxaDeJuros;
        
        // _saldo é "protected", então podemos alterá-lo aqui!
        _saldo = _saldo + rendimento; 
        
        Console.WriteLine($"Rendimento de {TaxaDeJuros:P} aplicado."); // :P formata como porcentagem
        Console.WriteLine($"Novo saldo: {Saldo:C}");
    }
}