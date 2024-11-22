using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Logic.BLL;
using DTO_.Model;
using Moq;
using NUnit;

namespace Test_Unit
{
    internal class ProduktTDD
    {

        private IProdukt _produktDTO;
        private LagerBLL _lagerBll;
        private LagerDTO lager;
        [SetUp]
        public void Setup()
        {

            _lagerBll = new LagerBLL();
            lager = _lagerBll.getLager(1);
        }




        [Test]
        public void OpretProduktForventetTestMAD()
        {
            //Arrange 
            _produktDTO = new MadDTO(200, "TEST", 10, "Dette er fra test ProduktTDD", new DateTime(2026, 10, 11));

        

            //ACT
            
            int _produktDTOId =_lagerBll.OpretProdukt(_produktDTO, lager);
            List<IProdukt> alleProdukter = _lagerBll.GetAlleProdukt();



            IProdukt produkt = _lagerBll.GetProdukt(_produktDTOId);
            bool produktEksister = alleProdukter.Any(p => p.Id == produkt.Id);
            // Assert - sammenligner DTO-objekt fra brugergrænseflade med objekt fra databasen
            Assert.That(produktEksister, Is.True, "Produkt blev ikke fundet");
            Assert.That(_produktDTOId,Is.EqualTo(produkt.Id));
        }


        [Test]
        public  void OpretProduktForventetTestNonFood()
        {
            //Arrange 

            _produktDTO = new NonfoodDTO(200, 10, "Test", "Dette er en beksrivelse til nonFood Test");



            //ACT
           int produktID = _lagerBll.OpretProdukt(_produktDTO,lager);
           List<IProdukt> alleProdukter = _lagerBll.GetAlleProdukt();
           IProdukt produkt = _lagerBll.GetProdukt(produktID);




            bool produktEksister = alleProdukter.Any(p => p.Id == produkt.Id);
            //Assert - sammenligner DTO-objekt fra brugergrænseflade med objekt fra databasen
            Assert.That(produktEksister, Is.True, "Produkt blev ikke fundet");
            Assert.That(produktID, Is.EqualTo(produkt.Id));


        }


        [Test]
        public  void OpretProduktForventetTestVin()
        {
            //Arrange 
            _produktDTO = new VinDTO(200,"TestVin", 10, "Test af ProduktTDD", DTO_.Enums.VinType.Rosevin, 200, "Italien");


            //ACT
           int produktID =  _lagerBll.OpretProdukt(_produktDTO,lager);
           IProdukt produkt = _lagerBll.GetProdukt(produktID);
           List<IProdukt> alleProdukter = _lagerBll.GetAlleProdukt();
           bool produktEksister = alleProdukter.Any(p => p.Id == produkt.Id );
            
            //Assert - sammenligner DTO-objekt fra brugergrænseflade med objekt fra databasen
            Assert.That(produktEksister, Is.True, "Produkt blev ikke fundet");
            Assert.That(produktID, Is.EqualTo(produkt.Id));
        }







        [Test]
        public void OpretProduktForventetTestSpiritus()
        {
            //Arrange 
            _produktDTO = new SpiritusDTO(200, "TestSpiritus", 200, "Dette er ProduktTDD test", 10.00, 24.00, 2023, DTO_.Enums.SpiritusType.Rom);



            //ACT
            int produktId = _lagerBll.OpretProdukt(_produktDTO, lager);
            IProdukt produkt = _lagerBll.GetProdukt(produktId);
            List<IProdukt> alleProdukter = _lagerBll.GetAlleProdukt();

            bool produktEksister = alleProdukter.Any(p => p.Id == produkt.Id);


            // Assert - sammenligner DTO-objekt fra brugergrænseflade med objekt fra databasen
            Assert.That(produktEksister, Is.True, "Produkt blev ikke fundet");
            Assert.That(produktId,Is.EqualTo(produkt.Id));




        }


           [Test]
            public void FjernProdukt()
            {
                //Arrange & ACT
    
                
              
            
            
            IProdukt specfiktRandomTestObjekt = _lagerBll.GetAlleProdukt().FirstOrDefault(p => p.Beskrivelse.EndsWith("ProduktTDD"));
            _lagerBll.FjernProdukt(specfiktRandomTestObjekt.Id);
            List<IProdukt> alleProdukter = _lagerBll.GetAlleProdukt();
            bool produktEksister = alleProdukter.Any(p=> p.Id == specfiktRandomTestObjekt.Id);
            //ASSERT
            Assert.That(produktEksister, Is.False);
         






            }

       

    }
}



