using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein;
using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein.Tests
{
    [TestClass()]
    public class TreinTests
    {
        [TestMethod()]
        public void DierToevoegenWagonTest1()
        {
            Trein trein = new Trein();
            List<Dier> dieren = new List<Dier>();
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Klein, 1));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Klein, 1));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Klein, 1));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Klein, 1));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Klein, 1));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Middel, 3));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Middel, 3));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Middel, 3));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Groot, 5));

            trein.DierToevoegenWagon(dieren);

            int aantalWagons = trein.Wagons.Count;

            Assert.AreEqual(2, aantalWagons);
        }
        [TestMethod()]
        public void DierToevoegenWagonTest2()
        {
            Trein trein = new Trein();
            List<Dier> dieren = new List<Dier>();
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Groot, 5));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Groot, 5));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Groot, 5));
            dieren.Add(new Dier(Type.Carnivoor, Grootte.Middel, 3));
            dieren.Add(new Dier(Type.Carnivoor, Grootte.Middel, 3));
            dieren.Add(new Dier(Type.Carnivoor, Grootte.Middel, 3));
            dieren.Add(new Dier(Type.Carnivoor, Grootte.Klein, 1));
            dieren.Add(new Dier(Type.Carnivoor, Grootte.Groot, 5));
            dieren.Add(new Dier(Type.Carnivoor, Grootte.Groot, 5));
            trein.DierToevoegenWagon(dieren);

            int aantalWagons = trein.Wagons.Count;

            Assert.AreEqual(6, aantalWagons);
        }

        [TestMethod()]
        public void DierToevoegenWagonTest3()
        {
            Trein trein = new Trein();
            List<Dier> dieren = new List<Dier>();
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Klein, 1));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Klein, 1));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Klein, 1));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Klein, 1));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Klein, 1));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Middel, 3));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Middel, 3));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Middel, 3));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Middel, 3));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Middel, 3));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Groot, 5));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Groot, 5));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Groot, 5));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Groot, 5));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Groot, 5));
            dieren.Add(new Dier(Type.Carnivoor, Grootte.Groot, 5));
            dieren.Add(new Dier(Type.Carnivoor, Grootte.Groot, 5));
            dieren.Add(new Dier(Type.Carnivoor, Grootte.Middel, 3));
            dieren.Add(new Dier(Type.Carnivoor, Grootte.Middel, 3));
            dieren.Add(new Dier(Type.Carnivoor, Grootte.Klein, 1));
            dieren.Add(new Dier(Type.Carnivoor, Grootte.Klein, 1));
            trein.DierToevoegenWagon(dieren);

            int aantalWagons = trein.Wagons.Count;

            Assert.AreEqual(8, aantalWagons);
        }
        [TestMethod()]
        public void DierToevoegenWagonTest4()
        {
            Trein trein = new Trein();
            List<Dier> dieren = new List<Dier>();
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Klein, 1));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Middel, 3));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Middel, 3));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Middel, 3));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Groot, 5));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Groot, 5));

            trein.DierToevoegenWagon(dieren);

            int aantalWagons = trein.Wagons.Count;

            Assert.AreEqual(2, aantalWagons);
        }
        [TestMethod()]
        public void DierToevoegenWagonTest5()
        {
            Trein trein = new Trein();
            List<Dier> dieren = new List<Dier>();
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Middel, 3));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Middel, 3));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Middel, 3));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Groot, 5));
            dieren.Add(new Dier(Type.Herbivoor, Grootte.Groot, 5));
            dieren.Add(new Dier(Type.Carnivoor, Grootte.Klein, 1));

            trein.DierToevoegenWagon(dieren);

            int aantalWagons = trein.Wagons.Count;

            Assert.AreEqual(2, aantalWagons);
        }
    }
}


