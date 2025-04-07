namespace Learning.OOP.Formrechner
{
    public class Kreis
    {
        private Punkt p1;
        private double radius;
        
        
        
        public Kreis(){}
        
        public void Setp1(Punkt p1)
        {
            this.p1 = p1;
        }
        public Punkt Getp1()
        {
            return p1;
        }
        
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return radius;
        }

        
        public void RufeAnzeige()
        {
            Anzeige anzeige = new Anzeige();
            anzeige.Flaeche(this);

        }

    }
}