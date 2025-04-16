# ProjetoExemplo

ProjetoExemplo é uma aplicação demonstrativa desenvolvida em C# utilizando o padrão de arquitetura MVC. Este projeto foi estruturado para evidenciar boas práticas de desenvolvimento, aderência aos princípios SOLID, Clean Code e testes unitários com XUnit. Ele serve como portfólio para demonstrar o nível de qualidade e organização do código para recrutadores e outros interessados.

## Sumário

- [Tecnologias Utilizadas](#tecnologias-utilizadas)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Configuração e Execução](#configuração-e-execução)
- [Testes Unitários](#testes-unitários)
- [Boas Práticas Aplicadas](#boas-práticas-aplicadas)
- [Contato](#contato)

## Tecnologias Utilizadas

- **Linguagem:** C#
- **Plataforma:** .NET 8.0 (ou .NET Core)
- **Framework Web:** ASP.NET Core MVC
- **Testes:** XUnit para testes unitários
- **Padrões e Práticas:** SOLID, Clean Code, Injeção de Dependência, e boas práticas de nomenclatura (camelCase e PascalCase).

## Estrutura do Projeto

/ProjetoExemplo
├── README.md # Documentação do projeto 
├── .gitignore # Arquivos e pastas a serem ignorados pelo Git 

├── ProjetoExemplo.sln # Solução do Visual Studio
      └── ProjetoExemplo.Web/ # Projeto principal da aplicação web
            ├── Controllers/ # Controladores da aplicação (ex: HomeController.cs)
            ├── Models/ # Modelos de dados (ex: Product.cs)
            ├── Services/ # Lógica de negócio e serviços (ex: ProductService.cs)
            ├── Repositories/ # Acesso a dados (ex: ProductRepository.cs)
            ├── Views/ # Views do MVC (ex: Home/Index.cshtml)
            ├── Program.cs # Configuração e inicialização da aplicação
      └── ProjetoExemplo.Tests/ # Projeto de testes unitários utilizando XUnit 
            └── ProductServiceTests.cs

## Configuração e Execução

### Pré-requisitos

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou outro editor de sua preferência

### Passo a Passo

1. **Clone o repositório:**
   ```bash
   git clone <URL-do-repositório>
   cd ProjetoExemplo

2. **Restaure os pacotes e compile a solução:**

   ```bash
   dotnet restore
   dotnet build

3. **Execute a aplicação:**

    ```bash
    dotnet run --project src/ProjetoExemplo.Web/ProjetoExemplo.Web.csproj
    Acesse a aplicação via navegador no endereço padrão (geralmente https://localhost:5001 ou https://localhost:5000).

## Testes Unitários

Para rodar os testes unitários com XUnit, execute os comandos abaixo na raiz do projeto:

    ```bash
    dotnet test
    Isso irá compilar e executar todos os testes definidos no projeto ProjetoExemplo.Tests.

## Boas Práticas Aplicadas

SOLID: Cada classe tem uma única responsabilidade, facilitando a manutenção e testes.
Clean Code: Código organizado, legível e comentado somente quando necessário.
Injeção de Dependência: Uso de interfaces para desacoplamento entre camadas (ex.: IProductService, IProductRepository).
Padronização de Nomenclatura: Convenção em PascalCase para nomes de classes e métodos públicos; camelCase para variáveis e parâmetros.

## Contato

Nome: André Gonçalves Gardino
LinkedIn: https://linkedin.com/in/aggardino
