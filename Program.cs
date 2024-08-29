// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hallo, ich möchte deine Cleanzeit berechnen.");
Console.WriteLine(" ");

//Erstelle Startdatum
Console.WriteLine("Gebe zuerst das Tagesdatum deines 1. Cleantags an. (Bitte keine 0 am Anfang setzen.): ");
int tag = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Gebe den Monat des 1. Cleantags als Zahl ein. (Bitte keine 0 am Anfang setzen.): ");
int monat = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Gebe bitte die Jahreszahl deines 1. Cleantages mit 4 Stellen ein.: ");
int jahr = Convert.ToInt32(Console.ReadLine());

//Setze 1. Cleantag
DateTime cleantag = new DateTime(jahr, monat, tag);
Console.WriteLine("");

//Berechne Cleanzeit
TimeSpan cleanzeit = DateTime.Now.Subtract(cleantag);
double tage = Math.Floor(cleanzeit.TotalDays);
Console.Write("Du bist ");

//Umrechnen in Jahre, Monate Wochen und Tage
if (tage > 364) {
    double jahre = Math.Floor(tage / 365);
    Console.Write(jahre + " Jahre, ");
    tage %= jahre*365;
}
if (tage > 6){
    double wochen = Math.Floor(tage / 7);
    tage %= wochen * 7;
    // Wenn Wochen > 3 dann berechne die Anzahl der Monate.
    if (wochen > 3) {
        double monate = Math.Floor(wochen * 0.230137);
        Console.Write(monate + " Monate ");
        wochen %= Math.Floor(monate * 0.230137);
    }
    if (wochen > 0)
    {
        Console.Write(wochen + ", Wochen ");
    }
    Console.Write("und ");
}
    
Console.Write(tage + " Tage clean.");
