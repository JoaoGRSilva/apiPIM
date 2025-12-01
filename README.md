# API de Questionario

> Projeto desenvolvido para a disciplina **Linguagem de programação II** do curso de **Analise e desenvolvimento de sistemas** – UNIP.

## 📌 Sobre o projeto

A **API de Questionário** é uma aplicação desenvolvida para **registrar, gerenciar e armazenar dados enviados por visitantes**, permitindo que a empresa consulte e analise as informações recebidas.

Ela permite:

- Gerenciar os dados enviados pelos visitantes
- Listar informações gerais ou filtradas por ID
- Registrar novos visitantes
- Excluir registros específicos

## 🧠 Contexto acadêmico

Este projeto foi desenvolvido como parte da avaliação da disciplina **Linguagem de Programação II**, com os objetivos de:

- Praticar conceitos de **POO, banco de dados e desenvolvimento de APIs**
- Aplicar boas práticas de arquitetura de software
- Utilizar ferramentas modernas do ecossistema **.NET**

## 🛠 Tecnologias utilizadas

- **Linguagem:** C# (.NET 8)
- **Framework:** ASP.NET Core
- **Banco de dados:** MySQL
- **Dependências principais:**
  - Entity Framework Core
  - Swagger (para documentação da API)

## 📁 Arquitetura do projeto

A solução está organizada da seguinte forma:

```text
Questionario/
├── Properties/
│   └── launchSettings.json
├── Controllers/
│   ├── QuestionarioController.cs
│   └── VisitanteController.cs
├── Data/
│   ├── Map/
│   │   ├── ObraMap.cs
│   │   └── VisitanteMap.cs
│   └── QuestionarioDBContext.cs
├── Migrations/
│   └── QuestionarioDBContextModelSnapshot.json
├── Models/
│   ├── ObraModel.cs
│   └── VisitanteModel.cs
├── Repositorios/
│   ├── Interfaces/
│   │   └── IVisitanteRepositorio.cs
│   └── VisitanteRepositorio.cs
├── appsettings.json
├── Program.cs
└── Questionario.http
```
---

## ⚙️ Pré-requisitos

Para rodar o projeto localmente, você vai precisar de:

- .NET SDK 8.0
- Banco de dados instalado MySQL
- Git (opcional, mas recomendado)

## 🚀 Como executar o projeto

Em desenvolvimento

## Principais endpoints
👤 Exemplo: Usuários

GET /api/usuarios
Retorna a lista de usuários cadastrados.

GET /api/usuarios/{id}
Retorna os dados de um usuário específico.

POST /api/usuarios
Cria um novo usuário.
Body (JSON):
```
  {
    "id": 0,
    "nome": "string",
    "email": "string",
    "questao1": 0,
    "questao2": 0,
    "questao3": 0,
    "questao4": 0,
    "questao5": 0
  }
```
PUT /api/usuarios/{id}
Atualiza os dados de um usuário.

DELETE /api/usuarios/{id}
Remove um usuário do sistema.

## 👥 Autor

Desenvolvido por João Gabriel da Silva
GitHub: @JoaoGRSilva
E-mail: joaogabriel975@hotmail.com

## 📄 Licença

Este projeto foi desenvolvido para fins acadêmicos.
Você pode reutilizar partes do código para estudo, desde que mantenha os devidos créditos.
