Console.WriteLine("Insira um valor:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira um valor:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira um valor:");
int num3 = int.Parse(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine(num1 + " é o maior valor");
}

else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine(num2 + " é o maior valor");
}

else
{
    Console.WriteLine(num3 + " é o maior valor");
}

Console.ReadLine();