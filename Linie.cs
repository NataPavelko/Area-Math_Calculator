namespace Learning.OOP.Formrechner
{
    public class Linie
    {
        private Punkt p1;
        private Punkt p2;
        
        public Linie(){}

        public void Setp1(Punkt p1)
        {
            this.p1 = p1;
        }
        public Punkt Getp1()
        {
            return p1;
        }
        
        public void Setp2(Punkt p2)
        {
            this.p2 = p2;
        }
        public Punkt Getp2()
        {
            return p2;
        }


        public void RufeAnzeige()
        {
            Anzeige anzeige = new Anzeige();
            anzeige.Laenge(this);
        }
    }
}