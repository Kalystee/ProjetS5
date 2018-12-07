using System;
using Controlleur.Entity.Salle.Personnels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controlleur.Entity.Salle;
using Controlleur.Entity.Cuisine.Plats;
using Controlleur.Entity.Salle.Disposition;

namespace Test.Entity.Salle.Personnel
{
    [TestClass]
    public class ChefRangTest
    {
        [TestMethod]
        public void TestPrendreCommande()
        {
            ChefRang chefRang = new ChefRang(30);

            Table t = new Table();
            Plat p = new Plat();
            chefRang.PrendreCommande(t,p);
            Assert.Equals(chefRang.Commande, new Commande(t, p));
        }
    }
}
