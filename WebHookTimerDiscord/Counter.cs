namespace WebHookTimerDiscord;

public static class Counter
{
    const string ColorBlue = "1F61E6";
    const string ColorGreen = "80E61F";
    const string ColorRed = "E71F1F";
    const string ColorPurple = "C61FE6";
    const string ColorYellow = "E6C71F";
    const string ColorYellow2 = "FFDC03";
    const string ColorGreen2 = "03D8A6";
    const string ColorFuchsia = "FF00EF";
    const string ColorBlack = "000000";
    const string ColorRed2 = "C70039";
    private static readonly List<object> Objects = new();

    public static Task<List<object>> CountDownUntilBleachCameOut()
    {
        GetEmbedObject(new DateTime(2022, 10, 01), "la sortie de Bleach", ColorRed2, "Sortie de Bleach");   
        GetEmbedObject(new DateTime(2022, 10, 01), "Noël !!", ColorGreen2, "Noël");   

        return Task.FromResult(Objects);
    }

    private static void GetEmbedObject(DateTime dateUntil, string sujet, string color, string title)
    {
        object obj = new
        {
            title = title,
            description = "Il ne reste que "+ (dateUntil - DateTime.Today).Days + " jours avant " + sujet ,
            color = int.Parse(color, System.Globalization.NumberStyles.HexNumber),
        };

        Objects.Add(obj);
    }
}