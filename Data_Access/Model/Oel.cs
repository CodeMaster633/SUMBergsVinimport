namespace Data_Access.Model;

public class Oel : Produkt
{
    public Oel() {}

    public Oel(int id, int pris, string navn, int antal, string beskrivelse, DateTime udloebsdato, double liter)
    {
        Id = id;
        Pris = pris;
        Navn = navn;
        Antal = antal;
        Beskrivelse = beskrivelse;
        Udloebsdato = udloebsdato;
        Liter = liter;
    }
    
    
   
    public DateTime Udloebsdato { get; set; }
    public double Liter { get; set; }

    public override string ToString()
    {
        return $"Navn: {Navn}, Pris: {Pris} kr, Antal: {Antal}, Udløbsdato: {Udloebsdato.ToShortDateString()}, Liter: {Liter}, Lager ID: {LagerId}";
    }
}