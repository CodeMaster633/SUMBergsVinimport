using DTO_.Enums;

namespace DTO_.Model;

public class VinDTO : IProdukt
{
    public VinDTO(){}

    public VinDTO( int pris, string navn, int antal, string beskrivelse, VinType vinType, double liter, string nationalitet)
    {
      
        Pris = pris;
        Navn = navn;
        Antal = antal;
        Beskrivelse = beskrivelse;
        VinType = vinType;
        Liter = liter;
        Nationalitet = nationalitet;
    }
    public int Id { get; set; }
    public int Pris { get; set; }
    public string Navn { get; set; }
    public int Antal { get; set; }
    public string Beskrivelse { get; set; }
    public VinType VinType { get; set; }
    public double Liter { get; set; }
    public string Nationalitet { get; set; }
    public int LagerId { get; set; }
}