namespace Data_Access.Model;

public class Mad : Produkt
{
	public Mad() { }

	public Mad(int id, int pris, string navn, int antal, string beskrivelse, DateTime udloebsdato)
	{
		Id = id;
		Pris = pris;
		Navn = navn;
		Antal = antal;
		Beskrivelse = beskrivelse;
		Udloebsdato = udloebsdato;
	}

	public DateTime Udloebsdato { get; set; }

}