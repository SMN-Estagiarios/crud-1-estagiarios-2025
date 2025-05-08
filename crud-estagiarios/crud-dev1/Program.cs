list<string> lista = new list<string>;
int contador = 1;

void cadastro()
{

    Console.WriteLine("Digite o nome:");
    nomeCadastro = Console.ReadLine();

    Console.WriteLine("Digite a idade:");
    nomeIdade = Console.ReadLine();

    lista[contador] = (nomeCadastro, nomeIdade);

    contador++;
    
}

void lista()
{
    contador = 1;

    foreach (var i in lista)
    {

        Console.WriteLine(lista[contador]);
        contador++;
    }



}