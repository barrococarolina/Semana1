Console.WriteLine("Hora trabalhada: ");
int horaTrab = int.Parse(Console.ReadLine());

Console.WriteLine("Valor da hora: ");
double valorHora = double.Parse(Console.ReadLine());

Console.WriteLine($"O salário é {horaTrab * valorHora:00.00}");
Console.ReadLine();