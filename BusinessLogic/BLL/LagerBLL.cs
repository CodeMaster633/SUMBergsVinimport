using DTO.Model;

using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;

namespace BussinessLogic.BLL
{
    public class LagerBLL
    {
        public LagerDTO getLager(int id)
        {
            //if (id < 0) throw new IndexOutOfRangeException();
            return LagerRepository.getLager(id);
        }
        public List<LagerDTO> getLagre()
        {
            return LagerRepository.getLagre();
        }
        //public void AddLager(LagerDTO lager)
        //{
        //    //valider lager
        //    LagerRepository.AddLager(lager);
        //}
       
    }
}
