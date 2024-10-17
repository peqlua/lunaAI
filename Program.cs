
//QualAnimal();
//Question();
//Jogo();
//Adivinha();

void Adivinha()
{


    string people;

    Console.WriteLine("adivinhe um numero de 1 a 5");

    people = Console.ReadLine();

    if (people == Random(1, 5))
    {
        Console.WriteLine("acertou");
    }
    else
    {
        Console.WriteLine("errou");
    }
}
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

static string Random(int first, int end)
{
    var random = new Random();
    return random.Next(first, end + 1) + "";
}