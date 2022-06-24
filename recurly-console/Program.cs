// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using recurly_console;

Console.WriteLine("Hello, World!");

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((hostingContext, configuration) =>
    {
        configuration.Sources.Clear();

        IHostEnvironment env = hostingContext.HostingEnvironment;
        Console.WriteLine($"{env.EnvironmentName}");

        configuration
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true, true);

        IConfigurationRoot configurationRoot = configuration.Build();

        Settings settings = new();
        configurationRoot.GetSection(nameof(Settings))
                         .Bind(settings);

        Console.WriteLine($"{settings.TestString}");

    })
    .Build();

Console.WriteLine("Hey there");

// Application code should start here.

await host.RunAsync();
// Get values from the config given their key and their target type.


