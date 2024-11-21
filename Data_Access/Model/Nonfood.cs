namespace Data_Access.Model;

public class Nonfood : Produkt
{
    public Nonfood() {}

    public Nonfood(int id, int pris, string navn, int antal, string beskrivelse)
    {
        Id = id;
        Pris = pris;
        Navn = navn;
        Antal = antal;
        Beskrivelse = beskrivelse;
    }
   
    
}