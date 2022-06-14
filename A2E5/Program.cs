using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Insira um valor em real: ");
float real = float.Parse(Console.ReadLine());

Console.WriteLine($"A conversão de R$ {real:0.00} para dólar é US$ {real / 4.87f}\nPara euro é € {real / 5.21f}\nPara libra esterlina é £ {real / 6.13f}\nPara dólar canadense é C$ {real / 3.89f}\nPara peso argentino é $ {real / 0.04f}\nPara peso chileno é CLP$ {real / 0.0059f} ");
Console.ReadLine();