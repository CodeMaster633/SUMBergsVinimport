using DTO_.Enums;

namespace DTO_.Model;

public class SpiritusDTO : IProdukt
{
    public SpiritusDTO() { }

    public SpiritusDTO( int pris, string navn, string beskrivelse,
        double alkoholprocent, double liter, int produktionsår, SpiritusType spiritusType)
    {
        Pris = pris;
        Navn = navn;
        Beskrivelse = beskrivelse;
        Liter = liter;
        Alkoholprocent = alkoholprocent;
        Produktionsår = produktionsår;
        SpiritusType = spiritusType;
    }
    public int Id { get; set; }
    public int Pris { get; set; }
    public string Navn { get; set; }
    public string Beskrivelse { get; set; }
    public double Liter { get; set; }
    public double Alkoholprocent { get; set; }
    public int Produktionsår { get; set; }
    public SpiritusType SpiritusType { get; set; }

}