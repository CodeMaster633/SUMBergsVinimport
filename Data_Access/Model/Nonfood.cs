namespace Data_Access.Model;

public class Nonfood : IProdukt
{
    public Nonfood() {}

    public Nonfood(int id, int pris, string navn, string beskrivelse)
    {
        Id = id;
        Pris = pris;
        Navn = navn;
        Beskrivelse = beskrivelse;
    }
    public int Id { get; set; }
    public int Pris { get; set; }
    public string Navn { get; set; }
    public string Beskrivelse { get; set; }
    
}