//CRUD EQUIPE 2 (THALES, NOALY, ICARO E ASPIRA)

//list string para todas as partes do crud, tudo deve ser adicionado, removido e atualizado dessa list.
using System.Diagnostics.Contracts;
using System.Net;
using System.Runtime.InteropServices.Marshalling;

List<string> nome = new List<string>();
int escolha = 0;

void menu()
{
    while(escolha != 5)
    { 
        Console.WriteLine("=====================================");
        Console.WriteLine("[1] - Adicionar item");
        Console.WriteLine("[2] - Editar item");
        Console.WriteLine("[3] - Remover item");
        Console.WriteLine("[4] - Listar itens");
        Console.WriteLine("[5] - Sair");
        Console.WriteLine("=====================================");
        if (!int.TryParse(Console.ReadLine(), out int escolha))
        {
            Console.WriteLine("Opção inválida");
        }
        {
            switch (escolha)
            {
                case 1:
                    {                      
                        //adcionar item
                        break;
                    }
                case 2:
                    {                      
                        //editar item
                        break;
                    }
                case 3:
                    {
                        //remover item
                        break;
                    }
                case 4:
                    {
                        //Listar
                        break;
                    } 
                case 5:
                    {
                        Environment.Exit(0);
                        break;
                    }
            }
        }
    }
}    

void Editar()
{
    if (items.Count == 0)
    {
        Console.WriteLine("Nenhum item para ser editado!");
        return;
    }
    Console.WriteLine("===== SUA LISTA =====");
    Console.WriteLine();
    int i = 0;
    foreach (var item in items)
    {
        Console.WriteLine($"[{i}] - {item}");
        i++;
    }
    Console.WriteLine("");
    Console.WriteLine("Digite a posição do item que deseja editar:");
    if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < items.Count)
    {
        Console.WriteLine("Digite o novo nome:");
        string novoNome = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(novoNome)) 
        {
            Console.Clear();
            items[indice] = novoNome;
            Console.WriteLine("Lista atualizada!");
            Thread.Sleep(500);
            Console.Clear();
            return;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Digite uma resposta válida!");
            Thread.Sleep(500);
            Console.Clear();
        }    
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Posição inválida!");
        Thread.Sleep(500);
        Console.Clear();   
    }
}

void Remover()
{
    if (items.Count == 0)
        {
            Console.WriteLine("Nenhum item para remover!");
            Thread.Sleep(1000);
            Console.Clear();
            return;
        }
        Console.WriteLine("===== SUA LISTA =====");
        Console.WriteLine();
        int i = 0;
        foreach (var item in items)
        {
            Console.WriteLine($"[{i}] - {item}");
            i++;
        }
        Console.WriteLine();
        Console.WriteLine("Informe a posição da despesa que deseja remover:");
        if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < items.Count)
        {
            items.RemoveAt(posicao);
            Console.Clear();
            Console.WriteLine("Despesa removida!");
            Thread.Sleep(500);
            Console.Clear();
            return;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Posição inválida!");
            Thread.Sleep(500);
            Console.Clear();
        }









}