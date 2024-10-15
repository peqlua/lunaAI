
//QualAnimal();
//Question();

Jogo();




void Jogo()
{
    string sair = "";

    Console.WriteLine("vc quer sair, s ou n ?");

sair = Console.ReadLine();

    if (sair == "sim")
    {
        Console.WriteLine("vc saiu pisoa");
    }
    else
    {
        Console.WriteLine("continuou pisoa");
    }
}


void QualAnimal()
{

    string animal = " ";

    Console.WriteLine("adivinhe um animal é grande");

    animal = Console.ReadLine();

    if (animal == "elefante")
    {
        Console.WriteLine("parabens vc venceu");
    }

    else
    {
        Console.WriteLine("não era esse animal");
    }


}


void Question()
{
    int toys;

    int age = 9;

    string name;

    Console.WriteLine("digite seu nome");

    name = Console.ReadLine();

    Console.WriteLine("digite sua quantidade de brinquedos que seje numeros");

    toys = int.Parse(Console.ReadLine());

    //string result = $"a Luna tem{age}";

    //Console.WriteLine(result);

    if (toys >= 20)
    {
        Console.WriteLine($"papabéns {name} vc é RICO");
    }

    else if (toys >= 15)
    {
        Console.WriteLine($"vc é bem pago");
    }

    else
    {
        Console.WriteLine($" vc é muito pobre {name} vc só tem {toys} brinquedos kkkkkkkkkkk");
    }

}
