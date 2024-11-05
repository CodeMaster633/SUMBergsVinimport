using DataAccess.Model;
using DTO.Model;

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
            lager1 = new Lager();
            //lager2 = new Lager(navn, adresse, kontaktperson);

            //Assert
            Assert.AreEqual(navn, lager1.navn);
            Assert.AreEqual(adresse, lager1.adresse);
            Assert.AreEqual(kontaktperson, lager1.kontaktperson);

        }

        [Test]
        public void FejlOprettelse()
        {
            Assert.AreEqual(1, 1);
        }
    }
}