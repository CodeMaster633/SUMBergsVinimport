namespace DTO_.Model;

public class NonfoodDTO : IProdukt
{
 public NonfoodDTO(){}

 public NonfoodDTO( int pris, int antal, string navn, string beskrivelse)
 {

  Pris = pris;
  Navn = navn;
  Antal = antal;
  Beskrivelse = beskrivelse;
  
 }
 public int Id { get; set; }
 public int Pris { get; set; }
 public string Navn { get; set; }
 public int Antal { get; set; }
 public string Beskrivelse { get; set; }
 
}