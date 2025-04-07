namespace Learning.OOP.Formrechner
{
    public class Rechteck
    {
        private Punkt p1;
        private Punkt p2;
        private Punkt p3;
        private Punkt p4;
        private Anzeige anz;
        
        public Rechteck(){}
        
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
        public void Setp3(Punkt p3)
        {
            this.p3 = p3;
        }
        public Punkt Getp3()
        {
            return p3;
        }
        public void Setp4(Punkt p4)
        {
            this.p4 = p4;
        }
        public Punkt Getp4()
        {
            return p4;
        }
        public void SetpAnz(Anzeige anz)
        {
            this.anz = anz;
        }
        public Anzeige GetAnz()
        {
            return anz;
        }

        public void RufeAnzeige()
        {
            Anzeige anzeige = new Anzeige();
            anzeige.Flaeche(this);
        }
        
    }
}