using System;
using System.IO;

namespace Client;

public static class ConfigChecker
{
    private static readonly string ConfigFolderPath = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "winpack", "config");

    private static readonly string ConfigFilePath = Path.Combine(ConfigFolderPath, "config.wp");

    public static string GetServerUrl()
    {
        EnsureConfigFileExists();
        return File.ReadAllText(ConfigFilePath).Trim();
    }

    private static void EnsureConfigFileExists()
    {
        if (!Directory.Exists(ConfigFolderPath))
        {
            Directory.CreateDirectory(ConfigFolderPath);
        }

        if (!File.Exists(ConfigFilePath))
        {
            // Create the config file with a default server URL
            File.WriteAllText(ConfigFilePath, "http://localhost:5000");
        }
    }
}
