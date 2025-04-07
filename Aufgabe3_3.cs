using Learning.OOP.Formrechner;

namespace Learning.OOP.Formrechner
{
    public class Aufgabe3_3
    {
        public static void run()
        {
            
            Punkt p1Linie = new Punkt(7, 1);
            Punkt p2Linie = new Punkt(12, 5);
            
            Linie testlinie = new Linie();
            testlinie.Setp1(p1Linie);
            testlinie.Setp2(p2Linie);
            testlinie.RufeAnzeige();

            Punkt p1Kreis = new Punkt(9, 7);
            Kreis testRadius = new Kreis();
            
            testRadius.SetRadius(2);
            testRadius.RufeAnzeige();

            Punkt p1R = new Punkt(3,4);
            Punkt p2R = new Punkt(6, 4);
            Punkt p3R = new Punkt(3, 6);
            Punkt p4R = new Punkt(6, 6);
            Rechteck rechteck = new Rechteck();
            rechteck.Setp1(p1R);
            rechteck.Setp2(p2R);
            rechteck.Setp3(p3R);
            rechteck.Setp4(p4R);
            
            rechteck.RufeAnzeige();

            

        }
    }
}