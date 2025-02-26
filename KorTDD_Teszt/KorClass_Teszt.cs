using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KorTDD;


namespace KorTDD_Teszt
{
    [TestClass]
    public class KorClass_Teszt 

    {
        // Inicializaljuk a teszt kornyezetet

        KorClass kor= new KorClass(4.0);
        // Kerulet tesztelese
        [TestMethod]
        private void setKerulet_teszt_True()
        {
            // Arrange
            double sugar = kor.getsugar();
            double vartEredm = 25.12,
                kapottEredm;
            //Act
            kapottEredm = kor.setKerulet(sugar);

            //Assert
            Assert.AreEqual(kapottEredm, vartEredm);
        }
        [TestMethod]

        private void setKerulet_teszt_False_alatt()
        {
            // Arrange
            double sugar = kor.getsugar();
            double vartEredm = 25.11,
                kapottEredm;
            //Act
            kapottEredm = kor.setKerulet(sugar);

            //Assert
            Assert.AreEqual(kapottEredm, vartEredm);
        }
        [TestMethod]

        private void setKerulet_teszt_False_felett()
        {
            // Arrange
            double sugar = kor.getsugar();
            double vartEredm = 25.13,
                kapottEredm;
            //Act
            kapottEredm = kor.setKerulet(sugar);

            //Assert
            Assert.AreEqual(kapottEredm, vartEredm);
        }
        [TestMethod]

        private void setTerulet_teszt_True()
        {
            // Arrange
            double sugar = kor.getsugar();
            double vartEredm = 50.24,
                kapottEredm;
            //Act
            kapottEredm = kor.setTerulet(sugar);

            //Assert
            Assert.AreEqual(kapottEredm, vartEredm);
        }
        [TestMethod]

        private void setTerulet_teszt_False_alatt()
        {
            // Arrange
            double sugar = kor.getsugar();
            double vartEredm = 50.23,
                kapottEredm;
            //Act
            kapottEredm = kor.setTerulet(sugar);

            //Assert
            Assert.AreEqual(kapottEredm, vartEredm);
        }
        [TestMethod]

        private void setTerulet_teszt_False_felett()
        {
            // Arrange
            double sugar = kor.getsugar();
            double vartEredm = 50.25,
                kapottEredm;
            //Act
            kapottEredm = kor.setTerulet(sugar);

            //Assert
            Assert.AreEqual(kapottEredm, vartEredm);
        }




    }
}
