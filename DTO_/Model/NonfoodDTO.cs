namespace DTO_.Model;

public class NonfoodDTO : IProdukt
{
 public NonfoodDTO(){}

 public NonfoodDTO( int pris, string navn, string beskrivelse)
 {

  Pris = pris;
  Navn = navn;
  Beskrivelse = beskrivelse;
  
 }
 public int Id { get; set; }
 public int Pris { get; set; }
 public string Navn { get; set; }
 public string Beskrivelse { get; set; }
    public int LagerId { get; set; }


}