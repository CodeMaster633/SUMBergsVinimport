namespace DataAccess.Model;

interface IProdukt
{
    int Id { get; set; }
    int Pris { get; set; }
    string Navn { get; set; }
    string Beskrivelse { get; set; }
}