Console.WriteLine("Digite o salário do funcionário:");
int salario = int.Parse(Console.ReadLine());

if (salario <= 400)
{
    double percent = 15.0 / 100.0;
    double novoSalario = salario + (percent * salario);
    Console.WriteLine($"O novo salário é {novoSalario:00.00}, reajuste ganho de {novoSalario - salario:00.00}, e percentual {percent * 100}% ");
}
if (salario >= 400.01 && salario <= 800)
{
    double percent = 12.0 / 100.0;
    double novoSalario = salario + (percent * salario);
    Console.WriteLine($"O novo salário é {novoSalario:00.00}, reajuste ganho de {novoSalario - salario:00.00}, e percentual {percent * 100}% ");
}
if (salario >= 800.01 && salario <= 1200)
{
    double percent = 10.0 / 100.0;
    double novoSalario = salario + (percent * salario);
    Console.WriteLine($"O novo salário é {novoSalario:00.00}, reajuste ganho de {novoSalario - salario:00.00}, e percentual {percent * 100}% ");
}
if (salario >= 1200.01 && salario <= 2000)
{
    double percent = 7.0 / 100.0;
    double novoSalario = salario + (percent * salario);
    Console.WriteLine($"O novo salário é {novoSalario:00.00}, reajuste ganho de {novoSalario - salario:00.00}, e percentual {percent * 100}% ");
}
if (salario > 2000)
{
    double percent = 4.0 / 100.0;
    double novoSalario = salario + (percent * salario);
    Console.WriteLine($"O novo salário é {novoSalario:00.00}, reajuste ganho de {novoSalario - salario:00.00}, e percentual {percent * 100}% ");
}

Console.ReadLine();