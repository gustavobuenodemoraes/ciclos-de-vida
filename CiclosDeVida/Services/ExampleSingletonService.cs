using CiclosDeVida.Interfaces;

namespace CiclosDeVida.Services
{
    internal sealed class ExampleSingletonService : IExampleSingletonService
    {
        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
    }
}
