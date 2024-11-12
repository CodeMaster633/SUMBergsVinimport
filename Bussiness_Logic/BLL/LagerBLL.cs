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
		public void OpretProdukt(IProdukt produkt)
		{
			LagerRepository.OpretProdukt(produkt);
		}

        public MadDTO GetMadProdukt(int produktId)
        {
            return LagerRepository.GetMadById(produktId);

        }

        public VinDTO GetVinProdukt(int produktId)
        {
            return LagerRepository.GetVinById(produktId);
        }

        public ØlDTO GetØlProdukt(int produktId)
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

        public void AddLager(LagerDTO lager)
        {
            //valider lager
            LagerRepository.AddLager(lager);
        }

        //public MadDTO GetProdukt(int produktId)
        //{
        //	return LagerRepository.GetMadById(produktId);

        //}





        //Tildeling af lokation funktion

        public void TildelPladsProdut(string pladsId, string produktId)
		{

		}

		public void TildelHyldePlads(string hyldeId, string pladsId)
		{

		}
		
		public void TildelReolHylder(string reolId, string hyldeId)
		{

		}

		public void TildelLagerReol(string lagerId, string reolId)
		{

		}



		public void TildelRelation(string parentId, string childId, ReltationType relationType)
		{
		
			



		}
		

	}
}
