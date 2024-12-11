using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KörHenger;
namespace korhengert
{
    [TestClass]
    public class Kör_Teszt
    {
        [TestMethod]
        public void Kerület_Teszt()
        {
            double sugár = 5;
            kor kor = new kor(sugár);
            kor.SetKerulet();
            double vártEredm = 31.4;
        }
        [TestMethod]
        public void Terület_Teszt()
        {
            double sugár = 5;
            Kör kör = new Kör(sugár);
            double vártEredm = 78.5398;

            // Act - Végrehajtás
            kör.SetTerület();
            double kapottEredm = kör.GetTerület();

            // Assert - Kiértékelés
            Assert.AreEqual(vártEredm, kapottEredm, 0.01);
        }

    }
}






KörHenger