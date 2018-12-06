using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controlleur.Entity.Cuisine.Plats;

namespace Test.Entity.Cuisine.Plats
{
    [TestClass]
    public class ZoneConservTest
    {
        ZoneConserv zone = new ZoneConserv();

        [TestMethod]
        public void TestAddIngredient()
        {
            Ingredient i = new Ingredient();
            this.zone.AddIngredient(i);
            Assert.Equals(this.zone.ingresdients[this.zone.ingredients.Count - 1], i);
        }

        [TestMethod]
        public void TestDeleteIngredient()
        {
            Ingredient i = new Ingredient();
            this.zone.AddIngredient(i);
            this.zone.DeleteIngredient(i);
            Assert.IsNull(this.zone.ingredients.Exists(X => X.Equals(i)) );
        }

        [TestMethod]
        public void TestUseIngredient()
        {
            Ingredient tomate = new Ingredient();
            int qty = tomate.Quantite;
            this.zone.UseIngredient(tomate, 2);
            Assert.Equals(qty - 2, tomate.Quantite);
        }


    }
}
