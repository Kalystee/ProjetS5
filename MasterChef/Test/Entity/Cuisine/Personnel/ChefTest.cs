using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controlleur.Entity.Cuisine.Personnel;

namespace Test.Entity.Cuisine.Personnel
{
    [TestClass]
    public class ChefTest
    {
        [TestMethod]
        public void GetInstanceTest()
        {
            Assert.IsNotNull(Chef.GetInstance(), "Le chef à été mal instancié, car il n'existe pas");
        }

       /* [TestMethod]
        public void MethodeeTest()
        {
            
        }*/
    }
}
