using DTO_.Enums;

namespace DTO_.Model;

public class SpiritusDTO : IProdukt
{
    public SpiritusDTO() { }

    public SpiritusDTO( int pris, string navn, int antal, string beskrivelse,
        double alkoholprocent, double liter, int produktionsaar, SpiritusType spiritusType)
    {
        Pris = pris;
        Navn = navn;
        Antal = antal;
        Beskrivelse = beskrivelse;
        Liter = liter;
        Alkoholprocent = alkoholprocent;
        Produktionsaar = produktionsaar;
        SpiritusType = spiritusType;
    }
    public int Id { get; set; }
    public int Pris { get; set; }
    public string Navn { get; set; }
    public int Antal { get; set; }
    public string Beskrivelse { get; set; }
    public double Liter { get; set; }
    public double Alkoholprocent { get; set; }
    public int Produktionsaar { get; set; }
    public SpiritusType SpiritusType { get; set; }
    public int LagerId { get; set; }

}