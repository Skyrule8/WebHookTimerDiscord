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
        object objectAmz = new
        {
            title = "Sortie de Bleach",
            description = "Il ne reste que "+ CounterUntilCameOut() + " jours avant la sortie de Bleach" ,
            color = int.Parse(ColorRed2, System.Globalization.NumberStyles.HexNumber),
        };

        Objects.Add(objectAmz);
        return Task.FromResult(Objects);
    }

    private static int CounterUntilCameOut()
    {
        var dateTime = DateTime.Today;
        Console.WriteLine(dateTime);
        var dateTimeUntil = new DateTime(2022, 10, 01);
        Console.WriteLine(dateTimeUntil);

        var getDaysUntil = (dateTimeUntil - dateTime).Days;
        Console.WriteLine(getDaysUntil);
        return getDaysUntil;
    }
}