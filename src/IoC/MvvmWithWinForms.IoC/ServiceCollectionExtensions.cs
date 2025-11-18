using Microsoft.Extensions.DependencyInjection;
using MvvmWithWinForms.CodeGeneration;
using MvvmWithWinForms.CodeGeneration.Contracts;

namespace MvvmWithWinForms.IoC;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Register application services provided by the CodeGeneration project.
    /// </summary>
    public static IServiceCollection AddCodeGeneration(this IServiceCollection services)
    {
        services.AddTransient<ICodeGenerationService, CodeGenerationService>();
        return services;
    }
}
