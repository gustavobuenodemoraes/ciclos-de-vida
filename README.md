# ⚙️ Ciclos de Vida em Injeção de Dependência — .NET

Projeto de console desenvolvido em C# / .NET para demonstrar visualmente o comportamento e as diferenças entre os tempos de vida (**Service Lifetimes**) do contêiner nativo de Injeção de Dependência (`Microsoft.Extensions.DependencyInjection`).

---

## 🎯 Conceitos Demonstrados

O contêiner do .NET gerencia três tipos principais de ciclo de vida:

| Ciclo de Vida | Comportamento | Caso de Uso Comum |
| :--- | :--- | :--- |
| **`Transient`** | Uma nova instância é criada a cada resolução/injeção. | Serviços leves e sem estado (Stateless). |
| **`Scoped`** | Uma única instância por escopo criado (ex: por requisição HTTP ou escopo manual). | `DbContext` do Entity Framework, Repositórios. |
| **`Singleton`** | Uma única instância criada na primeira solicitação e reutilizada por toda a aplicação. | Caches em memória, clientes de conexão pesados. |

---

## 🏗️ Estrutura do Projeto

```text
CiclosDeVida/
├── Interfaces/
│   ├── IReportServiceLifetime.cs        # Interface base com Id (Guid) e tipo de Lifetime
│   ├── IExampleTransientService.cs
│   ├── IExampleScopedService.cs
│   └── IExampleSingletonService.cs
├── Services/
│   ├── ExampleTransientService.cs       # Implementação com Id dinâmico
│   ├── ExampleScopedService.cs
│   └── ExampleSingletonService.cs
├── ServiceLifetimeReporter.cs           # Serviço que injeta as dependências e imprime seus IDs
└── Program.cs                           # Configuração do Host e execução dos escopos