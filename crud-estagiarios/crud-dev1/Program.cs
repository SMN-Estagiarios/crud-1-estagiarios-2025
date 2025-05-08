// Crud-dev1-alvaro-editar

using System;
using System.Collections.Generic;

// Método Editar/Atualizar
void Editar(List<string> lista)
{
    Console.Clear();
    Console.WriteLine("==== MENU DE EDIÇÃO ====\n");

    if ( lista.Count < 1)
    {
        Console.WriteLine("Não há perfis cadastrados");
    }

    while (true)
    {
        Console.WriteLine("Digite o nome que deseja atualizar\n");
        string nome = Console.ReadLine();

        if (lista.Contains(nome))
        {
            int indice = lista.IndexOf(nome);
            Console.WriteLine("Nome encontrado!\n");

            Console.Write("Digite o novo nome: ");
            string novoNome = Console.ReadLine();

            lista[indice - 1] = novoNome;

            Console.Clear();
            Console.WriteLine("\nNome atualizado!");
            break;
        }
        else
        {
            Console.WriteLine("Nome inválido ou não encontrado!\n");
            break;
        }
    }
}
