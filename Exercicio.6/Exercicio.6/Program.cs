
void Main()
{
    Console.WriteLine("Digite o número base:");
    double numero = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o expoente:");
    double potencia = double.Parse(Console.ReadLine());

    var resultado = Potencia(numero, potencia);

    Console.WriteLine($"O resultado de {numero} elevado a {potencia} é: {resultado}");
}

double Potencia(double numero, double potencia)
{
    double total = 1;

    for (int i = 1; i <= potencia; i++)
    {
        total = Vezes(total, numero);
    }

    return total;
}

double Vezes(double numero, double potencia)
{
    double total = 0;
    for (int i = 0; i < potencia; i++)
    {
        total += numero;
    }

    return total;
}

Main();
