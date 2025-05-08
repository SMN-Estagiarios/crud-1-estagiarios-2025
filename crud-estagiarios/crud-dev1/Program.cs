using System.Security.AccessControl;

static void Menu(List<string> lista)
{
    string opcao = "";
    while (opcao != "5")
    {
        Console.Clear();
        Console.WriteLine("Qual das opções abaixo voce gostaria de realizar:\n"
                                + "\n1 - CADASTRAR"
                                + "\n2 - EDITAR "
                                + "\n3 - DELETAR"
                                + "\n4 - EXIBIR"
                                + "\n5 - SAIR");
        
        opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1":
                Cadastrar(lista);
                break;
            case "2":
                Editar(lista);
                break;
            case "3":
                Remover(lista);
                break;
            case "4":
                Listar(lista);
                break;
            case "5":
                Console.WriteLine("Saindo...");
                Thread.Sleep(2000);
                break;
            default:
                Console.WriteLine("Opcao invalida!");
                Console.WriteLine("Digite algo para continuar...");
                Console.ReadKey(true);
                break;
        }
    }
}