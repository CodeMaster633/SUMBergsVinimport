using Data_Access.Enums;
using SpiritusType = DTO_.Enums.SpiritusType;

namespace Data_Access.Model;

public class Spiritus : IProdukt
{
    public Spiritus(){}

    public Spiritus(int id, int pris, string navn, string beskrivelse, double alkoholprocent, double liter, int produktionsår, SpiritusType spiritusType)
    {
        Id = id;
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
    public DTO_.Enums.SpiritusType SpiritusType  { get; set; }
}