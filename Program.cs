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

//AdivinhaCor();

//ABC();

//Aniversário();

//CriadorHistorias();

//JogadorDados();

//JogadorDadosImproviment();

//RPG();

//PrimeiraClass();

//SegundaClass();

Main();

void Main()
{

var aluno = new Aluno();

aluno.Nome = "Luna";
aluno.Idade = "10";
aluno.Nota = "A+";

aluno.Exibir();

}


void SegundaClass()
{

var flor = new Flor();

flor.Nome = "rosa";
flor.Cor = "roxo";
flor.Cheiro = "mel";

flor.Exibir();

var livro = new Livro();

livro.Nome = "harry potter";
livro.Autor= "j.k rowling";
livro.Grossura = "grosso";

livro.Exibir();


var eletrodomesticos = new Eletrodomesticos();

eletrodomesticos.Nome = "cadeira";
eletrodomesticos.Cor = "branco";
eletrodomesticos.Funçao = "sentar-se";

eletrodomesticos.Exibir();

}


void PrimeiraClass()
{

   var tomate = new Produto();

   tomate.Nome = "Tomate Vermelho";
   tomate.Preco = 12;
   tomate.Quantidade = 3;

   tomate.Exibir();

}


void RPG()
{

    string Play1;

    string Play2;

    string Play3;

    string Play4;


    string Play1name = H.CarregarValor<string>("Play1name.txt");

    string Play2name = H.CarregarValor<string>("Play2name.txt");

    string Play3name = H.CarregarValor<string>("Play3name.txt");

    string Play4name = H.CarregarValor<string>("Play4name.txt");


    string Play1nick = H.CarregarValor<string>("Play1nick.txt");

    string Play2nick = H.CarregarValor<string>("Play2nick.txt"); ;

    string Play3nick = H.CarregarValor<string>("Play4nick.txt"); ;

    string Play4nick = H.CarregarValor<string>("Play5nick.txt"); ;

    string choice;

    H.Write($"player 1 = {Play1name} - {Play1nick}");
    H.Write($"player 2 = {Play2name} - {Play2nick}");
    H.Write($"player 3 = {Play3name} - {Play3nick}");
    H.Write($"player 4 = {Play4name} - {Play4nick}");


    H.Write("Escolha seu numero:1📘, 2🐼, 3🥰, 4💛");

    choice = H.Read();

    H.Write("dijite seu nome e depois seu nickname sem  a c/s entos");

    if (choice == "1")
    {
        Play1name = H.Read();
        Play1nick = H.Read();
        H.SalvarValor("Play1name.txt", Play1name);
        H.SalvarValor("Play1nick.txt", Play1nick);
    }
    else
        if (choice == "2")
    {
        Play2name = H.Read();
        Play2nick = H.Read();
        H.SalvarValor("Play2name.txt", Play2name);
        H.SalvarValor("Play2nick.txt", Play2nick);
    }
    else
        if (choice == "3")
    {
        Play3name = H.Read();
        Play3nick = H.Read();
        H.SalvarValor("Play3name.txt", Play3name);
        H.SalvarValor("Play3nick.txt", Play3nick);
    }
    else
        if (choice == "4")
    {
        Play4name = H.Read();
        Play4nick = H.Read();
        H.SalvarValor("Play4name.txt", Play4name);
        H.SalvarValor("Play4nick.txt", Play4nick);
    }

    H.Write($"obrigado pela informação player {choice}🐋");

}


