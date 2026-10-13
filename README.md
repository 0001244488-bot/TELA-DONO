# Sistema de Pets e Donos (Windows Forms / .NET 10)

Este branch integra as telas do projeto **Trabalho-de-pets-** com a tela original de cadastro de donos do projeto **TELA-DONO**.

## Ordem de navegação

1. **Form1** — login do sistema de pets.
2. **Form2** — menu; o botão **CRUD PET** abre o cadastro dos animais.
3. **Form3** — cadastro, consulta, alteração e exclusão de pets.
4. **CRUD DONOS** — botão na tela de pets que abre a tela original do dono. O botão **CRUD DONO DO PET** no menu também abre a tela de donos.

A tela original de donos foi mantida. Seu repositório de dados foi adaptado para MySQL, usando a mesma tabela `donos` consultada pelo cadastro de pets; assim, os donos cadastrados podem ser selecionados ao registrar um animal.

## Abrir

Abra `TELA DONO.slnx` no Visual Studio 2026 / .NET 10 e restaure os pacotes NuGet.

## Configurar o MySQL

O sistema usa o banco local `petshop_tecnico`. Para não deixar senha exposta no código, a aplicação lê a variável de ambiente `PETSHOP_CONNECTION_STRING`.

Exemplo de valor (substitua pela sua senha local; não envie esse valor ao GitHub):

```
server=localhost;database=petshop_tecnico;uid=root;pwd=SUA_SENHA;
```

No Windows, crie a variável de ambiente antes de iniciar o Visual Studio, ou ajuste a configuração localmente no arquivo `TELA DONO/Pets/ConfiguracaoBanco.cs` sem publicar sua senha. Se seu MySQL usa senha vazia, o fallback já está definido.

O repositório cria a tabela `donos` caso ela não exista e acrescenta os campos auxiliares ausentes. Faça backup do banco antes de testar alterações. Não exclua donos associados a pets.

## Nota sobre recursos visuais

Os arquivos de recursos binários muito grandes do projeto original não foram importados nesta branch; as telas mantêm seus controles e navegação, mas podem aparecer sem as imagens de fundo originais. O ícone de mostrar/ocultar senha foi substituído por ícones padrão do Windows para que o projeto não dependa de um arquivo de recursos ausente.
