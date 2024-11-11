using DTO_.Model;
using Data_Access.Context;
using Data_Access.Mappers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access.Model;


namespace Data_Access.Repositories
{
    public class LagerRepository
    {
        public static LagerDTO getLager(int id)
        {
            using (LagerContext context = new LagerContext())
            {
                //Maybe throw exception if not found
                return LagerMapper.Map(context.Lagre.Find(id));
            }
        }
        public static List<LagerDTO> getLagre()
        {
            
                using (LagerContext context = new LagerContext())
                {

                    List<Lager> lagre = context.Lagre.ToList();
                    List<LagerDTO> lagreDTO = lagre.Select(lager => LagerMapper.Map(lager)).ToList();
                return lagreDTO;
                }
            }


		public void TildelRelation(string parentId, string childId, DTO_.Model.ReltationType relationType)
		{
			//     usning()
			//switch (relationType)
			//{
			//	case ReltationType.LagerTilReol:
			//		var lager = _context.Lagere.Find(parentId);
			//		var reol = _context.Reoler.Find(childId);
			//		if (lager == null || reol == null) throw new Exception("Lager eller Reol ikke fundet.");
			//		reol.LagerId = parentId;
			//		break;
			//}
		}

public static void AddLager(LagerDTO lager)
{
	using (LagerContext context = new LagerContext())
	{
		Data_Access.Model.Lager lag = LagerMapper.Map(lager);
		context.Lagre.Add(lag);
		context.SaveChanges();
	}
}
}
	}







