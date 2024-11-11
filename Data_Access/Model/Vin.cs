using Data_Access.Enums;
using DTO_.Model;
using VinType = DTO_.Enums.VinType;

namespace Data_Access.Model;

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
    
   
    public DTO_.Enums.VinType VinType { get; set; }
    public double Liter { get; set; }
}