using System;

namespace Step2Coder_ConsoleApp13
{
    internal class Program
    {

        //Deklaration und Definition der globalen Variable:
        static double liter = 0;
        static double verbrauch = 0;

        static void Main(string[] args)
        {
            //globale Variable in der Funktion sonst ToLower(); nicht funktioniert:
            string antwort = "";

            //Hier wir Objekt mit Car2 erzeugt und der Basiskonstruktor aufgerufen:
            Car2 car1 = new Car2();

            //Basiskonstruktor Typ und String
            Car2 car2 = new Car2("Mercedes Limousine", 90);


            //Car2 car3 = new Car2("E5555", "Mercedes", 90, 60.0, 100.0);



            Console.WriteLine("\n \n        Kundendatenbank \n \n");


            Console.WriteLine("\n \nWann haben Sie ihr Auto gekauft?");
            car1.year = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\n \nWelches Kennzeichen haben Sie?");
            car1.kennzeichen = Convert.ToString(Console.ReadLine());


            Console.WriteLine("\n \nWieviele PS hat das KFZ ?");
            car1.power_horse = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\n \nFahren Sie Limousine oder Kombi ?");
            car1.model = Convert.ToString(Console.ReadLine());


            Console.WriteLine("\n \nWelche Autofarbe mögen Sie ?");
            car1.color = Convert.ToString(Console.ReadLine());



            //Definition vom gesamten Tankinhalt und Initialisierung durch festgelegten Wert:
            //car1.gesamte_tankinhalt = 100.00;


            Console.WriteLine("Welches Fassungsvermögen hat der gesamte Tankinhalt?");
            car1.gesamte_tankinhalt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Welches Fassungsvermögen hat derzeitige Tankinhalt?");
            car1.derzeitige_tankinhalt = Convert.ToDouble(Console.ReadLine());


            
            //Funktion .ToLower() statt || antwort == Ja 
            Console.WriteLine("Willst du tanken ?");
            antwort = Console.ReadLine().ToLower();

            if (antwort == "ja")
            {

                Console.WriteLine("Du hast Ja gewählt.");

                Console.WriteLine("Wieviel willst du tanken ?");
                liter = Convert.ToDouble(Console.ReadLine());

                car1.fahren(verbrauch);
                car1.tanken(liter);

            }

            //anstatt else if so besser:
            if (antwort != "ja")
            {
                //Bildschirmanzeige komplett auflösen damit als Erstes wo Programmtitel folgendes steht:
                Console.Clear();

                Console.WriteLine("\n \n            Tankvorgang wurde abgebrochen ! \n \n");
            }


            //Console.WriteLine("Hello World!");

        //Ende static void Main
        }

    //Ende internal class Program
    }

//Ende namespace Step2Coder-ConsoleApp13
}
