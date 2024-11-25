using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data_Access.Model;

public class TjekkedeProdukter
{
    [Key]
    public Guid TjekId { get; set; }
    
    [ForeignKey("Produkt")]
    public int ProduktId { get; set; }
    public Produkt? Produkt { get; set; }
    public string? Navn { get; set; }
    public int Antal { get; set; }
    public int LagerId { get; set; }
    public DateTime Udloebsdato { get; set; }
    public DateTime TjekketDato { get; set; }
    public string VisningsTekst => $"{Navn} - {Udloebsdato}";
}