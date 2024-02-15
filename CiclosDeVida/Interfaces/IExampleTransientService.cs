using Microsoft.Extensions.DependencyInjection;

namespace CiclosDeVida.Interfaces
{
    public interface IExampleTransientService : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Transient;

    }
}
