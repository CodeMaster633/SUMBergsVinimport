namespace Data_Access.Model;

public class Øl : Produkt
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
    
    
   
    public DateTime Udløbsdato { get; set; }
    public double Liter { get; set; }
}