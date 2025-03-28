# Desenvolvimento para Internet II - API RESTful em .NET

## Descrição
Este projeto faz parte do curso de **Desenvolvimento para Internet II** e tem como objetivo a criação de uma API RESTful utilizando **.NET 8.0**, **Entity Framework Core** e **SQL Server**. A API permite o gerenciamento de tipos de curso em uma instituição de ensino.

## Tecnologias Utilizadas
- **Backend:** .NET 8.0, C#, Entity Framework Core
- **Banco de Dados:** Microsoft SQL Server ou outro
- **Ferramentas:** VS Code, Postman, Swagger, Docker (opcional para rodar o banco)

## Arquitetura do Projeto
O projeto segue a arquitetura **MVC** e está organizado da seguinte forma:
- **Model:** Representa os dados do sistema.
- **Controller:** Contém a lógica de negócio e manipula as requisições da API.
- **View:** Não utilizada, pois a API será consumida por um frontend externo.
- **Repositório:** SQL Server, acessado via Entity Framework Core.

## Configuração do Ambiente
### 1. Instalar Dependências
Antes de iniciar, instale os seguintes softwares:
- [.NET SDK 8.0](https://dotnet.microsoft.com/)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [Docker (opcional)](https://www.docker.com/)
- [VS Code](https://code.visualstudio.com/)
- [Postman](https://www.postman.com/)


### 2. Criar a API
```sh
dotnet new webapi --use-controllers -o apiExemplo -f net8.0

Abrir o VSCode com o projeto criado:
 code -r apiExemplo
 
Compilar o código no terminal:
 dotnet build 
 
Para executar (após a compilação ter sido realizada com sucesso) no terminal:
 dotnet run
 
Framework que faz automaticamente a compilação e a execução:
 dotnet watch
 
Inicia Swagger
http://localhost:5236/swagger/index.html 

```

### 3. Instalar Pacotes Necessários
```sh
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

### 4. Configurar o Banco de Dados
Execute no Docker, toda aula no Laboratório

```sh
docker pull mcr.microsoft.com/mssql/server:2022-latest

docker run --name Banco -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Senh@123" -e "MSSQL_PID=Express" -p 1433:1433 -v data:/var/opt/mssql -d mcr.microsoft.com/mssql/server:2022-latest

MSSQL
localhost,1433
Senh@123

dotnet tool install --global dotnet-ef

dotnet tool update --global dotnet-ef
```



Crie um arquivo `appsettings.json` e adicione a string de conexão:
```sh
   json
"ConnectionStrings": {
  "Development": "Server=localhost,1433; Database=NomeBase; User=sa; Password=Senh@123"
}
```
No `Program.cs`, adicione:
```csharp
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer("name=ConnectionStrings:Development"));
```

### 5. Criar o Banco de Dados
```sh
dotnet ef migrations add Inicial
dotnet ef database update
```

### 6. Rodar a API
```sh
dotnet run
```
A API estará disponível em `http://localhost:5000/api/TipoCurso`.

## Endpoints da API
| Método | Rota             | Descrição                      |
|--------|-----------------|--------------------------------|
| GET    | `/api/TipoCurso` | Lista todos os cursos         |
| POST   | `/api/TipoCurso` | Cria um novo curso            |

### Exemplo de Requisição (POST)
```json
{
  "Nome": "Superior",
  "Descricao": "Cursos superiores de tecnologia"
}
```

## Testando a API
- Acesse `http://localhost:5000/swagger` para testar pelo Swagger.
- Use o Postman para fazer requisições.

## Autor
**Prof. Dr. Tiago Alexandre Dócusse**  
📧 tad@ifsp.edu.br
