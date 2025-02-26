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
        public KorClass(double r) {
            this.sugar = r;
        }
        // Kerulet számitasa 
        public void setSugar(double r) { // return this.terulet = 2 * r * Math.PI; 
            this.sugar = r;               // public double getSugar() { return sugar; }
       }

        public double setKerulet(double r)
        {  // return this.terulet = r * r * Math.PI; 
           // public double getSugar()  { return sugar; }
            if (r <= 0.0)
            {
                throw new ArgumentException();
            }
            
            
            return 2*this.sugar*Math.Round(Math.PI,2);
        }
        public double setTerulet(double r)
        {  // return this.terulet = r * r * Math.PI; 
           // public double getSugar()  { return sugar; }



            return this.sugar * this.sugar * Math.Round(Math.PI, 2); 
        }

        public double getsugar() { return sugar; }
        public double getTerulet(double r) { return sugar; }


    }

}
