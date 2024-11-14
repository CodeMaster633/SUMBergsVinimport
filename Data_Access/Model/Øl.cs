namespace Data_Access.Model;

public class Øl : Produkt
{
    public Øl() {}

    public Øl(int id, int pris, string navn, string beskrivelse, DateTime udloebsdato, double liter)
    {
        Id = id;
        Pris = pris;
        Navn = navn;
        Beskrivelse = beskrivelse;
        Udloebsdato = udloebsdato;
        Liter = liter;
    }
    
    
   
    public DateTime Udloebsdato { get; set; }
    public double Liter { get; set; }
}