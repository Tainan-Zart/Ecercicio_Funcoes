
void Main()
{
    Console.WriteLine("Digite o número de turmas:");
    int numeroTurmas = int.Parse(Console.ReadLine());

    double mediaGeral = MediaEscola(numeroTurmas);

    Console.WriteLine($"A média geral da escola é: {mediaGeral}");
}

double MediaEscola(int numeroTurmas)
{
    double somaMediasTurmas = 0;

    for (int i = 1; i <= numeroTurmas; i++)
    {
        Console.WriteLine($"Digite o número de alunos da turma {i}:");
        int numeroAlunos = int.Parse(Console.ReadLine());

        double mediaTurma = MediaTurma(numeroAlunos);
        somaMediasTurmas += mediaTurma;

        Console.WriteLine($"A média da turma {i} é: {mediaTurma}");
    }

    double mediaGeral = somaMediasTurmas / numeroTurmas;
    return mediaGeral;
}

double MediaTurma(int numeroAlunos)
{
    double somaNotas = 0;

    for (int i = 1; i <= numeroAlunos; i++)
    {
        Console.WriteLine($"Digite a nota do aluno {i}:");
        double nota = double.Parse(Console.ReadLine());
        somaNotas += nota;
    }

    double mediaTurma = somaNotas / numeroAlunos;
    return mediaTurma;
}

Main();
