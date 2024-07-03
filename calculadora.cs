using System;

public class Program
{
    public static void Main()
    {
        // Solicita ao usuário para inserir os números
        Console.WriteLine("Digite o primeiro número:");
        int num1 = LerNumeroInteiroDoConsole();

        Console.WriteLine("Digite o segundo número:");
        int num2 = LerNumeroInteiroDoConsole();

        // Chama a função que retorna a soma e a multiplicação dos números inseridos
        var resultados = CalcularSomaEMultiplicacao(num1, num2);
        
        // Exibe os resultados da soma e da multiplicação
        Console.WriteLine($"A soma de {num1} e {num2} é {resultados.Soma}");
        Console.WriteLine($"A multiplicação de {num1} e {num2} é {resultados.Multiplicacao}");
    }
    
    // Função para ler um número inteiro do console
    public static int LerNumeroInteiroDoConsole()
    {
        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Por favor, digite um número válido:");
        }
        return numero;
    }
    
    // Função que retorna a soma e a multiplicação de dois números inteiros
    public static (int Soma, int Multiplicacao) CalcularSomaEMultiplicacao(int a, int b)
    {
        int soma = a + b;
        int multiplicacao = a * b;
        return (soma, multiplicacao);
    }
}
