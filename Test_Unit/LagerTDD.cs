using NUnit.Framework;
using DTO_.Model;
using Business_Logic.BLL;

namespace Test_Unit
{
    public class LagerTDD
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void KorrektOprettelse()
        {
            //Arrange
            int id = 4;
            string navn = "Tilst Lager";
            string adresse = "Blomstervej 12";
            string kontaktperson = "Dennis The Man";
            //int antalReoler = 2;

            //Act
            var lager1 = new LagerDTO(navn, adresse, kontaktperson);
            LagerBLL lagerBLL = new LagerBLL();
            lagerBLL.AddLager(lager1);
            LagerDTO lager2 = lagerBLL.getLager(id);


            //Assert
            Assert.AreEqual(navn, lager1.Navn); 
            Assert.AreEqual(adresse, lager1.Adresse);
            Assert.AreEqual(kontaktperson, lager1.Kontaktperson);
            //Assert.That(lager1.Reoler.Count(), Is.EqualTo(antalReoler));

            Assert.AreEqual(navn, lager2.Navn);
            Assert.AreEqual(adresse, lager2.Adresse);
            Assert.AreEqual(kontaktperson, lager2.Kontaktperson);
            //Assert.That(lager2.Reoler.Count(), Is.EqualTo(antalReoler));

        }
    }
}