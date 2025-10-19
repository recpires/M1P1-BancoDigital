// ContaBancaria.cs
using System;

public class ContaBancaria
{
    // --- 1. PROPRIEDADES (O Jeito C#) ---

    // Propriedade Automática para o Nome.
    // get; (público) -> Todos podem ler.
    // private set; -> Só a classe pode alterar (no construtor).
    public string NomeTitular { get; private set; }

    // Propriedade Automática para o Número da Conta.
    public int NumeroConta { get; private set; }

    // Propriedade "Full" para o Saldo.
    private decimal _saldo; // O campo privado que armazena o dado
    
    public decimal Saldo // A propriedade pública que expõe o dado
    {
        get { return _saldo; }
        // Como não definimos um "set", esta propriedade é SÓ DE LEITURA (ReadOnly)
        // para o mundo exterior. Perfeito!
    }


    // --- 2. CONSTRUTOR ---
    // O construtor agora usa as Propriedades para definir os valores
    public ContaBancaria(string nomeTitular, int numeroConta, decimal saldoInicial)
    {
        // "NomeTitular" aqui está a chamar o "set" privado da Propriedade
        NomeTitular = nomeTitular; 
        NumeroConta = numeroConta;
        
        // _saldo é o único que ainda alteramos diretamente,
        // pois a lógica de depósito valida o valor.
        _saldo = 0; // Inicia zerado antes do depósito inicial
        Depositar(saldoInicial); 
    }


    // --- 3. MÉTODOS DE AÇÃO (Não mudam muito) ---

    public void Sacar(decimal valorSaque)
    {
        if (valorSaque <= 0)
        {
            Console.WriteLine("Valor de saque inválido.");
        }
        else if (valorSaque > _saldo) // Acede ao campo privado
        {
            Console.WriteLine("Saldo insuficiente.");
        }
        else
        {
            _saldo = _saldo - valorSaque; // Altera o campo privado
            Console.WriteLine("Saque realizado com sucesso!");
            Console.WriteLine($"Seu novo saldo é: {Saldo:C}"); // Lê a Propriedade pública
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
        // Agora usamos a Propriedade "Saldo", que chama o "get"
        Console.WriteLine($"Saldo de {NomeTitular}: {Saldo:C}");
    }
}