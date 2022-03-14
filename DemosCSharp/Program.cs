namespace DemosCSharp
{
    public class Program
    {
        static void Demo1()
        {
            int a = 2;
            a = Adicionar20(a);

            Console.WriteLine($"O valor da variável é {a}");
        }
        static int Adicionar20(int x) 
        { 
            return x + 20; 
        }

        static void Demo2()
        {
            Pessoa p1 = new ();
            p1.Nome = "Marcelo";
            p1.Idade = 46;
            p1.Documento = "1234";

            Pessoa p2 = p1.Clone();

            TrocarNome(p1, "David");

            Console.WriteLine($@"
                O nome de p1 é: {p1.Nome}
                O nome de p2 é: {p2.Nome}
            ");
        }

        static void TrocarNome(Pessoa p1, string nomeNovo)
        {
            p1.Nome = nomeNovo;
        }

        static void Demo3()
        {
            StructPessoa p1 = new()
            {
                Nome = "Marcos",
                Idade = 30,
                Documento = "0987"
            };

            var p2 = p1;

            //p1 = TrocarNome(p1, "João");

            Console.WriteLine($@"
                Nome do p1 é {p1.Nome}
                Nome do p2 é {p2.Nome}
            ");
        }

        static void TrocarNome(StructPessoa p1, string nomeNovo)
        {
            p1.Nome = nomeNovo;
        }

        static void Demo4(){
            string nome = "Marcelo";

            TrocarNome(nome, "José");
            Console.WriteLine($"O novo é {nome}");
        }

        static void TrocarNome(string nome, string nomeNovo)
        {
            nome = nomeNovo;
        }

        static void Demo5(){
            var pares = new int[]{0, 2, 4, 6, 8};
            MudarParaImpar(pares);
            Console.WriteLine($"Os ímpares {string.Join(",", pares)}"); 
        }

        static void MudarParaImpar(int[] pares)
        {
            for (int i = 0; i < pares.Length; i++)
            {
                pares[i] = pares[i] + 1;
            }
        }

        static void Demo6(){
            int[] numeros = new int[]{0, 2, 4, 6, 8};
            System.Console.WriteLine($"Digite o número que gostaria de encontrar");
            var numero = int.Parse(Console.ReadLine());
            var idxEncontrado = EncontrarNumero(numeros, numero);

            if(idxEncontrado >= 0){
                Console.WriteLine($"O número digitado está na posição{idxEncontrado}");
            } else{
                Console.WriteLine("O número digitado não foi encontrado");
            }
        }

        static int EncontrarNumero(int[] numeros, int numero)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numero)
                {
                    return i;
                }               
            }
            return -1;
        }

        static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa){
            foreach (var item in pessoas)
            {
                if (item.Nome == pessoa.Nome)
                {
                    return true;
                }
            }
            return false;
        }

        static bool EncontrarPessoa(List<StructPessoa> pessoas, StructPessoa pessoa)
        {
            foreach (var item in pessoas)
            {
                if (item.Equals(pessoa))
                {
                    return true;
                }
            }
            return false;
        }

        static void Demo7()
        {
            List<StructPessoa> pessoas = new()
            {
                new StructPessoa() { Nome = "Marcelo" },
                new StructPessoa() { Nome = "Maria" },
                new StructPessoa() { Nome = "David" },
                new StructPessoa() { Nome = "Rafael" },
                new StructPessoa() { Nome = "Gabriel" },
            };

            Console.WriteLine("Digite a pessoa que gostaria de localizar:");
            var nome = Console.ReadLine();
            var pessoa = new StructPessoa() { Nome = nome };
            var encontrado = EncontrarPessoa(pessoas, pessoa);
            if (encontrado)
            {
                Console.WriteLine("Pessoa localizada!");
            }
            else
            {
                Console.WriteLine("Pessoa não localizada!");
            }
        }

        public static void Main()
        {
            //Demo1();
            //Demo2();
            //Demo3();
            //Demo4();
            //Demo5();
            //Demo6();
            Demo7();
                    
        }
    }
}