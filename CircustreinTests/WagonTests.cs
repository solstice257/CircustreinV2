using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein;
using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein.Tests
{
    [TestClass()]
    public class WagonTests
    {
        Wagon wagon;

        [TestInitialize]
        public void testInitialize()
        {
            wagon = new Wagon();
        }

        [TestMethod()]
        public void GeenPlekTestFalse()
        {
            Dier dier = new Dier(Type.Carnivoor, Grootte.Groot, 5);
            Assert.IsFalse(wagon.GeenPlek(dier));
        }

        [TestMethod()]
        public void GeenPlekTestTrue()
        {
            Dier dier = new Dier(Type.Carnivoor, Grootte.Groot, 12);
            Assert.IsTrue(wagon.GeenPlek(dier));
        }

        [TestMethod()]
        public void VoegDierToeSucces()
        {
            Dier dier = new Dier(Type.Carnivoor, Grootte.Groot, 5);
            wagon.VoegDierToe(dier);
            int x = wagon.alleDierenInWagon.Count;
            Assert.AreEqual(1, x);
        }

        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException),
        "Invalid use of stub code. First set field existsReturnValue.")]
        public void VoegDierToeFailed()
        {
            Dier dier = null;
            wagon.VoegDierToe(dier);
            int x = wagon.alleDierenInWagon.Count;
            Assert.AreEqual(0, x);
        }
    }
}