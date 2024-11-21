using DTO_.Model;

using Data_Access.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_.Model;
using Microsoft.EntityFrameworkCore;

namespace Business_Logic.BLL
{
	public class LagerBLL
	{
		//Opret produkt tager Super klasen for at gør denne metode mulige at oprette alle produkt sub typer i databasen
		public int OpretProdukt(IProdukt produkt,LagerDTO lager)
		{
			return LagerRepository.OpretProdukt(produkt,lager);
		}
		public List<IProdukt> GetAlleProdukt()
		{
			return LagerRepository.GetAlleProdukter();
		}

        public MadDTO GetMadProdukt(int produktId)
        {
            return LagerRepository.GetMadById(produktId);

        }

        public VinDTO GetVinProdukt(int produktId)
        {
            return LagerRepository.GetVinById(produktId);
        }

        public OelDTO GetØlProdukt(int produktId)
        {
            return LagerRepository.GetØlById(produktId);
        }

        public SpiritusDTO GetSpiritusProdukt(int produktId)
        {
            return LagerRepository.GetSpiritusDTO(produktId);
        }

        public NonfoodDTO GetNonfoodProdukt(int produktId)
        {
            return LagerRepository.GetNonfoodDTO(produktId);
        }

        

	


		//Lager Funktionalitet 

        public LagerDTO getLager(int id)
		{
            //if (id < 0) throw new IndexOutOfRangeException();
            return LagerRepository.getLager(id);
			
		}
        public List<LagerDTO> getLagre()
		{
			return LagerRepository.getLagre() ?? new List<LagerDTO>();
			
		}

		public List<IProdukt> getProdukterPaaLager(int id)
		{
			return LagerRepository.getProdukterPaaLager(id) ?? new List<IProdukt>();
		}

        public void AddLager(LagerDTO lager)
        {
            //valider lager
            LagerRepository.AddLager(lager);
        }

		//public MadDTO GetProdukt(int produktId)
		//{
		//	return LagerRepository.GetMadById(produktId);

		//}


		public void OpretReol(int antalHylder, int antalPladserPrHylde, LagerDTO lager) {
			LagerRepository.OpretReol(antalHylder, antalPladserPrHylde, lager);
		
        }
       
		
		
		

		

		public void FjernProdukt(int Id)
		{
			LagerRepository.FjernProdukt(Id);
		}

		public IProdukt GetProdukt(int id)
		{
			return LagerRepository.GetProdukt(id);
		}


		public void TildelRelation(string parentId, string childId, ReltationType relationType)
		{
		
			



		}
		//Udløbsdato besked
		public List<IProdukt> DatoTjek()
		{
			return LagerRepository.TjekUdlobsdato();
		}

	}
}
