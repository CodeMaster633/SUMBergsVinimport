using Data_Access.Enums;
using DTO_.Model;
using VinType = DTO_.Enums.VinType;

namespace Data_Access.Model;

public class Vin : Produkt
{
    public Vin(){}

    public Vin(int id, int pris, string navn, int antal, string beskrivelse, VinType vinType, double liter, string nationalitet)
    {
        Id = id;
        Pris = pris;
        Navn = navn;
        Antal = antal;
        Beskrivelse = beskrivelse;
        VinType = vinType;
        Liter = liter;
        Nationalitet = nationalitet;
    }
    
   
    public DTO_.Enums.VinType VinType { get; set; }
    public double Liter { get; set; }
    public string Nationalitet { get; set; }
}