using Data_Access.Enums;
using DTO_.Model;
using VinType = DTO_.Enums.VinType;

namespace Data_Access.Model;

public class Vin : IProdukt
{
    public Vin(){}

    public Vin(int id, int pris, string navn, string beskrivelse, VinType vinType, double liter)
    {
        Id = id;
        Pris = pris;
        Navn = navn;
        Beskrivelse = beskrivelse;
        VinType = vinType;
        Liter = liter;
    }
    
    public int Id { get; set; }
    public int Pris { get; set; }
    public string Navn { get; set; }
    public string Beskrivelse { get; set; }
    public DTO_.Enums.VinType VinType { get; set; }
    public double Liter { get; set; }
}