namespace Data_Access.Model;

public class Øl : IProdukt
{
    public Øl() {}

    public Øl(int id, int pris, string navn, string beskrivelse, DateTime udløbsdato, double liter)
    {
        Id = id;
        Pris = pris;
        Navn = navn;
        Beskrivelse = beskrivelse;
        Udløbsdato = udløbsdato;
        Liter = liter;
    }
    
    
    public int Id { get; set; }
    public int Pris { get; set; }
    public string Navn { get; set; }
    public string Beskrivelse { get; set; }
    public DateTime Udløbsdato { get; set; }
    public double Liter { get; set; }
}