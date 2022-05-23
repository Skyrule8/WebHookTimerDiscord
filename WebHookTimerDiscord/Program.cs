using System.Text;
using Discord;
using Newtonsoft.Json;

namespace WebHookTimerDiscord;

public static class Program
{
    private static HttpClient? Client { get; } = new();

    private static async Task Main()
    {
        var webHookId = "";
        var webHookToken = "";

        var items = await Counter.CountDownUntilBleachCameOut();
        
        var successWebHook = new
        {
            embeds = items,
        };
        
        if (successWebHook == null) throw new ArgumentNullException(nameof(successWebHook));

        var endPoint = $"https://discordapp.com/api/webhooks/{webHookId}/{webHookToken}";

        var content = new StringContent(JsonConvert.SerializeObject(successWebHook), Encoding.UTF8, "application/json");

        Client?.PostAsync(endPoint, content).Wait();
        
    }
}