using Microsoft.Extensions.Configuration;

namespace GuessGame.UI.Configuration;

public static class ConfigLoader
{
    public static IConfigurationRoot Load()
    {
        return new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
    }
}

