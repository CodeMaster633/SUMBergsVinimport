namespace DTO_.Model;

public class MadDTO : IProdukt
{
    public MadDTO()
    {
    }

    public MadDTO( int pris, string navn, int antal, string beskrivelse, DateTime udloebsdato)
    {
       
        Pris = pris;
        Navn = navn;
        Antal = antal;
        Beskrivelse = beskrivelse;
        Udloebsdato = udloebsdato;
    }

    public int Id { get; set; }
    public int Pris { get; set; }
    public string Navn { get; set; }
    public int Antal { get; set; }
    public string Beskrivelse { get; set; }
    public DateTime Udloebsdato { get; set; }
    public int LagerId { get; set; }
}