void JogadorDadosImproviment()
{

    int jogadasQt = 5000;

    int ladosQt = 6;

    int i = 0;

    Dictionary<int, int> jogadas = new Dictionary<int, int>();

    Dictionary<int, int> placar = new Dictionary<int, int>();

    int maior = 0;

    int menor = jogadasQt;

    int sortudo = 0;

    int azarado = jogadasQt;

    int anterior = 0;

    Dictionary<int, int> repetir = new Dictionary<int, int>(ladosQt);


    int maioria = 0;

    int menoria = jogadasQt;

    int maioriaqt = 0;

    int menoriaqt = jogadasQt;

    i = 0;
    string result = "";

    while (i <= jogadasQt)
    {
        jogadas[i] = H.Random(1, ladosQt);

        result = result + " " + jogadas[i];
        i = i + 1;
    }

    H.Write(result);

    i = 0;

    while (i <= jogadasQt)
    {
        int j = 0;
        while (j < ladosQt)
        {
            if (jogadas[i] == j + 1)
            {
                placar[j] = placar.GetValueOrDefault(j, 0) + 1;

                if (anterior == j)
                {
                    repetir[j] = repetir.GetValueOrDefault(j, 0) + 1;
                }
                anterior = j;
            }
            j = j + 1;
        }
        i = i + 1;
    }

    int z = 0;

    while (z < ladosQt)
    {
        H.Write($"placar {z} ={placar[z]}");

        if (maior < placar[z])
        {
            maior = placar[z];
            sortudo = 1;
        }


        if (menor > placar[z])
        {
            menor = placar[z];
            azarado = 1;
        }

        if (maioria < repetir[z])
        {
            maioria = repetir[z];
            maioriaqt = 1;
        }


        if (menoria > repetir[z])
        {
            menoria = repetir[z];
            menoriaqt = 1;
        }

        z = z + 1;

    }

    int a = 0;

    while (
    a < ladosQt
    )
    {


        H.Write($"o numero {a} se repitiu {repetir[a]} vezes segidas");
        a = a + 1;
    }

    H.Write($"maior:{maior}");

    H.Write($"menor:{menor}");

    H.Write($"sortudo: {sortudo}");

    H.Write($"azarado: {azarado}");

    H.Write($"quem repitiu mais foi o {maioriaqt}");

    H.Write($"quem repitiu menos vezes foi o {menoriaqt}");



}


