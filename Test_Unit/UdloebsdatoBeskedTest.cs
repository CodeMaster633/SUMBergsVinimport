using Business_Logic.BLL;
using DTO_.Model;
using IProdukt = DTO_.Model.IProdukt;

namespace Test_Unit;
public class UdloebsdatoBeskedTest
{
    private LagerBLL _lagerBll;
    private LagerDTO lager;
    [SetUp]
    public void Setup()
    {

        _lagerBll = new LagerBLL();
        lager = _lagerBll.getLager(1);
    }
    [Test]
    public void UdloebsDatoTest()
    {
        //Arrange
        var p1 = new MadDTO(250, "Burger", 20, "Dette er fra test UdloebsDatoTest", new DateTime(2024, 12, 30));
        var p2 = new OelDTO(200, "Gamma", 50, "Dette er fra test UdloebsDatoTest", new DateTime(2024, 12, 30), 0.5);
        
        //Act
        _lagerBll.OpretProdukt(p1, lager);
        _lagerBll.OpretProdukt(p2, lager);
        var tjekedeprodukter = _lagerBll.DatoTjek();
        
        //Assert
        Assert.That(tjekedeprodukter.Any(p => p is MadDTO mad && mad.Navn == p1.Navn && mad.Udloebsdato == p1.Udloebsdato));
        Assert.That(tjekedeprodukter.Any(p => p is OelDTO mad && mad.Navn == p2.Navn && mad.Udloebsdato == p2.Udloebsdato));
    }
}