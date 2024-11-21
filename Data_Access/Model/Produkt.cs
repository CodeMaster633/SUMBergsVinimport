using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Model
{
	public class Produkt : IProdukt
	{
		public int Id { get; set; }
		public int Pris { get; set; }
		public string Navn { get; set; }
		public int Antal { get; set; }
		public string Beskrivelse { get; set; }
		
		}
	}
