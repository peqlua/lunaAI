
//QualAnimal();
//Question();
//Jogo();
//Adivinha();
//GostaDeAnime();
Vezes();
//Iniciador();
//Contador();
//Calculadora();

void Calculadora()
{

    int n1 = 0;

    int n2 = 0;

 n1 = H.ReadInt();

    n2 = H.ReadInt();

    int resposta = n1 * n2;

    H.Write($"{resposta}");

}


void Contador()
{

    int numeros = 2;
    while (numeros < 501)
    {
        H.Write(numeros);
        numeros = numeros + 2;

    }

}


void Iniciador()
{

    string sair = "n";

    while (sair == "n")
    {

        GostaDeAnime();
        H.Write("vc quer sair");
        sair = H.Read();
    }

    H.Write("vc conseguiu sair");

}


void Vezes()
{

    string saiu = "n";

    int point = 0;

    int cont = 0;

    while (saiu == "n")
    {
        int resposta;

        int numero1 = H.Random(1, 9);

        int numero2 = H.Random(1, 9 + point);

        int result = numero1 * numero2;

        H.Write($"quanto é {numero1} vezes {numero2} ?");

        resposta = H.ReadInt();

        if (resposta == result)
        {
            H.Write($"vc ganhou era {result} (:");
            point = point + 1;
            cont = cont + 1;
        }
        else
        {
            H.Write($"vc perdeu era {result} ):");
            saiu = "s";
        }

        if (cont == 3)
        {
            H.Write($"Vc ja acertou {point} vezes");
            cont = 0;
        }


        //H.Write ("vc quer saire?");
        //saiu = H.Read();
    }



    H.Write($"vc saiu e acertou {point} vezes");

}


void GostaDeAnime()
{
    string people;

    Console.WriteLine("vc gosta de anime? sim/não");

    people = (Console.ReadLine());

    if (people.ToUpper() == "SIM")
    {
        //Console.WriteLine("nossa eu também(ºUº)");

        string qual;

        Console.WriteLine("de qual?");

        qual = (Console.ReadLine());
        qual = qual.ToUpper();
        if (qual == "ONE PIECE" || qual == "SPY X FAMILY" || qual == "LOVE IS WAR" || qual == "NARUTO" || qual == "MY LITLE WICH ACADEMIA" || qual == "ASASINATION CLASSROOM")
        {
            Console.WriteLine("nossa eu também(ºUº)");
        }
        else
        {
            Console.WriteLine("SEU BURRO VC NÃO ASSISTE ANIMES BONS É ?!?!");
        }
    }
    else
    {
        // Console.WriteLine("SEU BURRO VC NÃO ASSISTE ANIME É ?!?!");
        string oque;

        Console.WriteLine("de desenho animado vc gosta então?");

        oque = (Console.ReadLine());

        if (oque.ToUpper() == "CARROSEL")
        {
            Console.WriteLine("nossa eu também/(ºUº)/");
        }
        else
        {
            Console.WriteLine("SEU BURRO VC NÃO ASSISTE CARROSEL É ?!?!");
        }
    }
}


void Adivinha()
{


    string peple;

    Console.WriteLine("adivinhe um numero de 1 a 5");

    peple = Console.ReadLine();

    if (peple == (H.Random(1, 5) + ""))
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


