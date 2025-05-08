﻿static void Remover(List<string> lista)
{
    bool eValido = true;
    int idx;
    
    if (lista.Count == 0)
    {
        Console.WriteLine("A lista esta vazia. Nao ha nada para apagar!");
        Console.WriteLine("Digite algo para continuar...");
        Console.ReadKey(true);
        return;
    }

    while (true)
    {
        Console.WriteLine("Digite o indice da pessoa que voce gostaria de remover!");
        eValido = int.TryParse(Console.ReadLine(), out idx);    
        
        if ((idx >= lista.Count) | (idx < 0) | !eValido)
        {
            Console.WriteLine("Indice invalido!\nDigite algo para continuar...");
            Console.ReadKey();
            continue;
        }

        lista.RemoveAt(idx);
        return;
    }
}