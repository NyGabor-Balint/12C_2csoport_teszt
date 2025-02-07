﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AtvaltOOP;

namespace AtvaltOOP_UnitTeszt
{
    [TestClass]
    public class Atvalt_ClassUnitTest
    // A teszt osztály nevében jelzem, hogy melyik osztályt tesztelem
    {

        //Mivel mindegyik teszt az osztály metodusát teszteli, ezert az osztaly itt egyszer példányosítható

        Atvalt atvalt = new Atvalt();
        [TestMethod]
        public void isDecimal_True() // A tesztmetodus nevében jelzem, hoyg melyik metodust tesztelem és mire
        {
            // Arrange- Tesztkörnyezet beállítása
            string szoveg = "21";
            bool vartEredm = true, kapottEredm = false;
            // Act- A vizsgált metódus végrehajtása
            kapottEredm = atvalt.isDecimal(szoveg);
            // Act- Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm, vartEredm);


        }
        [TestMethod]
        public void isDecimal_False() // A tesztmetodus nevében jelzem, hoyg melyik metodust tesztelem és mire
        {
            // Arrange- Tesztkörnyezet beállítása
            string szoveg = "k";
            bool vartEredm = false, kapottEredm = false;
            // Act- A vizsgált metódus végrehajtása
            kapottEredm = atvalt.isDecimal(szoveg);
            // Act- Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm, vartEredm);


        }
        [TestMethod]
        public void isBinaris_True() // A tesztmetodus nevében jelzem, hoyg melyik metodust tesztelem és mire
        {
            string szoveg2 = "21";
            bool vartEredm2 = true, kapottEredm2 = false;
            // Act- A vizsgált metódus végrehajtása
            kapottEredm2 = atvalt.isBinaris(szoveg2);
            // Act- Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm2, vartEredm2);


        }
        [TestMethod]
        public void isBinaris_False() // A tesztmetodus nevében jelzem, hoyg melyik metodust tesztelem és mire
        {
            string szoveg3 = "k";
            bool vartEredm3 = true, kapottEredm3 = false;
            // Act- A vizsgált metódus végrehajtása
            kapottEredm3 = atvalt.isBinaris(szoveg3);
            // Act- Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm3, vartEredm3);


        }
        [TestMethod]

        // Arrange-Tesztkörnyezet beállitása
        public void isDecimal_False2() { 
            string szoveg = "0110";
            bool vartEredm = false,
                kapottEredm = false; 

            //Act a vizsgát metodus vegrehajtasa
        kapottEredm=atvalt.isDecimal(szoveg);

            //Assert-Az eredmeny kiértékelése 
            Assert.AreEqual(kapottEredm, vartEredm);
        
        }

        [TestMethod]
        public void isBinaris_True1() // A tesztmetodus nevében jelzem, hoyg melyik metodust tesztelem és mire
        {
            string szoveg2 = "0110";
            bool vartEredm2 = true, kapottEredm2 = false;
            // Act- A vizsgált metódus végrehajtása
            kapottEredm2 = atvalt.isBinaris(szoveg2);
            // Act- Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm2, vartEredm2);


        }
        [TestMethod]
        public void isBinaris_False2() // A tesztmetodus nevében jelzem, hoyg melyik metodust tesztelem és mire
        {
            string szoveg3 = "xy";
            bool vartEredm3 = false, kapottEredm3 = false;
            // Act- A vizsgált metódus végrehajtása
            kapottEredm3 = atvalt.isBinaris(szoveg3);
            // Act- Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm3, vartEredm3);


        }
        [TestMethod]
        public void isBinaris_False3() // A tesztmetodus nevében jelzem, hoyg melyik metodust tesztelem és mire
        {
            string szoveg3 = "110";
            bool vartEredm3 = false, kapottEredm3 = false;
            // Act- A vizsgált metódus végrehajtása
            kapottEredm3 = atvalt.isBinaris(szoveg3);
            // Act- Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm3, vartEredm3);


        }
        [TestMethod]
        public void BinarisToDecimalisis_False() // A tesztmetodus nevében jelzem, hoyg melyik metodust tesztelem és mire
        {
            string szoveg3 = "001010";
            int vartEredm3 = 52, kapottEredm3 = 0;
            // Act- A vizsgált metódus végrehajtása
            kapottEredm3 = atvalt.binariaToDecimalis(szoveg3);
            // Act- Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm3, vartEredm3);
             

        }
    }
}
