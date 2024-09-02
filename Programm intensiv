Console.WriteLine("Hallo, ich möchte deine Cleanzeit berechnen.");
Console.WriteLine(" ");

//Erstelle Startdatum
Console.WriteLine("Gebe zuerst das Tagesdatum deines 1. Cleantags an. (Bitte keine 0 am Anfang setzen.): ");
int tag = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Gebe den Monat des 1. Cleantags als Zahl ein. (Bitte keine 0 am Anfang setzen.): ");
int monat = Convert.ToInt32(Console.ReadLine());
 
Console.WriteLine("Gebe bitte die Jahreszahl deines 1. Cleantages mit 4 Stellen ein.: ");
int jahr = Convert.ToInt32(Console.ReadLine());

//Komma oder Und setzen für and = true
bool and = false;

//Setze 1. Cleantag
DateTime cleantag = new DateTime(jahr, monat, tag);
Console.WriteLine("");

//Berechne Cleanzeit
TimeSpan cleanzeit = DateTime.Now.Subtract(cleantag);
double tage = Math.Floor(cleanzeit.TotalDays);
Console.Write("Du bist ");

//Umrechnen in Jahre, Monate, Wochen und Tage

//Jahre berechnen
if ((tage >= 365)||(jahr < (Convert.ToInt32(DateTime.Now.Year))))
{
  //Setze absofort Komma oder schreibe "und"
        and = true;

        double jahre = Math.Floor(tage / 365.5);
        tage %= Math.Ceiling(jahre * 365.5);
    
 //Wenn eingegebener Tag und eingegebner Monat jeweils gleich zum Zeitdatum sind, addiere ein Jahr und setze Tage auf 0.
        if((tag == (Convert.ToInt32(DateTime.Now.Day)))&&(monat == Convert.ToInt32(DateTime.Now.Month)))
        {
        jahre = Convert.ToDouble(Convert.ToInt32(DateTime.Now.Year) - jahr);
        tage = 0;
        }

 //SchreibeJahresanzahl
 schreibWert(jahre, tage, "Jahr", "Jahre");
}

//Monate berechnen 
    if (tage > 29)
    {
    double monate = 0;
    
// Folge den Anweisungen wenn eingegebener Tag gleich mit Tag des Zeitstempels ist 
    if (tag == (Convert.ToInt32(DateTime.Now.Day)))
    {
        //Setze aktuellen Zeitstempelmonat in Variable
        int aktuellMonat = Convert.ToInt32(DateTime.Now.Month);

        //Wenn Zeitstempelmonat größer eingegebener Monat ist errechne die Differenz
        if (aktuellMonat > monat)
        {
            monate = Convert.ToDouble(aktuellMonat - monat);
            tage = 0;
        }

//Wenn Zeitstempelmonat kleiner eingegebener Monat zähle Zeitstempelmonat zur Differenz zwischen eingegebener Monat und letzten Monat im Jahr hinzu
        if (aktuellMonat < monat)
        {
            monate = Convert.ToDouble(aktuellMonat + (12 - monat));
            tage = 0;
        }

        //Ist nur möglich bei Fehler in der Jahresberechnung
        if (aktuellMonat == monat)
        {
            tage = 0;
        }

    }


//Anweisungen folgen nur wenn eingegebener Tag nicht mit Zeitstempeltag übereinstimmt
    if (tag != (Convert.ToInt32(DateTime.Now.Day)))
    {
        
        monate = Math.Floor(tage / 30.416667);
        if (monate != 0)
        {
            tage %= Math.Floor(monate * 30.416667);
        }
       
    }
        
    
    //Schreibe "und" oder setze ",".
    andOrKomma(tage, and);

    //Schreibe Monatsanzahl
    schreibWert(monate, tage, "Monat", "Monate");

    //Setze ab sofort Komma oder schreibe "und"
    and = true;
}

//Wochen berechnen
if (tage > 6)
{
   double wochen = Math.Floor(tage / 7);
   tage %= wochen * 7;

//Schreibe "und" oder setze ",".
    andOrKomma(tage, and);

//Schreibe Wochenanzahl
    schreibWert(wochen, tage, "Woche", "Wochen");

//Setze ab sofort Komma oder schreibe "und"
    and = true;
}

//Setze Tage
if (tage > 0)
{

//Schreibe "und".
   if (and == true)
   {
       Console.Write(" und ");
   }

//Schreibe Tageanzahl
    if (tage > 1)
    {
        Console.Write(tage + " Tage clean.");
    }
    if (tage == 1)
    {
         Console.Write(tage + " Tag clean.");
    }
}



    
//Schreibe "und" oder setze ",".
   static  void andOrKomma(double tage, bool and)
    {
        if ((and == true) && (tage > 0))
        {
            Console.Write(", ");
        }
        if ((and == true) && (tage == 0))
        {
            Console.Write(" und ");
        }
    }

//Schreibe Anzahl des Wertes auf
 static void schreibWert(double wertzahl, double tage, string wert, string wertMehrzahl)
 {
    if ((wertzahl == 1) && (tage > 0))
    {
        Console.Write(wertzahl + " "+wert);
    }
    if ((wertzahl > 1) && (tage > 0))
    {
        Console.Write(wertzahl + " "+wertMehrzahl);
    }
    if ((wertzahl == 1) && (tage == 0))
    {
        Console.Write(wertzahl + " " + wert + " clean.");
    }
    if ((wertzahl > 1) && (tage == 0))
    {
        Console.Write(wertzahl + " " + wertMehrzahl  + " clean.");
    }
 }
