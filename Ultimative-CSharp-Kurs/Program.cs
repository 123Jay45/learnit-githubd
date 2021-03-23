using System;
using System.Collections;
using System.IO;

namespace Ultimative_CSharp_Kurs
{
    //class Auto
    //{
    //    private string marke;
    //    private string ps;
    //    private string modell;
    //    private string farbe;
    //    public void setFarbe (string farbe)
    //    {
    //        this.farbe = farbe;
    //    }
    //    public string getFarbe (string farbe)
    //    {
    //        return this.farbe;
    //    }
	// TEST
    //    public void ausgabe()
    //    {
    //        if(farbe != null)
    //        {
    //            Console.WriteLine("Das Auto ist ein "+marke+", hat "+ps+", gehört zur Modellreihe "+modell+" und hat die Farbe "+farbe);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Das Auto ist ein " + marke + ", hat " + ps + " und gehört zur Modellreihe " + modell);
    //        }
    //    }
    //    public Auto(string marke, string ps, string modell)
    //    {
    //        this.marke = marke;
    //        this.ps = ps;
    //        this.modell = modell;
    //    }
    //}

    //class Azubi : Mitarbeiter
    //{
    //    private int arbeitsstunden, schulstunden;

    //    public Azubi(string name, string vorname, int gehalt, int schulstunden, int arbeitsstunden) : base(name, vorname, gehalt)
    //    {
    //        this.schulstunden = schulstunden;
    //        this.arbeitsstunden = arbeitsstunden;
    //    }

    //    public void lernen()
    //    {
    //        Console.WriteLine("Ich lerne " + this.schulstunden+ " Stunden.");
    //    }
    //    public void arbeiten()
    //    {
    //        Console.WriteLine("Ich arbeite " + this.arbeitsstunden + " Stunden.");
    //    }
    //}
    //class Mitarbeiter
    //{
    //    private string vorname, name;
    //    int gehalt;

    //    public Mitarbeiter(string name, string vorname, int gehalt)
    //    {
    //        this.vorname = vorname;
    //        this.name = name;
    //        this.gehalt = gehalt;
    //    }
    //    public void arbeiten()
    //    {
    //        Console.WriteLine("Ich arbeite!");
    //    }
    //    public void pausieren()
    //    {
    //        Console.WriteLine("Ich pausiere!");
    //    }
    //}
    //class Boss : Mitarbeiter
    //{
    //    private string firmenwagen;

    //    public Boss(string name, string vorname, int gehalt, string firmenwagen) : base(name, vorname, gehalt)
    //    {
    //        this.firmenwagen = firmenwagen;
    //    }
    //    public void fuehren()
    //    {
    //        Console.WriteLine("Ich führe!");
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            //Auto Ford = new Auto("Ford", "160", "Focus");
            //Auto Fiat = new Auto("Fiat", "60", "Punto");
            //Fiat.setFarbe("Orange");
            //Fiat.ausgabe();
            //Ford.ausgabe();

            //Console.Write("Wieviel Geld willst du pro Monat sparen?: ");
            //decimal[] Erspartes = new decimal[30];

            //Erspartes[0] = decimal.Multiply((decimal)12, Convert.ToDecimal(Console.ReadLine()));
            //for (int i = 1; i < Erspartes.Length; i++)
            //{
            //    Erspartes[i] = (decimal)12*(decimal)100 + Erspartes[i - 1] * (decimal)1.07;
            //    Console.WriteLine("{0:0.00 }", Erspartes[i]);
            //}
            //    ArrayList warteListe = new ArrayList();

            //    warteListe.Add("Stefan");
            //    warteListe.Add("Thomas");
            //    warteListe.Add("Peter");
            //    warteListe.Add("Sarah");
            //    warteListe.Add("Nefeli");

            //    warteListe.Sort();

            //    string eingabe = "";
            //    while (warteListe.Count != 0)
            //    {
            //        Console.Write("Gib next für den nächsten in der Liste ein: ");
            //        eingabe = Console.ReadLine();
            //        if (eingabe == "next" && warteListe[0] != null)
            //        {
            //            Console.WriteLine("Du bist an der Reihe "+warteListe[0]+".");
            //            warteListe.RemoveAt(0);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Du kannst nur next eingeben, bist keine Personen mehr warten!");
            //        }
            //    }
            //    Console.WriteLine("Alle wartenden wurden aufgerufen.");
            //Mitarbeiter Andreas = new Mitarbeiter("Irrgang", "Andreas", 40000);
            //Boss Chuck = new Boss("Norris", "Chuck", 122000, "Porsche");
            //Azubi Nefeli = new Azubi("Mavroueidi", "Nefeli", 2000, 80, 90);
            //Nefeli.arbeiten();
            //Nefeli.lernen();
            //Andreas.arbeiten();
            //Chuck.arbeiten();
            //Chuck.fuehren();

            //Beispiel für eine Textfile streaming
            ArrayList stringlist = new ArrayList();
            string path = @"C:\tmp/Lernprojekt\Ultimative-CSharp-Kurs\Ultimative-CSharp-Kurs\Textlesen.txt";
            string temp = "";
            using (StreamReader reader = new StreamReader(path))
            {
                while((temp=reader.ReadLine())!= null)
                {
                    stringlist.Add(temp);
                }
            }
            using (StreamWriter writer = new StreamWriter(@"C:\tmp\Lernprojekt\Ultimative-CSharp-Kurs\Ultimative-CSharp-Kurs\Textschreiben.txt"))
            {
                while (stringlist.Count > 0)
                {
                    writer.WriteLine(stringlist[0]);
                    stringlist.RemoveAt(0);
                }
            }
        }
    }
}
