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
Console.Write("Du bist "+tage+" Tage clean.");

