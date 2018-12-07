using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controlleur.Entity.Salle.Personnels;
using Controlleur.Entity.Salle;
using Controlleur.Entity.Salle.Disposition;
using Controlleur.Entity.Cuisine.Plats;


namespace Test.Entity.Salle.Personnel
{
    [TestClass]
    public class ServeurTest
    {
        [TestMethod]
        public void TestServirCommande()
        {
            Serveur serveur = new Serveur(20);

            serveur.Commande = new Commande(new Table(),new Plat());
            serveur.Commande.GetPlat().EstPret = true;
            serveur.ServirCommande();
            Assert.IsNull(serveur.Commande);
        }
    }
}
