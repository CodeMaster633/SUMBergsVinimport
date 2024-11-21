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
		public int LagerId {  get; set; }

		public void TjekUdlobsdato()
		{
			//if (Udlobsdato <= DateTime.Now.AddMonths(1))
			{
				Notify("Udløbsdato nærmer sig for produktet");
			}
		}
		public void Attach(IBesked besked)
		{
			beskeder.Add(besked);
		}

		public void Detach(IBesked besked)
		{
			beskeder.Remove(besked);
		}
		public void Notify(string besked)
		{
			Console.WriteLine("Notifying observers");
			foreach (var observer in beskeder)
			{
				observer.Update(this, besked);
			}
		}
		
		}
	}
