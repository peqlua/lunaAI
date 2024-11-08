
//QualAnimal();

//Question();

//Jogo();

//Adivinha();

//GostaDeAnime();

//Vezes();

//Iniciador();

//Contador();

//Calculadora();

//N123();

//Player();

//Estrelinhas();

//int v = Soma(100,45);
//H.Write ($"soma = {v}");

//Duplicar();

//H.Write("sim ou não");

//string decisao = H.Read();
//Joguinho(decisao);

//Senhoria();

//Adivinhaanimal();

//List<string> nomes = new List<string> { "Joao", "aa", "pp", "Zaza", "zuzu" };

//ListaNomes();

AdivinhaCor();


void AdivinhaCor()
{

    List<string> cores = new List<string> { "amarelo", "verde", "azul", "roxo", "rosa", "laranja" };

    string cor;

    int i = 0;

    int random = H.Random(0, 5);

    H.Write("QUAL COR FOI SORTEADA?");
H.Write(random);

    while (i < 6)
    {

        H.Write (cores[i]);

        i = i + 1 ;

    }

    cor = H.Read();

    if (cor == cores[random])
    {

        H.Write("vc venceu");

    }
    else 
    {
        H.Write ("vc perdeu");
    }

}


void ListaNomes()
{

    List<string> nomes = new List<string> { "João", "Maria", "e", "a", "Dona Cutia" };

    int ident = 0;

    int randomic = H.Random(0, 4);

    while (ident < 5)
    {

        H.Write(nomes[ident]);

        ident = ident + 1;

    }

    H.Write("o vencedor é " + nomes[randomic]);

}


void Adivinhaanimal()
{

    string animal = "canguru ";

    string tentativa;

    int rodada = 0;

    H.Write("qual é o animal que estou pensando?");

    while (true)
    {

        rodada = rodada + 1;

        tentativa = H.Read();

        if (tentativa == "canguru")
        {

            H.Write("vc ganhou");

            break;

        }
        else
        {

            H.Write($"vc errou na rodada {rodada}");

            if (rodada == 1)
            {

                H.Write("é grande");

            }
            else
            if (rodada == 2)

            {

                H.Write("é castanho");

            }
            else
            if (rodada == 3)

            {

                H.Write("tem orelhas grandes");

            }
            else
            if (rodada == 4)

            {

                H.Write("tem uma pernona");

            }
            else
            if (rodada == 5)

            {

                H.Write("tem pelo");

            }
            else
            {

                H.Write("perdeu era canguru");

                break;

            }

        }

    }

}


void Senhoria()
{

    string pessoas;

    string letra;

    string first = "";

    string saudacao = "";

    H.Write("Qual é o seu nome?");

    pessoas = H.Read();

    letra = pessoas.Last().ToString();

    first = pessoas.First().ToString();

    if (letra == "a")
    {

        saudacao = "senhora";

    }
    else
    if (letra == "o")
    {

        saudacao = "senhor";

    }

    H.Write($"Bem vindo ao meu programa {saudacao} grande {first} {pessoas}");

}


void Joguinho(string decisao)
{

    if (decisao == "s")
    {

        H.Write(@" 
 ____ ___ __  __ 
/ ___|_ _|  \/  |
\___ \| || |\/| |
 ___) | || |  | |
|____/___|_|  |_|");

    }
    if (decisao == "n")
    {
        H.Write(@" 
            _   _  /\/| ___  
           | \ | ||/\/ / _ \ 
           |  \| | /_\| | | |
           | |\  |/ _ \ |_| |
           |_| \_/_/ \_\___/ ");
    }

}


void Duplicar()
{

    int pessoa;

    int person = H.ReadInt();

    pessoa = Duplicador(person);

    H.Write($"{pessoa}");

}


int Duplicador(int num)
{

    int vzs;

    vzs = num * 2;

    return vzs;

}


int Soma(int n1, int n2)
{
    return n1 + n2;
}


void Estrelinhas()
{

    H.Write("#####################################################");

}


void Player()
{

    int value = 0;

    int total = 0;

    while (true)
    {

        value = H.ReadInt();

        total = total + value;

        if (value == 0)
        {

            break;

        }

    }

    H.Write($"SUA CONTA {total}$/£ SENHOR/SENHORITA");

}


void N123()
{
    int total = 0;
    int value = 0;


    H.Write("Digite os valores e de <ENTER> ou ZERO para sair.");

    while (true)
    {
        value = H.ReadInt();
        total = total + value;

        if (value == 0)
        {
            break;
        }
    }

    H.Write($"TOTAL: {total}");
}


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