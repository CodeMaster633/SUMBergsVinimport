using NUnit.Framework;
using DataAccess.Model;
using Moq;
using BussinessLogic.BLL;

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
            int id = 1;
            string navn = "Tilst Lager";
            string adresse = "Blomstervej 12";
            string kontaktperson = "Dennis";

            //Act
            var lager1 = new Lager(id, navn, adresse, kontaktperson);

            //Assert
            Assert.AreEqual(navn, lager1.Navn); 
            Assert.AreEqual(adresse, lager1.Adresse);
            Assert.AreEqual(kontaktperson, lager1.Kontaktperson);

        }
    }
}