void JogadorDados()
{

    int i = 0;

    List<int> jogadas = new List<int>();

    int placar1 = 0;
    int placar2 = 0;
    int placar3 = 0;
    int placar4 = 0;
    int placar5 = 0;
    int placar6 = 0;

    int maior = 0;

    int menor = 1000;

    int sortudo = 0;

    int azarado = 1000;

    int anterior = 0;

    int repetir1 = 0;
    int repetir2 = 0;
    int repetir3 = 0;
    int repetir4 = 0;
    int repetir5 = 0;
    int repetir6 = 0;

    int maioria = 0;

    int menoria = 1000;

    int maioriaqt = 0;

    int menoriaqt = 1000;

    int value = 5000;

    while (i <= value)
    {
        jogadas.Add(H.Random(1, 6));

        i = i + 1;
    }

    i = 0;

    string result = "";

    while (i <= value)
    {
        result = result + " " + jogadas[i];
        i = i + 1;

    }

    H.Write(result);

    i = 0;

    while (i <= value)
    {
        if (jogadas[i] == 1)
        {
            placar1 = placar1 + 1;
            if (anterior == 1)
            {
                repetir1 = repetir1 + 1;
            }
            anterior = 1;
        }
        if (jogadas[i] == 2)
        {
            placar2 = placar2 + 1;
            if (anterior == 1)
            {
                repetir2 = repetir2 + 1;
            }
            anterior = 2;
        }
        if (jogadas[i] == 3)
        {
            placar3 = placar3 + 1;
            if (anterior == 1)
            {
                repetir3 = repetir3 + 1;
            }
            anterior = 3;
        }
        if (jogadas[i] == 4)
        {
            placar4 = placar4 + 1;
            if (anterior == 1)
            {
                repetir4 = repetir4 + 1;
            }
            anterior = 4;
        }
        if (jogadas[i] == 5)
        {
            placar5 = placar5 + 1;
            if (anterior == 1)
            {
                repetir5 = repetir5 + 1;
            }
            anterior = 5;
        }
        if (jogadas[i] == 6)
        {
            placar6 = placar6 + 1;
            if (anterior == 1)
            {
                repetir6 = repetir6 + 1;
            }
            anterior = 6;
        }
        i = i + 1;


    }
    H.Write($"placar1={placar1}");
    H.Write($"placar2={placar2}");
    H.Write($"placar3={placar3}");
    H.Write($"placar4={placar4}");
    H.Write($"placar5={placar5}");
    H.Write($"placar6={placar6}");

    if (maior < placar1)
    {
        maior = placar1;
        sortudo = 1;
    }
    if (maior < placar2)
    {
        maior = placar2;
        sortudo = 2;
    }
    if (maior < placar3)
    {
        maior = placar3;
        sortudo = 3;
    }
    if (maior < placar4)
    {
        maior = placar4;
        sortudo = 4;
    }
    if (maior < placar5)
    {
        maior = placar5;
        sortudo = 5;
    }
    if (maior < placar6)
    {
        maior = placar6;
        sortudo = 6;
    }

    if (menor > placar1)
    {
        menor = placar1;
        azarado = 1;
    }
    if (menor > placar2)
    {
        menor = placar2;
        azarado = 2;
    }
    if (menor > placar3)
    {
        menor = placar3;
        azarado = 3;
    }
    if (menor > placar4)
    {
        menor = placar4;
        azarado = 4;
    }
    if (menor > placar5)
    {
        menor = placar5;
        azarado = 5;
    }
    if (menor > placar6)
    {
        menor = placar6;
        azarado = 6;
    }


    if (maioria < repetir1)
    {
        maioria = repetir1;
        maioriaqt = 1;
    }
    if (maioria < repetir2)
    {
        maioria = repetir2;
        maioriaqt = 2;
    }
    if (maioria < repetir3)
    {
        maioria = repetir3;
        maioriaqt = 3;
    }
    if (maioria < repetir4)
    {
        maioria = repetir4;
        maioriaqt = 4;
    }
    if (maioria < repetir5)
    {
        maioria = repetir5;
        maioriaqt = 5;
    }
    if (maioria < repetir6)
    {
        maioria = repetir6;
        maioriaqt = 6;
    }


    if (menoria > repetir1)
    {
        menoria = repetir1;
        menoriaqt = 1;
    }
    if (menoria > repetir2)
    {
        menoria = repetir2;
        menoriaqt = 2;
    }
    if (menoria > repetir3)
    {
        menoria = repetir3;
        menoriaqt = 3;
    }
    if (menoria > repetir4)
    {
        menoria = repetir4;
        menoriaqt = 4;
    }
    if (menoria > repetir5)
    {
        menoria = repetir5;
        menoriaqt = 5;
    }
    if (menoria > repetir6)
    {
        menoria = repetir6;
        menoriaqt = 6;
    }


    H.Write($"maior:{maior}");

    H.Write($"menor:{menor}");

    H.Write($"sortudo: {sortudo}");

    H.Write($"azarado: {azarado}");

    H.Write($"quem repitiu mais foi o {maioriaqt}");

    H.Write($"quem repitiu menos vezes foi o {menoriaqt}");

    H.Write($"o numero um se repitiu {repetir1} vezes segidas");

    H.Write($"o numero dois se repitiu {repetir2} vezes seguidas");

    H.Write($"o numero tres se repitiu {repetir3} vezes segidas");

    H.Write($"o numero quatro se repitiu {repetir4} vezes segidas");

    H.Write($"o numero cinco se repitiu {repetir5} vezes segidas");

    H.Write($"o numero seis se repitiu {repetir6} vezes segidas");

}


void CriadorHistorias()
{

    string sair;

    List<string> lugar = new List<string> { "na praia", "no parque", "na floresta", "no deserto", "no mar" };

    List<string> persona = new List<string> { "havia um homem", "havia uma mulher", "havia um cão", "havia uma menina", "havia um ladrão" };

    List<string> acao = new List<string> { "que queria ficar rico/a", "que queria comer até não aguentar", "que queria brincar", "que queria sorrir", "que queria dançar" };

    List<string> final = new List<string> { "viveu feliz para sempre", "morreu de velhiçe", "encontrou um livro mágico", "seu cabelo nao parou de crescer e o planeta terra ficou cabeludo", "comeu e bebeu até o fim da sua vida" };

    while (true)
    {

        int i1 = H.Random(0, 4);

        int i2 = H.Random(0, 4);

        int i3 = H.Random(0, 4);

        int i4 = H.Random(0, 4);

        H.Write(lugar[i1]);

        H.Write(persona[i2]);

        H.Write(acao[i3]);

        H.Write(final[i4]);

        H.Write("vc quer sair");

        sair = H.Read();

        if (sair == "sim")
        {

            break;

        }

    }

}


