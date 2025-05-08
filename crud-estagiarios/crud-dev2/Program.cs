List<string> itens = new List<string>();

void Cadastrar()
{
    Console.Write("Insira um item: ");
    string item = Console.ReadLine();
    itens.Add(item);
}
