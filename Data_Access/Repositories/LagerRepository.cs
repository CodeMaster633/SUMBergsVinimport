using DTO_.Model;
using Data_Access.Context;
using Data_Access.Mappers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Mappers;
using Data_Access.Model;


namespace Data_Access.Repositories
{
    public class LagerRepository
    {

        public static void OpretProdukt(DTO_.Model.IProdukt produkt)
        {
            using (LagerContext context = new LagerContext())
            {
                if (produkt is DTO_.Model.MadDTO madDTO)
                {
                    madDTO.Id = 0;
                    Model.Mad mad = ProduktMapper.MapTilMadEntity(madDTO);
                    context.Mad.Add(mad);
                }
                else if (produkt is DTO_.Model.SpiritusDTO spiritusDTO)
                {
                    spiritusDTO.Id = 0;
                    Model.Spiritus spiritus = ProduktMapper.MapTilSpiritusEntity(spiritusDTO);
                    context.Spiritus.Add(spiritus);
                }
                else if (produkt is DTO_.Model.NonfoodDTO nonfoodDTO)
                {
                    nonfoodDTO.Id = 0;
                    Model.Nonfood nonfood = ProduktMapper.MaptilNonFoodEntity(nonfoodDTO);
                    context.Nonfoods.Add(nonfood);
                }
                else if (produkt is DTO_.Model.VinDTO vinDTO)
                {
                    vinDTO.Id = 0;
                    Model.Vin vin = ProduktMapper.MapTilVinEntity(vinDTO);
                    context.Vin.Add(vin);
                }
                else if (produkt is DTO_.Model.ØlDTO ølDTO)
                {
                    ølDTO.Id = 0;
                    Model.Øl øl = ProduktMapper.MapØlTilEntity(ølDTO);
                    context.Øls.Add(øl);
                }
                context.SaveChanges();
            }
        }




        public static MadDTO GetMadById(int id)
        {
            using (LagerContext context = new LagerContext())
            {
                var mad = context.Mad.Find(id);
                return mad != null ? ProduktMapper.MapTilMadDTO(mad) : null;
            }
        }

        public static ØlDTO GetØlById(int id)
        {
            using (LagerContext context = new LagerContext())
            {
                Øl øl = context.Øls.Find(id);
                return øl != null ? ProduktMapper.MapØlTilDTO(øl) : null;
            }
        }

        public static VinDTO GetVinById(int id)
        {
            using (LagerContext context = new LagerContext())
            {
                Vin vin = context.Vin.Find(id);
                return vin != null ? ProduktMapper.MapVinTilDTO(vin) : null;
            }
        }

        public static SpiritusDTO GetSpiritusDTO(int id)
        {
            using (LagerContext context = new LagerContext())
            {
                Spiritus spiritus = context.Spiritus.Find(id);
                return spiritus != null ? ProduktMapper.MapTilSpiritusDTO(spiritus) : null;

            }
        }
        public static NonfoodDTO GetNonfoodDTO(int id)
        {
            using (LagerContext context = new LagerContext())
            {
                Nonfood nonfood = context.Nonfoods.Find(id);
                return nonfood != null ? ProduktMapper.MapTilNonfoodDTO(nonfood) : null;

            }
        }




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

                List<Model.Lager> lagre = context.Lagre.ToList();
                List<LagerDTO> lagreDTO = lagre.Select(lager => LagerMapper.Map(lager)).ToList();
                return lagreDTO;
            }
        }


        public static List<DTO_.Model.IProdukt> GetAlleProdukter()
        {
            using (LagerContext context = new LagerContext())
            {
                //Man kan bruge entity framework til at samle  ale produktyper i  en list 
                List<MadDTO> madProdukter = context.Mad.Select(m => ProduktMapper.MapTilMadDTO(m)).ToList();
                List<VinDTO> vinProdukter = context.Vin.Select(v => ProduktMapper.MapVinTilDTO(v)).ToList();
                List<ØlDTO> ølProdukter = context.Øls.Select(o => ProduktMapper.MapØlTilDTO(o)).ToList();
                List<NonfoodDTO> nonFoddProdukter = context.Nonfoods.Select(nF => ProduktMapper.MapTilNonfoodDTO(nF)).ToList();
                List<SpiritusDTO> spiritusProdukter = context.Spiritus.Select(s => ProduktMapper.MapTilSpiritusDTO(s)).ToList();

                //Kombinere alle samlinger en samlet liste for Iprodukter
                List<DTO_.Model.IProdukt> alleProdukter = new List<DTO_.Model.IProdukt>();
                alleProdukter.AddRange(madProdukter);
                alleProdukter.AddRange(spiritusProdukter);
                alleProdukter.AddRange(vinProdukter);
                alleProdukter.AddRange(nonFoddProdukter);
                alleProdukter.AddRange(ølProdukter);


                return alleProdukter;   
           }

        }




        //public static void TildelLagerReol(LagerDTO lagerDTO, ReolDTO reolDTO)
        //{
            
        //    using (LagerContext context = new LagerContext())
        //    {
        //       Lager lager = context.Lagre.FirstOrDefault(l=>l.LagerId == lagerDTO.LagerId);
        //       Reol reol = context;   

        //        if(lager == null)
        //        {
        //            throw new Exception("Lager ikke fundet i databasen");
        //        }

        //        if(reol == null)
        //        {
        //            throw new Exception("Reol ikke fundet i databasen");
        //        }
        //        //Tildeler foreign key til reol
        //        reol.LagerId = lager.LagerId;

        //        context.SaveChanges();

                   

        //    }

        //}

        public static void TildelRelation(string parentId, string childId, DTO_.Model.ReltationType relationType)
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


        public static void OpretReol(int antalHylder, int antalPladserPrHylde, LagerDTO lager)
        {
            using (LagerContext context = new LagerContext())
            {

            }
        }



        public static DTO_.Model.IProdukt GetProdukt(int id)
        {
            using (LagerContext context = new LagerContext())
            {
                Model.IProdukt produkt = context.Produkt.FirstOrDefault(p => p.Id == id);
                if (produkt == null)
                {
                    throw new Exception("Produktet  er ikke i databasen");
                }

                return produkt switch
                {
                    Mad mad => ProduktMapper.MapTilMadDTO(mad),
                    Vin vin => ProduktMapper.MapVinTilDTO(vin),
                    Nonfood nonfood => ProduktMapper.MapTilNonfoodDTO(nonfood), 
                    Øl øl => ProduktMapper.MapØlTilDTO(øl),
                    Spiritus spiritus => ProduktMapper.MapTilSpiritusDTO(spiritus),


                };
              
                //DTO_.Model.IProdukt produktDTO = (DTO_.Model.IProdukt)(typeof(ProduktMapper).GetMethods().
                //   FirstOrDefault(m => m.Name.StartsWith("Map") && m.Name.EndsWith("DTO")
                //   && m.GetParameters().Length == 1
                //   && m.GetParameters().First().ParameterType == produkt.GetType())
                //   ).Invoke(null, new object[] { produkt });


               


               
            }
        }

        public static void FjernProdukt(int id)
        {
          using(LagerContext context = new LagerContext())
            {
                Model.IProdukt produktRemoved = context.Produkt.FirstOrDefault(p=>p.Id == id);   
                if(produktRemoved != null)
                {
                    context.Produkt.Remove((Produkt)produktRemoved);
                    context.SaveChanges();  
                }
            }
        }


 
    }
}











