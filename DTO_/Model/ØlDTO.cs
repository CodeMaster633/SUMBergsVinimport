﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_.Model
{
	public class ØlDTO : IProdukt
	{
		public ØlDTO(){}
		public ØlDTO( int pris, string navn, string beskrivelse, DateTime udløbsDato, double liter)
		{
		
			Pris = pris;
			Navn = navn;
			Beskrivelse = beskrivelse;
			Udløbsdato = udløbsDato;
			Liter = liter;
		}

		public int Id { get; set; }
		public int Pris { get; set; }
		public string Navn { get; set; }
		public string Beskrivelse { get; set; }
		public DateTime Udløbsdato { get; set; }
		public double Liter { get; set; }
}
}
