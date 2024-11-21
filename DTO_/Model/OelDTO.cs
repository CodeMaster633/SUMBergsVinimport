using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_.Model
{
	public class OelDTO : IProdukt
	{
		public OelDTO(){}
		public OelDTO( int pris, string navn, int antal, string beskrivelse, DateTime udloebsDato, double liter)
		{
		
			Pris = pris;
			Navn = navn;
			Antal = antal;
			Beskrivelse = beskrivelse;
			Udloebsdato = udloebsDato;
			Liter = liter;
		}

		public int Id { get; set; }
		public int Pris { get; set; }
		public string Navn { get; set; }
		public int Antal { get; set; }
		public string Beskrivelse { get; set; }
		public DateTime Udloebsdato { get; set; }
		public double Liter { get; set; }
}
}
