using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controlleur.Entity.Cuisine.Personnel;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInstanceChef()
        {
            Chef chef = Chef.GetInstance();
            Assert.IsNotNull(chef,"Le chef n'est pas instancié");
        }

        [TestMethod]
        public void TestAddition()
        {
            Assert.Equals(2, (1 + 1));
        }
    }
}
