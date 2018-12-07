using System;
using Controlleur.Entity.Cuisine.Plats;
using Controlleur.Entity.Salle;
using Controlleur.Entity.Salle.Disposition;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Entity.Salle
{
    [TestClass]
    public class CommandeTest
    {
        [TestMethod]
        public void TestCommanderPlat()
        {
            Commande commande = new Commande(new Table(), new Plat());

            commande.Table = new Table();
            commande.Table.Disponible = true;
            commande.CommanderPlat();
            Assert.IsNull(commande.Table);

        }
    }
}
