namespace Learning.OOP.Formrechner
{
    public class Punkt
    {
        private double X;
        private double Y;

        public Punkt() {}

        public Punkt(double X)
        {
            this.X = X;
        }
        public Punkt(double X, double Y)
        {
            this.Y = Y;
            this.X = X;
        }
        
        
        public void SetX(double X)
        {
            this.X = X;
        }

        public double GetX()
        {
            return X;
        }
        public void SetY(double Y)
        {
            this.Y = Y;
        }
        
        public double GetY()
        {
            return Y;
        }
        
        
    }
}