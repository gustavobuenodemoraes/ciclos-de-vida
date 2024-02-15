using Microsoft.Extensions.DependencyInjection;

namespace CiclosDeVida.Interfaces
{
    public interface IReportServiceLifetime
    {
        Guid Id { get; }

        ServiceLifetime Lifetime { get; }
    }
}
