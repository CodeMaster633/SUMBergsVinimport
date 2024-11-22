namespace Data_Access.Model;

public class Mad : Produkt
{
	public Mad() { }

	public Mad(int id, int pris, string navn, int antal, string beskrivelse, DateTime udloebsdato, int lagerId)
	{
		Id = id;
		Pris = pris;
		Navn = navn;
		Antal = antal;
		Beskrivelse = beskrivelse;
		Udloebsdato = udloebsdato;
		LagerId = lagerId; 
	}

	public DateTime Udloebsdato { get; set; }
    public override string ToString()
    {
        return $"Navn: {Navn}, Pris: {Pris} kr, Antal: {Antal}, Udløbsdato: {Udloebsdato.ToShortDateString()}, Lager ID: {LagerId}";
    }

}