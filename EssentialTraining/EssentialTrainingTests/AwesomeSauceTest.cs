using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;

namespace EssentialTrainingTests
{
    [TestClass]
    public class AwesomeSauceTest
    {
        [TestMethod]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSauce();
            testInstance.Sauces.Add("Tabasco");
            testInstance.Sauces.Add("Cholula");
            testInstance.Sauces.Add("Ranch");

            // expect pass
            Assert.IsTrue(testInstance.IsSauceAwesome("Ranch"));

            // expect false
            Assert.IsFalse(testInstance.IsSauceAwesome("Ketchup"));
        }
    }
}
