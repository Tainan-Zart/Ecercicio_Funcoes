using System;

bool Triangulo(int a, int b, int c)
{
    bool n1 = a + b > c;
    bool n2 = a + c > b;
    bool n3 = c + b > a;

    if (n1 && n2 && n3)
    {
        return true;
    }

    return false;
}

string TipoTriangulo(int a, int b, int c)
{
    if (a == b && b == c)
        return "Triângulo Equilátero";

    else if (a != b && b != c && a != c)
        return "Triângulo Escaleno";

    else return "Triângulo Isósceles";
}

Console.WriteLine("Digite o comprimento do primeiro lado do triângulo:");
int lado1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o comprimento do segundo lado do triângulo:");
int lado2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o comprimento do terceiro lado do triângulo:");
int lado3 = int.Parse(Console.ReadLine());

bool resultado = Triangulo(lado1, lado2, lado3);

if (resultado)
{
    string tipoTriangulo = TipoTriangulo(lado1, lado2, lado3);
    Console.WriteLine($"O triângulo com os lados {lado1}, {lado2} e {lado3} é um {tipoTriangulo}.");
}
else
    Console.WriteLine("As medidas fornecidas não correspondem a um triângulo.");
