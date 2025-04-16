using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PonTavOOPTests
{
    public class PontTavTests
    {
        [Test]
        public void AlapKonstruktor_TavolsagNulla()
        {
            var pt = new PontTav(); // Alap konstruktor
            Assert.AreEqual(0.0, pt.GetTavolsag(), 0.0001); // Távolság = 0
        }

        [Test]
        public void KonstruktorKoordinatakkal_HelyesTavolsag()
        {
            var pt = new PontTav(0, 0, 3, 4); // Koordináták (0, 0) és (3, 4)
            Assert.AreEqual(5.0, pt.GetTavolsag(), 0.0001); // Távolság = 5 (Pitagorasz tétel)
        }

        [Test]
        public void KonstruktorTupleval_HelyesTavolsag()
        {
            var pt = new PontTav((1, 2), (4, 6)); // Tuple konstruktor
            Assert.AreEqual(5.0, pt.GetTavolsag(), 0.0001); // Távolság = 5
        }

        [Test]
        public void SetPont1_EredmenyValtozik()
        {
            var pt = new PontTav(); // Alap konstruktor
            pt.SetPont1(1, 1); // Beállítjuk a 1. pontot
            pt.SetPont1(4, 5); // Beállítjuk a 2. pontot
            Assert.AreEqual(5.0, pt.GetTavolsag(), 0.0001); // Távolság = 5
        }

        [Test]
        public void SetPont2_EredmenyValtozik()
        {
            var pt = new PontTav(); // Alap konstruktor
            pt.SetPont1(0, 0); // Beállítjuk az első pontot
            pt.SetPont1(6, 8); // Beállítjuk a második pontot
            Assert.AreEqual(10.0, pt.GetTavolsag(), 0.0001); // Távolság = 10
        }

        [Test]
        public void SetPont1Tuple()
        {
            var pt = new PontTav(); // Alap konstruktor
            pt.SetPont1(((int, int))(2.5, 3.5)); // Beállítjuk az 1. pontot tuple-ként
            pt.SetPont1(((int, int))(5.5, 7.5)); // Beállítjuk a 2. pontot tuple-ként
            Assert.AreEqual(5.0, pt.GetTavolsag(), 0.0001); // Távolság = 5
        }

        [Test]
        public void SetPont2Tuple()
        {
            var pt = new PontTav(); // Alap konstruktor
            pt.SetPont1((0, 0)); // Beállítjuk az első pontot tuple-ként
            pt.SetPont1((9, 12)); // Beállítjuk a második pontot tuple-ként
            Assert.AreEqual(15.0, pt.GetTavolsag(), 0.0001); // Távolság = 15
        }

        [Test]
        public void SzamolTavolsag_Teszteles()
        {
            var pt = new PontTav(1, 1, 4, 5); // Pontok beállítása
            Assert.AreEqual(5.0, pt.SzamolTavolsag(), 0.0001); // Távolság = 5
        }

        [Test]
        public void GetTavolsag_Teszteles()
        {
            var pt = new PontTav(2, 3, 6, 6); // Pontok beállítása
            Assert.AreEqual(5.0, pt.GetTavolsag(), 0.0001); // Távolság = 5
        }

        private class TestAttribute : Attribute
        {
        }
    }

    internal class PontTav
    {
        public PontTav()
        {
        }

        public PontTav(int v)
        {
        }

        public PontTav((int, int) value1, (int, int) value2)
        {
        }

        public PontTav(int v, int v1, int v2, int v3) : this(v)
        {
        }

        internal double GetTavolsag()
        {
            throw new NotImplementedException();
        }

        internal void SetPont1(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        internal void SetPont1((int, int) value)
        {
            throw new NotImplementedException();
        }

        internal double SzamolTavolsag()
        {
            throw new NotImplementedException();
        }
    }
}
