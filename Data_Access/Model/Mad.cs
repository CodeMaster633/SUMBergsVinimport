namespace Data_Access.Model;

public class Mad : Produkt
{
	public Mad() { }

	public Mad(int id, int pris, string navn, string beskrivelse, DateTime udloebsdato, int lagerId)
	{
		Id = id;
		Pris = pris;
		Navn = navn;
		Beskrivelse = beskrivelse;
		Udloebsdato = udloebsdato;
		LagerId = lagerId; 
	}

	public DateTime Udloebsdato { get; set; }


}