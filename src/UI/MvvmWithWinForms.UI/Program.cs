using Microsoft.Extensions.DependencyInjection;
using MvvmWithWinForms.IoC;

namespace MvvmWithWinForms.UI;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        var services = new ServiceCollection();
        services.AddCodeGeneration();
        services.AddTransient<MainForm>();

        var provider = services.BuildServiceProvider();
        var mainForm = provider.GetRequiredService<MainForm>();

        Application.Run(mainForm);
    }
}