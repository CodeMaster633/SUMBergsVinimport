namespace Data_Access.Model;

public class TjekkedeProdukter
{
    public Guid TjekId { get; set; }
    public int Id { get; set; }
    public string? Navn { get; set; }
    public int Antal { get; set; }
    public DateTime Udloebsdato { get; set; }
    public DateTime TjekketDato { get; set; }
}