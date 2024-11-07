using DTO.Enums;

namespace DTO.Model;

public class Vin : Produkt
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
    public VinType VinType { get; set; }
    public double Liter { get; set; }
}