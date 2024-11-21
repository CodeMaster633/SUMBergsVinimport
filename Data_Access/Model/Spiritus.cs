using Data_Access.Enums;
using SpiritusType = DTO_.Enums.SpiritusType;

namespace Data_Access.Model;

public class Spiritus : Produkt
{
	public Spiritus() { }

	public Spiritus(int id, int pris, string navn, int antal, string beskrivelse, double alkoholprocent, double liter, int produktionsår, SpiritusType spiritusType)
	{
		Id = id;  // Egenskaber fra Produkt kan sættes her
		Pris = pris;
		Navn = navn;
		Antal = antal;
		Beskrivelse = beskrivelse;
		Alkoholprocent = alkoholprocent;
		Liter = liter;
		Produktionsår = produktionsår;
		SpiritusType = spiritusType;
	}

	public double Alkoholprocent { get; set; }
	public double Liter { get; set; }
	public int Produktionsår { get; set; }
	public SpiritusType SpiritusType { get; set; }
}