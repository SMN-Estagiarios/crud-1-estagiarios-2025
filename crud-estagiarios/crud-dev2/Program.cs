List<string> itens = new List<string>();


void VisualizarItens(List<string> itens)
{
    Console.Clear();
    Console.WriteLine("Você escolheu visualizar itens\n");

    if (itens.Count == 0)
    {
        Console.WriteLine("Você não possui tarefas cadastradas.");
    }
    else
    {
        Console.WriteLine("Segue abaixo as tarefas cadastradas:\n");
        foreach (string item in itens)
            Console.WriteLine("- " + item);
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
    Console.ReadKey();
}