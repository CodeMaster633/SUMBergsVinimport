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
        [SetUp]
        public void Setup()
        {

            _lagerBll = new LagerBLL();
        }




        [Test]
        public virtual void OpretProduktForventetTestMAD()
        {
            //Arrange 

            _produktDTO = new MadDTO( 200, "TEST", "Dette er fra test ProduktTDD", new DateTime(2026, 10, 11));

            //ACT

            _lagerBll.OpretProdukt(_produktDTO);
            _produktDTO.Id = 2;
            IProdukt produktTDD = _lagerBll.GetMadProdukt(2);
           



            //Assert ikke null
            Assert.That(produktTDD, Is.Not.Null);
            // Assert - sammenligner DTO-objekt fra brugergrænseflade med objekt fra databasen
            Assert.That(_produktDTO.Id, Is.EqualTo(produktTDD.Id));
        }


        [Test]
        public virtual void OpretProduktForventetTestNonFood()
        {
            //Arrange 

            _produktDTO = new NonfoodDTO(200, "Test", "Dette er en beksrivelse til nonFood Test");




            //ACT
            _lagerBll.OpretProdukt(_produktDTO);
            IProdukt produktTDD = _lagerBll.GetMadProdukt(_produktDTO.Id);



            //Assert 
            Assert.That(produktTDD, Is.Not.Null);
            // Assert - sammenligner DTO-objekt fra brugergrænseflade med objekt fra databasen
            Assert.That(_produktDTO.Id, Is.EqualTo(produktTDD.Id));
        }


        [Test]
        public virtual void OpretProduktForventetTestVin()
        {
            //Arrange 
            _produktDTO = new VinDTO( 200, "TestVin", "Test af ProduktTDD", DTO_.Enums.VinType.Rosevin, 200);


            //ACT
            _lagerBll.OpretProdukt(_produktDTO);
            IProdukt produktTDD = _lagerBll.GetVinProdukt(_produktDTO.Id);



            //Assert 
            Assert.That(produktTDD, Is.Not.Null);
            // Assert - sammenligner DTO-objekt fra brugergrænseflade med objekt fra databasen
            Assert.That(_produktDTO, Is.EqualTo(produktTDD));
        }


        [Test]
        public virtual void OpretProduktForventetTestSpiritus()
        {
            //Arrange 
            _produktDTO = new SpiritusDTO( 200, "TestSpiritus", "Dette er ProduktTDD test", 10.00, 24.00, 2023, DTO_.Enums.SpiritusType.Rom);



            //ACT
            _lagerBll.OpretProdukt(_produktDTO);
            IProdukt produktTDD = _lagerBll.GetSpiritusProdukt(_produktDTO.Id);



            //Assert 
            Assert.That(produktTDD, Is.Not.Null);
            // Assert - sammenligner DTO-objekt fra brugergrænseflade med objekt fra databasen
            Assert.That(_produktDTO, Is.EqualTo(produktTDD));
        }


    }






}
