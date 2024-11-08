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
        }
        //public static void AddLager(LagerDTO lager)
        //{
        //    using (LagerContext context = new LagerContext())
        //    {
        //        DataAccess.Model.Lager emp = LagerMapper.Map(lager);
        //        context.Lagre.Add(emp);
        //        context.SaveChanges();
        //    }
        //}
    }

