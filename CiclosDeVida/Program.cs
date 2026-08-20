using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CiclosDeVida.Interfaces;
using CiclosDeVida.Services;
using CiclosDeVida;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

// Registro das dependências com seus respectivos ciclos de vida
builder.Services.AddTransient<IExampleTransientService, ExampleTransientService>();
builder.Services.AddScoped<IExampleScopedService, ExampleScopedService>();
builder.Services.AddSingleton<IExampleSingletonService, ExampleSingletonService>();
builder.Services.AddTransient<ServiceLifetimeReporter>();

using IHost host = builder.Build();

ExemplifyServiceLifetime(host.Services, "--- Execução 1: Escopo A ---");
ExemplifyServiceLifetime(host.Services, "--- Execução 2: Escopo B ---");

await host.RunAsync();

static void ExemplifyServiceLifetime(IServiceProvider hostProvider, string lifetimeDetails)
{
    using IServiceScope serviceScope = hostProvider.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;

    ServiceLifetimeReporter logger = provider.GetRequiredService<ServiceLifetimeReporter>();
    logger.ReportServiceLifetimeDetails(lifetimeDetails);

    Console.WriteLine();
}