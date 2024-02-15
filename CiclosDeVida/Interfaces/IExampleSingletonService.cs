using Microsoft.Extensions.DependencyInjection;

namespace CiclosDeVida.Interfaces
{
    public interface IExampleSingletonService : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Singleton;
    }
}
