Console.WriteLine("---- Ano de nascimento e idade ----");

Console.WriteLine("Digite o ano de nascimento:");
int anoNasc = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o ano atual: ");
int anoAtual = int.Parse(Console.ReadLine());

Console.WriteLine($"Sua idade é {anoAtual - anoNasc} anos");
Console.ReadLine();