using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step2Coder_ConsoleApp13
{
    internal class Car2
    {


     
            //Deklaration der Zeichenkette als Attribut:
            public string kennzeichen;
            public string model;
            public string color;
            public string bestandteile;
            public string kfz_extra;
            public string kfz_pwd_key;
            public string produktionsnr;


            //Deklaration der Fließkommmazahlen als Attribut:
            public double year;
            public double power_horse;
            public double miles;
            public double super;
            public double diesel;
            public double verbrauch;
            public double dauer;


        //ist jederzeit abrufbar:
            public double gesamte_tankinhalt;
            public double derzeitige_tankinhalt;


        //privat ist verschlüsselt und nicht lesbar für Attribut Schlüssel vom KFZ:
        private double keys;



            //Deklaration der Wahrheitswerte mit public öffentlich für jedermann lesbar mit Attribute:
            public bool accident;
            public bool service;
            public bool tuning;




        //Methode als Funktion innerhalb einer Klasse
        //Bezeichnung der Variable nicht in Funktionstitel verwenden CS0102
        //        static void Main(string[] args)




        //Constructor Konstruktor
        //Basiswerte Startwerte setzen
        //Für Basiskonstruktoren in Funktion public Car2() ist es leer in Klammer also keine Parameter
        //Immer als Basis verwenden vorher mit Werten initialisieren:

        public Car2()
        {
            //Deklaration und Definition respektive Initialisierung der Variablen:
            gesamte_tankinhalt = 100.00;
            derzeitige_tankinhalt = 0.00;
            power_horse = 0.00;
            super = 1.50;
            diesel = 1.70;


            //Initializing standard type model for data base:
            produktionsnr = "A000000";
            color = "white";
            bestandteile = "turbolader";
            model = "Kombi";
            kfz_pwd_key = "1xEF";

        }


        //Methode _model wird string als Datentyp zugewiesen:
        public Car2(string _model,double _ps, double gesamte_tankinhalt, double derzeitige_tankinhalt)
        {

            //Hier wird die lokale Kopie _model in das Attribut Model reinkopiert und überschrieben:
            model = _model;
            power_horse = _ps;

        }


        /*
        //Mehrere Konstruktoren erstellen:
        //Methode _model wird string als Datentyp zugewiesen:
        public Car2(string _model, double _ps)
        {

            //Hier wird die lokale Kopie _model in das Attribut Model reinkopiert und überschrieben:
            model = _model;
            power_horse = _ps;

        }

        */





        
        //Mehrere Konstruktoren erstellen:
        //Methode ohne Underline _model wird string als Datentyp zugewiesen:
        public Car2(string model, double ps)
        {

            //Hier wird die lokale Kopie _model in das Attribut Model reinkopiert und überschrieben:
            this.model = model;
            this.power_horse = ps;

        }










        //Methode _verbrauch für Funktion fahren:
        public void fahren(double _verbrauch)
            {

            Console.WriteLine("Auto fährt");

            Console.WriteLine("Wie schnell fährst du?");
            miles = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Du fährst gerade: " + miles);

            Console.WriteLine("Erste Schätzung was verbraucht dein KFZ pro 100 km/h ?");
            verbrauch = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Wie lange fährst du schon zum Beispiel halbe Stunde mit 0.5 ?");
            dauer = Convert.ToDouble(Console.ReadLine());


            verbrauch = verbrauch * dauer;


            derzeitige_tankinhalt = gesamte_tankinhalt - _verbrauch;



            Console.WriteLine("KFZ mit Verbrauch von  " + _verbrauch + "  pro 100 km/h");


            Console.WriteLine("getankt jetzt derzeitige alte gesamte Tankinhalt:" + gesamte_tankinhalt);


            Console.WriteLine("getankt jetzt derzeitige neue berechnete Tankinhalt:" + derzeitige_tankinhalt);


            //Ende von public void fahren:
        }




        //derzeitige_tankinhalt mit liter um einen Schritt vorher !
        //Methode _liter für Funktion tanken:

        public void tanken(double _liter)   //alte gesamt_tankinhalt = 100   derzeitiger_tankinhalt = 60 
            {

            //Platzhalter zum Testen:
            Console.WriteLine("getankt");

            Console.WriteLine("getankt bisher gesamte Tankinhalt:" + gesamte_tankinhalt);

            Console.WriteLine("getankt jetzt derzeitige vorherige Tankinhalt:" + derzeitige_tankinhalt);


            gesamte_tankinhalt = derzeitige_tankinhalt + _liter;

            Console.WriteLine("getankt jetzt derzeitige neue Tankinhalt:" + gesamte_tankinhalt);

            //Ende public void tanken:
            }






        //Methode ohne static also Bezug auf Klasse ohne Aufruf:
        public void print_data()
            {
                Console.WriteLine("\nAuto: " + "\n" + model + "\nJahre: " + "\n" + year);
            }

            //carriage return \r löscht erste zeichen in zeile

    // Ende von internal class car2:
    }

//Ende von namespace Step2Coder_ConsoleApp13:
}

