namespace Data_Access.Model;

public class Besked : IBesked
{
    private String _lastMessage;

    public Besked(IProdukt produkt)
    {
        produkt.Attach(this);
    }
    public void Update(IProdukt produkt, String besked)
    {
        _lastMessage = $"Modtaget besked: {besked} for produkt: {produkt.Navn}";    
        Console.WriteLine(_lastMessage);
        Console.WriteLine("Update kaldt med _lastMessage: " + _lastMessage);
    }

    public override String ToString()
    {
        return _lastMessage;
    }
}