using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Entity.Cuisine.Machines
{
    [TestClass]
    public class MachineCuissonTest
    {
       
        {[TestMethod]
        public void TestCuisson()
        {
            Machinecuisson c = new MachineCuisson();
            Bouffe b = new Bouffe();

            b.isNoncuisiner = true;

            z.listAliment.Add(b);
            z.Cuisson();
            Assert.IsFalse(b.isNoncuisiner);
        }
    }
    }
