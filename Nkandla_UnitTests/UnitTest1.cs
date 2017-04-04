using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nkandla;


namespace Nkandla_UnitTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Is_Person_Politician_Testmethod()
        {
            var person = new Person("Helen", 55, 'M', Type.Politician, Party.ANC);
            var result = person.Type;
            Assert.AreEqual(Type.Politician, result);
        }

        [TestMethod]
        public void May_Person_Visit_UnitTest()
        {
            var person = new Politician("Zuma", 55, 'M', Type.Politician, Party.ANC);
            var Create = new HomeStead("Zuma", "Wierda", "Gauteng", "Unfortunantly in RZA");
            person.visit(Create);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void MayNot_Person_Visit_UnitTest()
        {
            var person = new Politician("Helen", 55, 'M', Type.Politician, Party.DA);
            var Create = new HomeStead("Zuma", "Wierda", "Gauteng", "Unfortunantly in RZA");
            person.visit(Create);
        }

        [TestMethod]
        public void Create_Person_UnitTest()
        {
            var Create = new Person("Helen", 55, 'M', Type.Politician, Party.ANC);            
        }

        [TestMethod]
        public void Create_HomeStead_UnitTest()
        {
            var Create = new HomeStead("Zuma", "Wierda", "Gauteng", "Unfortunantly in RZA");
        }


    }
}
