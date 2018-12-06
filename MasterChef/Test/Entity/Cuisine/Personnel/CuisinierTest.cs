using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controlleur.Entity.Cuisine.Personnel;
using Controlleur.Entity.Cuisine.Plats;

namespace Test.Entity.Cuisine.Personnel
{
    [TestClass]
    public class CuisinierTest
    {
        [TestMethod]
        public void préparerPlatTest()
        {
            Cuisinier c = new Cuisinier();
            Plat p = new Plat();
            c.preparerPlat(p);
           // Assert.
        }

        [TestMethod]
        public void AllerCuireTest()
        {
            Cuisinier c = new Cuisinier();
            Plat p = new Plat();
            c.allerCuire();
          //  Assert.
        }

        [TestMethod]
        public void préparerAccompagnementTest()
        {
            Cuisinier c = new Cuisinier();
            Ingredient i = new Ingredient();
            c.préparerAccompagnement(i);
           // Assert.
        }
    }
}
