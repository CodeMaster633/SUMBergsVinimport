using NUnit.Framework;
using DataAccess.Model;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void KorrektOprettelse()
        {
            //Arrange
            string navn = "Tilst Lager";
            string adresse = "Blomstervej 12";
            string kontaktperson = "Dennis";

            //Act
            var lager1 = new Lager(navn, adresse, kontaktperson); 

            //Assert
            Assert.AreEqual(navn, lager1.Navn); 
            Assert.AreEqual(adresse, lager1.Adresse);
            Assert.AreEqual(kontaktperson, lager1.Kontaktperson);

        }
    }
}