using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korhenger
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.példány
            Kor k1 = new Kor();
            k1.SetSugar(15);
            k1.SetKerulet();
            k1.SetTerulet();

            kiir(k1);


            // 2.példány

            Kor k2 = new Kor(58);
            k2.SetKerulet();
            k2.SetTerulet();

            kiir(k2);
            Console.ReadKey();
        }
        private static void kiir(Kor k)
        {
            Console.WriteLine($"A {k.GetSugar()} sugaru kor kerulete:{k.GetKerulet()},terulete: {k.GetTerulet()}");
        }
    }
    
}
