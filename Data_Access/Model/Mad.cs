namespace Data_Access.Model;

public class Mad : Produkt
{
	public Mad() { }

	public Mad(int id, int pris, string navn, string beskrivelse, DateTime udløbsdato)
	{
		Id = id;
		Pris = pris;
		Navn = navn;
		Beskrivelse = beskrivelse;
		Udløbsdato = udløbsdato;
	}

	public DateTime Udløbsdato { get; set; }

}