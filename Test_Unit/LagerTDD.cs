using NUnit.Framework;
using DTO_.Model;
using Business_Logic.BLL;

namespace Test_Unit
{
    public class LagerTDD
    {
        LagerBLL lagerBll;

        [SetUp]
        public void Setup()
        {
            lagerBll = new LagerBLL();
        }

        [Test]
        public void KorrektOprettelse()
        {
            //Arrange
            string navn = "Tilst Lager";
            string adresse = "Blomstervej 12";
            string kontaktperson = "Dennis The Man";

            //Act
            var lager1 = new LagerDTO(navn, adresse, kontaktperson);
            lagerBll.AddLager(lager1);
            List<LagerDTO> lagreListe = lagerBll.getLagre();
            LagerDTO lager2 = lagreListe[lagreListe.Count()-1];

            //Assert
            Assert.AreEqual(navn, lager2.Navn);
            Assert.AreEqual(adresse, lager2.Adresse);
            Assert.AreEqual(kontaktperson, lager2.Kontaktperson);

        }

        public void TilføjReol()
        {
            //Arrange
            string navn = "Hylde Lager";
            string adresse = "Blomstervej 12";
            string kontaktperson = "Dennis The Man";
            var lager1 = new LagerDTO(navn, adresse, kontaktperson);
            lagerBll.AddLager(lager1);
            List<LagerDTO> lagreListe = lagerBll.getLagre();
            LagerDTO lager2 = lagreListe[lagreListe.Count() - 1];

            //Act
            lager2.Tilføj(new ReolDTO());
           

            //Assert
            Assert.NotNull(lager2.Reoler);
        }
        public void TilføjReolNull()
        {
            //Arrange
            string navn = "Hylde Lager";
            string adresse = "Blomstervej 12";
            string kontaktperson = "Dennis The Man";
            var lager1 = new LagerDTO(navn, adresse, kontaktperson);
            lagerBll.AddLager(lager1);
            List<LagerDTO> lagreListe = lagerBll.getLagre();
            LagerDTO lager2 = lagreListe[lagreListe.Count() - 1];

            //Act


            //Assert
            Assert.IsNull(lager2.Reoler);
        }
    }
}