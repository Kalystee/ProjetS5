using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controlleur.Entity.Cuisine.Ustensiles;
using Controlleur.Entity.Cuisine.Personnel;
using System.Collections.Generic;

namespace Test.Entity.Cuisine.Personnel
{
    [TestClass]
    public class PlongeurTest
    {
        [TestMethod]
        public void nettoyerUstensileTest()
        {
            Plongeur p = new Plongeur();
            List<Ustensile> listU = new List<Ustensile>();
            listU.Add(new GrosUstensile(1,"gros"));
            listU.Add(new PetitUstensile(2, "petit"));
            p.nettoyerUstensile(listU);
           
        }
    }
}
