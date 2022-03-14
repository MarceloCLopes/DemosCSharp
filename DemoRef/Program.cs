using static System.Console;

static void Demo1()
{
    int a = 5;
    Adicionar20(ref a);
    WriteLine($"O valor de a é {a}!");
}

static void Adicionar20(ref int a)
{
    a += 20;
}

static void Demo2()
{
    var nomes = new string[] {"Marcelo", "David", "Guilherme", "Matheus" };
    WriteLine($"Lista de nomes: {string.Join(", ", nomes)}\n");

    WriteLine("Digite o nome a ser substituído");
    var nome = ReadLine();
    WriteLine("\nDigite o novo nome:");
    var novoNome = ReadLine();

    AlterarNome(nomes, nome, novoNome);
    WriteLine($"\nLista de nomes alterada: {string.Join(", ", nomes)}");
}

static void AlterarNome(string[] nomes, string nome, string nomeNovo)
{
    for (int i = 0; i < nomes.Length; i++)
    {
        if (nomes[i] == nome)
        {
            nomes[i] = nomeNovo;
        }
    }
}


static void Demo3()
{
    var nomes = new string[] { "Marcelo", "David", "Guilherme", "Matheus" };
    WriteLine($"Lista de nomes: {string.Join(", ", nomes)}\n");

    WriteLine("Digite o nome a ser substituído");
    var nome = ReadLine();
    WriteLine("\nDigite o novo nome:");
    var novoNome = ReadLine();

    ref var nomeAchado = ref LocalizarNome(nomes, nome);

    if (!string.IsNullOrWhiteSpace(nomeAchado))
    {
        nomeAchado = novoNome;
        WriteLine($"\nLista de nomes alterada: {string.Join(", ", nomes)}");
    }
    else
    {
        WriteLine("Nome não encontrado");
    }
}

static ref string LocalizarNome(string[] nomes, string nome)
{
    for (int i = 0; i < nomes.Length; i++)
    {
        if (nomes[i] == nome)
        {
            return ref nomes[i];
        }
    }
    throw new Exception("Nome não encontrado.") ;
}

//Demo1();
//Demo2();
Demo3();