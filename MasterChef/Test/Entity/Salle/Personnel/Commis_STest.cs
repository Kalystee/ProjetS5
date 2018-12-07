using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controlleur.Entity.Salle.Personnels;

namespace Test.Entity.Salle.Personnel
{
    [TestClass]
    public class Commis_STest
    {
        [TestMethod]
        public void TestGetInstance()
        {
            Assert.IsNotNull(Commis_S.GetInstance());
        }
    }
}
