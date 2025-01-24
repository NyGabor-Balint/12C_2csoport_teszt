using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void isBinaris_True() // A tesztmetodus nevében jelzem, hoyg melyik metodust tesztelem és mire
        {
            string szoveg1 = "21";
            bool vartEredm1 = true, kapottEredm1 = false;
            // Act- A vizsgált metódus végrehajtása
            kapottEredm1 = atvalt.isBinaris(szoveg1);
            // Act- Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm1, vartEredm1);


        }
       
    }
}
