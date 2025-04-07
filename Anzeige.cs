using System;


namespace Learning.OOP.Formrechner
{
    public class Anzeige
    {
        public Anzeige() {}

        public void Flaeche(Kreis k)
        {
            double kreisFl = Math.PI * Math.Pow(k.GetRadius(), 2);
            Console.WriteLine($"Fläche des Kreises ist {kreisFl}");
        }

        public void Flaeche(Rechteck r)
        {
            double seiteA = r.Getp2().GetX() - r.Getp1().GetX(); ;
            double seiteB = r.Getp3().GetY() - r.Getp1().GetY();

            double ergR = seiteA * seiteB;
            Console.WriteLine($"Fläche des Rechtecks ist {ergR}");
        }

        public void Laenge(Linie l)
        {
            double seiteA = l.Getp2().GetX() - l.Getp1().GetX();
            double seiteB = l.Getp2().GetY() - l.Getp1().GetY();

            double erg = Math.Sqrt(Math.Pow(seiteA, 2) + Math.Pow(seiteB, 2));
            
            Console.WriteLine($"Länge der Linie ist {erg}");
        }
        
    }
}