double[] notas = new double[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Digite a nota {i + 1} do aluno: ");
    notas[i] = double.Parse(Console.ReadLine());

}

double media = notas.Average();
string result = (media < 6) ? "F" : (media < 7) ? "D" : (media < 8) ? "C" : (media < 9) ? "B" : "A";
Console.WriteLine("A nota do aluno é " + result);
Console.ReadLine();