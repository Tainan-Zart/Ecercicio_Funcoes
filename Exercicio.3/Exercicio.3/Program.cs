
bool Primo(int num)
{
    if (num <= 1)
        return false;

    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
            return false;
    }

    return true;
}


int SomaPrimos(int n)
{
    int soma = 0;
    int contador = 0;
    int numero = 2;

    while (contador < n)
    {
        if (Primo(numero))
        {
            soma += numero;
            contador++;
        }
        numero++;
    }

    return soma;
}

void Main()
{
    Console.WriteLine("Quantos números primos você deseja somar?");
    int n = int.Parse(Console.ReadLine());

    int soma = SomaPrimos(n);
    Console.WriteLine($"A soma dos {n} primeiros números primos é: {soma}");

    if (Primo(soma))
        Console.WriteLine("A soma dos números primos também é um número primo.");
    else
        Console.WriteLine("A soma dos números primos não é um número primo.");
}

Main();
