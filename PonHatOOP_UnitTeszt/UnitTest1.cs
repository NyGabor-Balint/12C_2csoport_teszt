﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


[TestFixture]
public class TestPontHat
{
    [Test]
    public void TestJoPontszamok()
    {
        // Tesztelése a helyes pontszámoknak és az osztályzatoknak 
        PontHat pont = new PontHat(95);
        Assert.AreEqual("Pontszám: 95, Osztályzat: 5", pont.Eredmeny());

        pont.SetPontszam(85);
        Assert.AreEqual("Pontszám: 85, Osztályzat: 4", pont.Eredmeny());

        pont.SetPontszam(75);
        Assert.AreEqual("Pontszám: 75, Osztályzat: 3", pont.Eredmeny());

        pont.SetPontszam(55);
        Assert.AreEqual("Pontszám: 55, Osztályzat: 2", pont.Eredmeny());

        pont.SetPontszam(50);
        Assert.AreEqual("Pontszám: 50, Osztályzat: 2", pont.Eredmeny());
    }

    [Test]
    public void TestHatarErtekPontszamok()
    {
        // Tesztelese a határértékeket
        PontHat pont = new PontHat(90);
        Assert.AreEqual("Pontszám: 90, Osztályzat: 5", pont.Eredmeny());

        pont.SetPontszam(80);
        Assert.AreEqual("Pontszám: 80, Osztályzat: 4", pont.Eredmeny());

        pont.SetPontszam(65);
        Assert.AreEqual("Pontszám: 65, Osztályzat: 3", pont.Eredmeny());

        pont.SetPontszam(50);
        Assert.AreEqual("Pontszám: 50, Osztályzat: 2", pont.Eredmeny());
    }

    [Test]
    public void TestHibasPontszamok()
    {
        // Tesztelése a hibás pontszámoknak
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new PontHat(-1));
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new PontHat(101));

        PontHat pont = new PontHat(90);
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => pont.SetPontszam(-5));
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => pont.SetPontszam(105));
    }
}

internal class TestFixtureAttribute : Attribute
{
}

internal class TestAttribute : Attribute
{
}

internal class PontHat
{
    private int v;

    public PontHat(int v)
    {
        this.v = v;
    }

    internal string Eredmeny()
    {
        throw new NotImplementedException();
    }

    internal void SetPontszam(int v)
    {
        throw new NotImplementedException();
    }
}