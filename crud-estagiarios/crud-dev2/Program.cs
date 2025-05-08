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

menu();