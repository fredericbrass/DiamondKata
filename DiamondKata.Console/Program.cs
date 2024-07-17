using DiamondKata.Console;
using DiamondKata.Services;
using DiamondKata.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

public static class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IDiamondService, DiamondService>()
            .BuildServiceProvider();

        var diamondService = serviceProvider.GetService<IDiamondService>();

        var diamond = diamondService.Create(args);
        Console.WriteLine(diamond);
    }
}