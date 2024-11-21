﻿using DTO_.Model;
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
using IProdukt = DTO_.Model.IProdukt;


namespace Data_Access.Repositories
{
    public class LagerRepository
    {

        public static int OpretProdukt(DTO_.Model.IProdukt produkt,LagerDTO lager)
        {
            Model.IProdukt produktID = null;
            using (LagerContext context = new LagerContext())
            {
                if (produkt is DTO_.Model.MadDTO madDTO)
                {
                    madDTO.Id = 0;
                    madDTO.LagerId = lager.LagerId;
                    Model.Mad mad = ProduktMapper.MapTilMadEntity(madDTO);
                    produktID = mad;
                    //mad.LagerId = lager.LagerId;
                    context.Mad.Add(mad);
                 
                }
                else if (produkt is DTO_.Model.SpiritusDTO spiritusDTO)
                {
                    spiritusDTO.Id = 0;
                    Model.Spiritus spiritus = ProduktMapper.MapTilSpiritusEntity(spiritusDTO);
                    produktID = spiritus;
                    spiritus.LagerId=lager.LagerId;
                    context.Spiritus.Add(spiritus);
                }
                else if (produkt is DTO_.Model.NonfoodDTO nonfoodDTO)
                {
                    nonfoodDTO.Id = 0;
                    Model.Nonfood nonfood = ProduktMapper.MaptilNonFoodEntity(nonfoodDTO);
                    produktID = nonfood;
                    nonfood.LagerId = lager.LagerId;
                    context.Nonfoods.Add(nonfood);
                }
                else if (produkt is DTO_.Model.VinDTO vinDTO)
                {
                    vinDTO.Id = 0;
                    Model.Vin vin = ProduktMapper.MapTilVinEntity(vinDTO);
                    produktID = vin;
                    vin.LagerId = lager.LagerId;
                    context.Vin.Add(vin);
                }
                else if (produkt is DTO_.Model.OelDTO ølDTO)
                {
                    ølDTO.Id = 0;
                    Model.Oel øl = ProduktMapper.MapØlTilEntity(ølDTO);
                    Model.Øl øl = ProduktMapper.MapØlTilEntity(ølDTO);
                    produktID = øl;
                    øl.LagerId = lager.LagerId;
                    context.Øls.Add(øl);
                }

                context.SaveChanges();
                return  produktID.Id;
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

        public static OelDTO GetØlById(int id)
        {
            using (LagerContext context = new LagerContext())
            {
                Oel øl = context.Øls.Find(id);
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

        public static List<DTO_.Model.IProdukt> getProdukterPaaLager(int id)
        {
            using (LagerContext context = new LagerContext())
            {
                LagerDTO lager = LagerMapper.Map(context.Lagre.Find(id));
                List<DTO_.Model.IProdukt> produkter = lager.Produkter;
                return produkter;
            }
        }


        public static List<DTO_.Model.IProdukt> GetAlleProdukter()
        {
            using (LagerContext context = new LagerContext())
            {
                //Man kan bruge entity framework til at samle  ale produktyper i  en list 
                List<MadDTO> madProdukter = context.Mad.Select(m => ProduktMapper.MapTilMadDTO(m)).ToList();
                List<VinDTO> vinProdukter = context.Vin.Select(v => ProduktMapper.MapVinTilDTO(v)).ToList();
                List<OelDTO> ølProdukter = context.Øls.Select(o => ProduktMapper.MapØlTilDTO(o)).ToList();
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
        //Udløbsdato besked logik
        public static List<IProdukt> TjekUdlobsdato()
        {
            using (var context = new LagerContext())
            {
                // Hent og map Mad-produkter til DTO'er
                var madProdukterDto = context.Produkt
                    .OfType<Mad>()
                    .Where(m => m.Udloebsdato <= DateTime.Now.AddMonths(3))
                    .Select(m => ProduktMapper.MapTilMadDTO(m)) // Mapper til MadDTO
                    .ToList();

                // Hent og map Øl-produkter til DTO'er
                var olProdukterDto = context.Produkt
                    .OfType<Oel>()
                    .Where(o => o.Udloebsdato <= DateTime.Now.AddMonths(3))
                    .Select(o => ProduktMapper.MapØlTilDTO(o)) // Mapper til OelDTO
                    .ToList();

                // Hent IDs for allerede tjekkede produkter
                var tjekId = context.TjekkedeProdukter
                    .Select(tp => tp.Id)
                    .ToHashSet();
                
                

                // Kombinér og filtrér de nye produkter
                var nyeMadProdukter = madProdukterDto
                    .Where(p => !tjekId.Contains(p.Id))
                    .ToList();
                
                var nyeOelProdukter = olProdukterDto
                    .Where(p => !tjekId.Contains(p.Id))
                    .ToList();


                // Tilføj de nye produkter til listen over tjekkede produkter

                foreach (var madProdukt in nyeMadProdukter)
                {

                    context.TjekkedeProdukter.Add(new TjekkedeProdukter
                    {
                        TjekId = Guid.NewGuid(),
                        Navn = madProdukt.Navn,
                        Antal = madProdukt.Antal,
                        Udloebsdato = madProdukt.Udloebsdato,
                        TjekketDato = DateTime.Now
                    });
                }

                foreach (var oelProdukt in nyeOelProdukter)
                {

                    context.TjekkedeProdukter.Add(new TjekkedeProdukter
                    {
                        TjekId = Guid.NewGuid(),
                        Navn = oelProdukt.Navn,
                        Antal = oelProdukt.Antal,
                        Udloebsdato = oelProdukt.Udloebsdato,
                        TjekketDato = DateTime.Now
                    });
                }
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fejl ved SaveChanges: {ex.Message}");
                    throw;
                }
                var nyeProdukter = nyeMadProdukter.Cast<IProdukt>().ToList();
                nyeProdukter.AddRange(nyeOelProdukter.Cast<IProdukt>());

                return nyeProdukter;
                
            }
        }
    }
}











