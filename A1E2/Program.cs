Console.WriteLine("Topa conhecer um pouco das mulheres na tecnologia? \nEntão digite sim para continuar!");

string tecla = Console.ReadLine();

if (tecla == "sim")
{
    string nome = "Carol Shaw";
    string form = "engenheira computacional";
    string contrib = "primeira mulher desenvolvedora de jogos eletrônicos";

    Console.WriteLine($"Uma grande mulher na área da tecnologia é a {nome}\nEla é {form}\nAlém disso, foi a {contrib} do mundo!");

}
else
{
    Console.WriteLine("Que pena! Mas não se esqueça dos grandes feitos femininos na tecnologia!\nAté a próxima!");
}

Console.ReadLine();