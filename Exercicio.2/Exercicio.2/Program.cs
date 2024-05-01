
void MeuMMC()
{
    Console.WriteLine("Digite o primeiro número:");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo número:");
    int num2 = int.Parse(Console.ReadLine());

    int resultado = MMC(num1, num2);

    Console.WriteLine($"O Mínimo Múltiplo Comum de {num1} e {num2} é: {resultado}");
}

int MMC(int num1, int num2)
{
    // Encontra o MDC (Máximo Divisor Comum)
    int numero1 = num1;
    int numero2 = num2;

    if (numero1 == 0) return numero2;
    if (numero2 == 0) return numero1;

    while (numero2 != 0)
    {
        int resto = numero1 % numero2;
        numero1 = numero2;
        numero2 = resto;
    }

    // Calcula o MMC usando a fórmula.)
    int mmc = (num1 * num2) / numero1;

    return mmc;
}

MeuMMC();
