using System;
using System.Collections.Generic;

public static class Fuck
{
    public static void YouFuckedUp(string message) => throw new ArgumentException($"You fucked up, {Twattery}: " + message);

    public static void YouFuckedUp(string paramName, object value)
    {
        if(value==null) throw new ArgumentNullException(paramName, $"You fucked up, {Twattery}: {paramName} cannot be fucking null");
    }

    public static void YouFuckedUp(string paramName, string value)
    {
        if (string.IsNullOrEmpty(value)) throw new ArgumentNullException(paramName, $"You fucked up, {Twattery}: {paramName} cannot be fucking null or fucking empty");
    }

    public static void IFuckedUp(string message = null) => throw new InvalidOperationException(message);

    public class Fucking
    {
        public static void Fuck(string message = null) => throw new Exception($"Fuck! Fuck! Fuck!: " + message);
    }

    private static readonly Random Random = new Random();
    private static readonly List<string> FuckHead = new List<string>
    {
        "dipshit",
        "dumbarse",
        "shit for brains",
        "fuckhead",
        "arsehole",
        "fucksticle",
        "shithead",
        "dickhead",
        "dumbfuck",
        "I genuinely hate you"
    };

    private static string Twattery => FuckHead[Random.Next(FuckHead.Count)];
}

