using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controlleur.Entity.Salle.Personnels;

namespace Test.Entity.Salle.Personnel
{
    [TestClass]
    public class MaitreHotelTest
    {
        [TestMethod]
        public void TestGetInstance()
        {
            Assert.IsNotNull(MaitreHotel.GetInstance());
        }

    }
}
