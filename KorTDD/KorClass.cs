using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorTDD
{
    public class KorClass

    {
        //Osztályváltozok
        private double sugar = 0.0,
        kerulet = 0.0,
        terulet = 0.0;
        //Konstruktor
        public KorClass( double r) {
            this.sugar = r;
        }
        // Kerulet számitasa 
        public double getKerulet(double r) { // return this.terulet = 2 * r * Math.PI; 
                                             // public double getSugar() { return sugar; }
            return 0.0; }

        public double getTerulet(double r)
        {  // return this.terulet = r * r * Math.PI; 
           // public double getSugar()  { return sugar; }
            return 0;
        }

        public double getSugar(double r) { return sugar; }
    }
}
