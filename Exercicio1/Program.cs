Console.WriteLine("Escreva seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("Escreva seu endereço:");
string end = Console.ReadLine();

Console.WriteLine("Escreva seu CEP:");
string cep = Console.ReadLine();

Console.WriteLine("Escreva seu número de telefone com seu DDD:");
string num = Console.ReadLine();

Console.WriteLine($"Meu nome é " + nome);
Console.WriteLine($"Meu endereço é " + end);
Console.WriteLine($"Meu CEP é " + cep);
Console.WriteLine($"Meu telefone é " + num);

Console.ReadLine();