void Aniversário()
{

    DateTime date = DateTime.Now;

    DateTime now = DateTime.Now;

    int anos = 0;

    int mes = 0;

    int dia = 0;

    H.Write(" quantos anos vc tem?");

    anos = H.ReadInt();

    H.Write("qual é o mês do seu aniversário?");

    mes = H.ReadInt();

    H.Write(" que dia é seu niver?");

    dia = H.ReadInt();

    if (mes > now.Month)
    {
        anos = anos + 1;
    }
    else
    if (mes == now.Month && now.Day < dia)
    {

        anos = anos + 1;

    }

    date = new DateTime(now.Year - anos, mes, dia);

    H.Write($"vc naceu no ano de {date.Year}");

    H.Write($"vc naceu numa {date.DayOfWeek}");

}


void ABC()
{

    List<string> abc = new List<string> {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p",
    "q","r","s","t","u","v","w","x","y","z"};

    int escolhido = 0;

    int i = 0;

    H.Write("dijite a posisão da letra do abc que vc quer que apareça");

    escolhido = H.ReadInt();

    escolhido = escolhido - 1;

    H.Write(abc[escolhido]);

    while (i < 26)
    {

        H.Write(abc[i]);

        i = i + 1;

    }

}


void AdivinhaCor()
{

    List<string> cores = new List<string> { "amarelo", "verde", "azul", "roxo", "rosa", "laranja" };

    List<string> dicas = new List<string> { "sol", "arvore", "céu", "berinjela", "flamingo", "laranjinha" };

    List<string> respostas = new List<string> {"acertou era amarelo","acertou era verde","acertou era azul",
    "acertou era roxo","acertou era rosa","acertou era laranja"};

    string cor;

    int i = 0;

    int random = H.Random(0, 5);

    H.Write("QUAL COR FOI SORTEADA?");

    H.Write(dicas[random]);

    while (i < 6)
    {

        H.Write(cores[i]);

        i = i + 1;

    }

    cor = H.Read();

    if (cor == cores[random])
    {

        H.Write(respostas[random]);

    }
    else
    {
        H.Write("vc perdeu");
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

    H.Write("dijite dois numeros para se multiplicarem 😄");

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

        H.Write("Para jogar CRIADORHISTÓRIAS digite 1 ");
        H.Write("Para jogar ANIVERSÁRIO digite 2");
        H.Write("Para jogar ABC digite 3");
        H.Write("Para jogar ADIVINHACOR digite 4");
        H.Write("Para jogar LISTANOMES digite 5");
        H.Write("Para jogar ADIVINHAANIMAL digite 6");
        H.Write("Para jogar SENHORIA digite 7");
        // H.Write ("Para jogar JOGINHO digite 8");
        H.Write("Para jogar DUPLICAR digite 9");
        // H.Write ("Para jogar SOMA digite 10");
        H.Write("Para jogar ESTRELINHAS digite 11");
        H.Write("Para jogar PLAYER digite 12");
        H.Write("Para jogar N123 digite 13");
        H.Write("Para jogar CALCULADORA digite 14");
        H.Write("Para jogar CONTADOR digite 15");
        H.Write("Para jogar Vezes digite 16");
        H.Write("Para jogar GostaDeAnime digite 17");
        H.Write("Para jogar Adivinha digite 18");
        H.Write("Para jogar Jogo digite 19");
        H.Write("Para jogar QualAnimal digite 20");
        H.Write("Para jogar Question digite 21");

        //H.Write (" Vezes GostaDeAnime Adivinha Jogo QualAnimal Question");

        H.Write("Você quer sair? Digite 0.");
        sair = H.Read();
        if (sair == "0")
        {
            sair = sair;
        }
        else
            if (sair == "1")
        {
            CriadorHistorias();
        }
        else
                if (sair == "2")
        {
            Aniversário();
        }
        else
                    if (sair == "3")
        {
            ABC();
        }
        else
                    if (sair == "4")
        {
            AdivinhaCor();
        }
        else
                    if (sair == "5")
        {
            ListaNomes();
        }
        else
                    if (sair == "6")
        {
            Adivinhaanimal();
        }
        else
                    if (sair == "7")
        {
            Senhoria();
        }
        else
                    if (sair == "8")
        {

        }
        else
                    if (sair == "9")
        {
            Duplicar();
        }
        else
                    if (sair == "10")
        {

        }
        else
                    if (sair == "11")
        {
            Estrelinhas();
        }
        else
                    if (sair == "12")
        {
            Player();
        }
        else
                    if (sair == "13")
        {
            N123();
        }
        else
                    if (sair == "14")
        {
            Calculadora();
        }
        else
                    if (sair == "15")
        {
            Contador();
        }
        else
                    if (sair == "16")
        {
            Vezes();
        }
        else
                    if (sair == "17")
        {
            GostaDeAnime();
        }
        else
                    if (sair == "18")
        {
            Adivinha();
        }
        else
                    if (sair == "19")
        {
            Jogo();
        }
        else
                    if (sair == "20")
        {
            QualAnimal();
        }
        else
                    if (sair == "21")
        {
            Question();
        }

    }

    H.Write("Conseguiu sair! Volte logo! 😄");

}


