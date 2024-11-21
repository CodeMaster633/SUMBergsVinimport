namespace Data_Access.Model;

public interface IProdukt
{
    int Id { get; set; }
    int Pris { get; set; }
    string Navn { get; set; }
    int Antal { get; set; }
    string Beskrivelse { get; set; }
    
}
