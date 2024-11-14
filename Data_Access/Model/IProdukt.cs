namespace Data_Access.Model;

public interface IProdukt
{
    int Id { get; set; }
    int Pris { get; set; }
    string Navn { get; set; }
    string Beskrivelse { get; set; }

    void TjekUdlobsdato()
    {
    }
    void Attach(IBesked besked)
    {
    }
    void Detach(Besked besked)
    {
    }
    void Notify(string besked)
    {
    }
}
