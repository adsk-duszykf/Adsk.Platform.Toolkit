using Autodesk.Authentication;
using Sdk_Tests;

namespace Tests;

internal static class ThreeLeggedTokenGenerator
{
    internal static async Task<string> GenerateToken()
    {
        var settings = Settings.Load();

        var filePath = Path.Combine(Environment.CurrentDirectory, settings.REFRESH_TOKEN_FILE);

        var refreshToken = ReadFile(filePath);

        var authClient = new AuthenticationClient();
        var threeLeggedToken = await authClient.Helper.RefreshThreeLeggedToken(settings.THREE_LEGGED_APS_CLIENT_ID, settings.THREE_LEGGED__APS_CLIENT_SECRET, refreshToken);

        WriteFile(settings.REFRESH_TOKEN_FILE, threeLeggedToken.RefreshToken ?? throw new InvalidOperationException("Cannot create 3L token"));

        return threeLeggedToken.AccessToken ?? throw new InvalidOperationException("Cannot create 3L token");
    }

    static string ReadFile(string filePath)
    {

        if (File.Exists(filePath))
        {
            return File.ReadAllText(filePath);
        }
        else
        {
            throw new FileNotFoundException($"The file '{filePath}' was not found.");
        }

    }

    static void WriteFile(string filePath, string content)
    {
        File.WriteAllText(filePath, content);

    }
}
