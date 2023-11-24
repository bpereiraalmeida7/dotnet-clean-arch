# 🚧 Clean Arch .NET 
Modelo de clean architecture em .NET 6, utilizando como exemplo didático do tema, uma API de filmes.

## Estrutura da aplicação

A aplicação foi feita em .NET 6, utilizando boas práticas e princípios do SOLID. Segue arquitetura principal, com as responsabilidades separadas em projetos (.dll) diferentes:

```
📁 
  |- 📁 CleanArch.Api
  |    | - 📁 Controllers
  |- 📁 CleanArch.Application
  |    | - 📁 Interfaces
  |    | - 📁 Services
  |- 📁 CleanArch.Domain
  |    | - 📁 Entities
  |- 📁 CleanArch.Infra
  |    | - 📁 Interfaces
  |    | - 📁 Repositories
```
