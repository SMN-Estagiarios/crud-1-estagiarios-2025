REQUISITO NOMECLATURA DO BRANCH: Nome usuário: (equipeNumero) (pilar escolhido do crud)


1. DESCRIÇÃO GERAL
Este projeto consiste na criacao de um sistema CRUD simples em C# com estrutura procedural, sem uso de
Programacao Orientada a Objetos. O sistema permite que o usuario cadastre, visualize, edite e remova
nomes de uma lista, por meio de um menu interativo no console.

2. OBJETIVO DO PROJETO
- Exercitar logica de programacao com foco em CRUD.
- Desenvolver funcionalidades utilizando listas.
- Aprender a trabalhar com funcoes, entradas de dados e controle de fluxo.
- Simular a estrutura basica de um software de cadastro.

3. DIVISÃO DE RESPONSABILIDADES EQUIPE 1
Create (Cadastrar) - Integrante 1
Read (Listar) - Integrante 2
Update (Editar) - Integrante 3
Delete (Remover) - Integrante 4
4. Estrutura Funcional do Sistema

DIVISÃO DE RESPONSABILIDADES EQUIPE 2
Create (Cadastrar) - Integrante 1
Read (Listar) - Integrante 2
Update (Editar) - Integrante 3
Delete (Remover) - Integrante 4

4. ESTRUTURA FUNCIONAL DO SISTEMA
O programa e controlado por um menu principal que utiliza switch-case. Os dados sao armazenados em
uma lista de strings, simulando um banco de dados em memoria.


5. LISTA DE VARIÁVEIS
- lista: List<string> - Lista principal onde os nomes sao armazenados.
- opcao: int - Controla o fluxo do menu principal.
- nome: string - Armazena o nome digitado para cadastro.
- i: int - Indice do laco de repeticao para listagem.
- indice: int - Numero escolhido para editar ou remover.
- novoNome: string - Novo nome que substituira um existente


- 6. LISTA DE FUNÇÕES
- Cadastrar(List<string> lista): Adiciona um novo nome a lista.
- Listar(List<string> lista): Mostra todos os nomes cadastrados.
- Editar(List<string> lista): Altera um nome existente na lista.
- Remover(List<string> lista): Exclui um nome da lista.

- 
7. FLUXO DE EXECUÇÃO
  -O menu e exibido.
  -O usuario escolhe uma opcao.
  -A funcao correspondente e executada.
  -O menu reaparece ate que o usuario escolha sair.
  - Observacoes Finais

9. SOBRE O CÓDIGO
- Codigo procedural, sem uso de classes ou objetos.
- Dados nao sao salvos em arquivos (nao persistentes).
- Uso de TryParse para evitar erros com entrada invalida.
