using Business_Logic.BLL;
using DTO_.Model;


namespace Test_Unit;

[TestFixture]
public class UdloebsdatoBeskedTest
{
    private IProdukt _produkt;
    
    [Test]
    public virtual void UdloebsdatoBesked()
    {
        //Arrange
        _produkt = new Mad(99, 200, "TEST", "Dette er fra test UdloebsdatoBesked", new DateTime(2024, 11, 30));
        var besked = new Besked(_produkt);

        //Act
        _produkt.TjekUdlobsdato();
        
        //Assert
        Console.WriteLine("Test Output: " + besked.ToString());
        Assert.That(besked.ToString(), Is.EqualTo("Modtaget besked: Udløbsdato nærmer sig for produktet for produkt: TEST"));        
        
    }
}