void Vezes()
{

    string saiu = "n";

    int point = 0;

    int cont = 0;

    int recorde = H.CarregarValor<int>("recorde.txt");

    string vencedor = H.CarregarValor<string>("vencedor.txt");

    H.Write($"o vencedor atual é: {vencedor}");
    H.Write($"o recorde atual é: {recorde}");

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

    if (point > recorde)
    {

        H.Write("parabéns vc bateu o recorde, escreva seu nome");

        vencedor = H.Read();

        H.Write($"{vencedor} {point}");

        H.SalvarValor("vencedor.txt", vencedor);
        H.SalvarValor("recorde.txt", point);
    }
    else
    {
        H.Write($"o vencedor atual é: {vencedor}");
        H.Write($"o recorde atual é: {recorde}");
    }

}


void GostaDeAnime()
{
    string people;

    Console.WriteLine("vc gosta de anime? sim/não");

    people = Console.ReadLine();

    if (people.ToUpper() == "SIM")
    {
        //Console.WriteLine("nossa eu também(ºUº)");

        string qual;

        Console.WriteLine("de qual?");

        qual = Console.ReadLine();
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

        oque = Console.ReadLine();

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

class Pessoa
{
    public string name;
    public int age;
    public double height;
    public double weight;
    public string eyeColor;
    public string hairColor;
}


class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public void Exibir(){
        Console.WriteLine(Nome);
        Console.WriteLine(Preco);
        Console.WriteLine(Quantidade);
    }
}

class Flor
{
    public string Nome;
    public string Cor;
    public string Cheiro;

    public void Exibir()
    {
        Console.WriteLine(Nome);
        Console.WriteLine(Cor);
        Console.WriteLine(Cheiro);
    }
}
class Livro
{
    public string Nome;
    public string Autor;
    public string Grossura;

    public void Exibir()
    {
        Console.WriteLine(Nome);
        Console.WriteLine(Autor);
        Console.WriteLine(Grossura);
    }
}
class Eletrodomesticos
{
    public string Nome;
    public string Cor;
    public string Funçao;

    public void Exibir()
    {
        Console.WriteLine(Nome);
        Console.WriteLine(Cor);
        Console.WriteLine(Funçao);
    }
}

class Aluno
{

public string Nome;
public string Idade;
public string Nota;

public void Exibir()
{
    Console.WriteLine(Nome);
    Console.WriteLine(Idade);
    Console.WriteLine(Nota);
}

}