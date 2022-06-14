Console.WriteLine("Insira a primeira nota");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Insira a segunda nota");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Insira a terceira nota");
double nota3 = double.Parse(Console.ReadLine());

double media = (nota1 + nota2 + nota3) / 3;

if (media >= 7)
{
    Console.WriteLine($"O aluno tirou {media:.0} e está aprovado");
}


else
{
    Console.WriteLine($"O aluno tirou {media:.0} está reprovado");
}

Console.ReadLine();