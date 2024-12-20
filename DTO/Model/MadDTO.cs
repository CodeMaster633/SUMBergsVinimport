namespace DTO.Model;

public class MadDTO : IProdukt
{
    public MadDTO()
    {
    }

    public MadDTO(int id, int pris, string navn, string beskrivelse, DateTime udløbsdato)
    {
        Id = id;
        Pris = pris;
        Navn = navn;
        Beskrivelse = beskrivelse;
        Udløbsdato = udløbsdato;
    }

    public int Id { get; set; }
    public int Pris { get; set; }
    public string Navn { get; set; }
    public string Beskrivelse { get; set; }
    public DateTime Udløbsdato { get; set; }
}