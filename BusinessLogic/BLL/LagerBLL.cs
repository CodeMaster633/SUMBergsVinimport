using DTO.Model;

using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Model;
using DataAccess.Model;

namespace BussinessLogic.BLL
{
	public class LagerBLL
	{
		public void OpretProdukt(IProdukt produkt)
        public LagerDTO getLager(int id)
		{
            //if (id < 0) throw new IndexOutOfRangeException();
            return LagerRepository.getLager(id);
			
		}
        public List<LagerDTO> getLagre()

		public IProdukt GetProdukt(int produktId)
		{
            return LagerRepository.getLagre();
			return null;
		}
        //public void AddLager(LagerDTO lager)
        //{
        //    //valider lager
        //    LagerRepository.AddLager(lager);
        //}
       
	}
}
