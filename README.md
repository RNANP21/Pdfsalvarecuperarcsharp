[README.md](https://github.com/user-attachments/files/34599040/README.md)
<div align="center">

# 📄 Pdfsalvarecuperarcsharp

**Salve PDFs dentro do banco de dados e recupere-os pelo Id, tudo em um app desktop simples.**

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET_Framework_4.7.2-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows_Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server_LocalDB-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white)

</div>

---

## 📚 Sobre o projeto

Aplicativo desktop em **C# (Windows Forms)** que grava arquivos **PDF** diretamente em um banco **SQL Server**, como `VARBINARY`, junto com o título do livro. Depois, basta informar o Id para recuperar o arquivo e salvá-lo novamente no disco.

## ✨ Funcionalidades

| | Funcionalidade |
|---|---|
| 📂 | Selecionar um arquivo `.pdf` do computador (`OpenFileDialog`) |
| 💾 | Salvar título + PDF no banco de dados (`INSERT` com parâmetros) |
| 🔎 | Recuperar um livro pelo Id e gravar o PDF em `C:\dados\meuArquivo.pdf` |

## 🛠️ Tecnologias

| Tecnologia | Uso |
|---|---|
| ![C#](https://img.shields.io/badge/-C%23-239120?logo=csharp&logoColor=white) | Linguagem do projeto |
| ![.NET](https://img.shields.io/badge/-.NET_Framework_4.7.2-512BD4?logo=dotnet&logoColor=white) | Plataforma de execução |
| ![Windows](https://img.shields.io/badge/-Windows_Forms-0078D6?logo=windows&logoColor=white) | Interface gráfica |
| ![SQL Server](https://img.shields.io/badge/-SQL_Server_LocalDB-CC2927?logo=microsoftsqlserver&logoColor=white) | Armazenamento dos PDFs (`System.Data.SqlClient`) |

## ✅ Requisitos

- 🪟 Windows
- 💻 Visual Studio 2017 ou superior, com a carga de trabalho **Desenvolvimento para desktop com .NET**
- 🧩 .NET Framework 4.7.2 (Developer Pack)
- 🗄️ SQL Server LocalDB (instalado junto com o Visual Studio)

## 🗄️ Configuração do banco de dados

A string de conexão está em `Livros.cs` e aponta para `(localdb)\MSSQLLocalDB`, banco `Livros`. Crie o banco e a tabela antes de executar:

```sql
CREATE DATABASE Livros;
GO

USE Livros;
GO

CREATE TABLE dbo.Livros (
    id     INT IDENTITY(1,1) PRIMARY KEY,
    titulo NVARCHAR(200)  NOT NULL,
    pdf    VARBINARY(MAX) NOT NULL
);
```

> 💡 Execute o script pelo **Pesquisador de Objetos do SQL Server** no Visual Studio, conectando em `(localdb)\MSSQLLocalDB`.

## 🚀 Como executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/RNANP21/Pdfsalvarecuperarcsharp.git
   ```
2. Abra `Pdfsalvarecuperarcsharp.sln` no Visual Studio.
3. Crie o banco e a tabela (seção acima).
4. Crie a pasta `C:\dados`, usada ao recuperar o PDF.
5. Compile e execute com `F5`.

## 🖱️ Como usar

**💾 Salvar um PDF**

1. Clique no botão de carregar PDF e escolha o arquivo.
2. Digite o **Título** do livro.
3. Clique em **Salvar**.

**🔎 Recuperar um PDF**

1. Digite o **Id** do livro.
2. Clique em **Carregar**.
3. O título aparece na tela e o PDF é gravado em `C:\dados\meuArquivo.pdf`.

## 🗂️ Estrutura do projeto

```
Pdfsalvarecuperarcsharp/
├── Pdfsalvarecuperarcsharp.sln
└── Pdfsalvarecuperarcsharp/
    ├── Program.cs         # ponto de entrada; abre o Form1
    ├── Form1.cs           # tela: escolher PDF, salvar e recuperar
    ├── Form1.Designer.cs  # layout da tela (gerado pelo designer)
    ├── Livros.cs          # modelo + acesso ao banco (Salvar e Get)
    ├── App.config
    └── Properties/
```

## ⚠️ Pontos de atenção

- Em `Form1.cs`, a chamada `livro.Salvar(...)` passa um terceiro argumento (`cmd`) que o método não aceita, e os namespaces de `Form1` e `Livros` são diferentes. Os dois pontos precisam ser corrigidos para o projeto compilar.
- O método `Get` monta o SQL concatenando o Id; o ideal é usar parâmetro (`@id`), como já é feito no `Salvar`.
- O caminho `C:\dados\meuArquivo.pdf` é fixo e sobrescreve o arquivo anterior a cada recuperação.
- Se o Id não existir, `Get` não preenche o PDF e a gravação do arquivo falha.

## 👤 Autor

<a href="https://github.com/RNANP21">
  <img src="https://img.shields.io/badge/GitHub-RNANP21-181717?style=for-the-badge&logo=github&logoColor=white" alt="GitHub RNANP21" />
</a>
