
using DemoRefStruct;

Pessoa p1 = new Pessoa();

p1.Nome = "Marcelo";
p1.Idade = 30;
p1.EnderecoPessoa = new Endereco()
{
    Logradouro = "Rua Teste",
    Numero = 300,
    CEP = "00000-000",
    Cidade = "Cotia",
};

Console.WriteLine("Fim");
