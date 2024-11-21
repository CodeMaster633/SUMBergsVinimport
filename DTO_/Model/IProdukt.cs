using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_.Model
{
	public interface IProdukt
	{
		int Id { get; set; }
		int Pris { get; set; }
		string Navn { get; set; }
		string Beskrivelse { get; set; }
		int LagerId {  get; set; }
	}
}
