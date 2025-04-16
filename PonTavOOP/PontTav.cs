using System;

namespace PonTavOOP
{
    public class PontTav
    {
        private double x1, y1, x2, y2;

        // Alap konstruktor
        public PontTav()
        {
            x1 = y1 = x2 = y2 = 0;
        }

        // Konstruktor koordinátákkal
        public PontTav(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        // Konstruktor tuple-szerű (ValueTuple) pontokkal
        public PontTav((double, double) p1, (double, double) p2)
        {
            x1 = p1.Item1;
            y1 = p1.Item2;
            x2 = p2.Item1;
            y2 = p2.Item2;
        }

        // Pontok beállítása külön-külön
        public void SetPont1(double x, double y)
        {
            x1 = x;
            y1 = y;
        }

        public void SetPont2(double x, double y)
        {
            x2 = x;
            y2 = y;
        }

        // Pontok beállítása tuple-ként
        public void SetPont1((double, double) p)
        {
            x1 = p.Item1;
            y1 = p.Item2;
        }

        public void SetPont2((double, double) p)
        {
            x2 = p.Item1;
            y2 = p.Item2;
        }

        // Távolság kiszámítása
        public double SzamolTavolsag()
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        // Távolság lekérdezése
        public double GetTavolsag()
        {
            return SzamolTavolsag();
        }
    }
}
