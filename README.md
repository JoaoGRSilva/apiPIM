# API de Questionario

> Projeto desenvolvido para a disciplina **Linguagem de programação II** do curso de **Analise e desenvolvimento de sistemas** – UNIP.

## 📌 Sobre o projeto

A **controladora de resultados** é uma API desenvolvida para **controlar os dados inputados pelos visitantes alem de salvar as informações caso o visitante desejasse preencher**.  
Ela permite que o usuário **gerencie os dados recebidos, envie para a empresa os dados sobre a sua visita e armezenar os dados recebidos**.

Principais funcionalidades:

- Ter a listagem sobre os dados recebidos dentro da database, geral ou por ID
- Postar o registro de um visitante
- Deletar dados por ID

---

## 🧠 Contexto acadêmico

Este projeto foi desenvolvido como parte da avaliação da disciplina **Linguagem de programação II**, com o objetivo de:

- Praticar conceitos de **POO, Banco de dados e gerenciamento de API**
- Aplicar boas práticas de **desenvolvimento de APIs**

---

## 🛠 Tecnologias utilizadas

- Linguagem: **C# (.NET)**
- Framework: **ASP.NET Core**
- Banco de dados: **MySQL**
- Outras dependências:
  - Entity Framework, Swagger.

---

## 📁 Arquitetura do projeto

A solução está organizada da seguinte forma:

```text
Questionario/
├── Properties/
│   ├── launchSettings.json
├── Controllers/
│   ├── QuestionarioController.cs
│   └── VisitanteController.cs
├── Data/
│   ├── Map/
│       ├── ObraMap.cs
│       └── VisitanteMap.cs
│   ├── QuestionarioDBContext.cs
├── Migrations/
│   ├── QuestionarioDBContextModelSnapshot.json
├── Models/
│   ├── ObraModel.cs
│   └── VisitanteModel.cs
├── Repositorios/
│   ├── Interfaces/
│       ├── IVisitanteRepositorio.cs
│   ├── VisitanteRepositorio.cs
├── appsettings.json
├── Program.cs
└── Questionario.http
```
---

# ⚙️ Pré-requisitos

Para rodar o projeto localmente, você vai precisar de:

- .NET SDK 8.0
- Banco de dados instalado MySQL
- Git (opcional, mas recomendado)

---

# 🚀 Como executar o projeto

Em desenvolvimento

---

# Principais endpoints
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
  "nome": "João",
  "email": "joao@example.com"
}
```
PUT /api/usuarios/{id}
Atualiza os dados de um usuário.

DELETE /api/usuarios/{id}
Remove um usuário do sistema.

---

# 👥 Autor

Desenvolvido por João Gabriel da Silva
GitHub: @JoaoGRSilva
E-mail: joaogabriel975@hotmail.com

---

# 📄 Licença

Este projeto foi desenvolvido para fins acadêmicos.
Você pode reutilizar partes do código para estudo, desde que mantenha os devidos créditos.
