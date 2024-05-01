

void Main()
{
    Console.WriteLine("Digite um valor para N:");
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine($"O resultado da função para o valor {n} é: {FuncaoCalculo(n)}");
}

double FuncaoCalculo(int n)
{
    double soma = 0;

    for (int i = 1; i <= n; i++)
    {
        var ii = Math.Pow(i, 2);
        double termo = 5 * ii + 2 * i + 8;
        soma += termo;
    }

    return soma;
}

Main();
