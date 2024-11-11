using Data_Access.Enums;
using Data_Access.Model;
using DTO_.Model;

namespace DataAccess.Mappers;

public class ProduktMapper
{
    //Mad
        public static MadDTO MapTilMadDTO(Mad mad)
        {
            MadDTO madDTO = new MadDTO
            {
             
                Pris = mad.Pris,
                Navn = mad.Navn,
                Beskrivelse = mad.Beskrivelse,
                Udløbsdato = mad.Udløbsdato
            };
        madDTO.Id = mad.Id;
        return madDTO;
        }

        public static Mad MapTilMadEntity(MadDTO madDto)
        {
            return new Mad
            {
               
                Id = madDto.Id,
                Pris = madDto.Pris,
                Navn = madDto.Navn,
                Beskrivelse = madDto.Beskrivelse,
                Udløbsdato = madDto.Udløbsdato
            };
        }

    //Nonfood
    public static Nonfood MaptilNonFoodEntity(NonfoodDTO nonfood)
    {
        return new Nonfood
        {
            Id = nonfood.Id,
            Pris = nonfood.Pris,
            Navn = nonfood.Navn,
            Beskrivelse = nonfood.Beskrivelse
        };
    }

    public static NonfoodDTO MapTilNonfoodDTO(Nonfood nonfood)
    {
        NonfoodDTO nonfoodDTO = new NonfoodDTO
        {
            Id = nonfood.Id,
            Pris = nonfood.Pris,
            Navn = nonfood.Navn,
            Beskrivelse = nonfood.Beskrivelse
        };
        nonfoodDTO.Id=nonfood.Id;
        return nonfoodDTO;
    }

    //Spiritus

    public static SpiritusDTO MapTilSpiritusDTO(Spiritus spiritus)
    {
        SpiritusDTO spiritusDTO = new SpiritusDTO( spiritus.Pris, spiritus.Navn, spiritus.Beskrivelse, spiritus.Alkoholprocent, spiritus.Liter, spiritus.Produktionsår, spiritus.SpiritusType);
        spiritusDTO.Id = spiritus.Id;
        return spiritusDTO;
    }

    public static Spiritus MapTilSpiritusEntity(SpiritusDTO spiritusDto)
    {
        return new Spiritus
        {
            Id =spiritusDto.Id,
            Pris = spiritusDto.Pris,
            Navn = spiritusDto.Navn,
            Beskrivelse = spiritusDto.Beskrivelse,
            Alkoholprocent = spiritusDto.Alkoholprocent,
            Liter = spiritusDto.Liter,
            Produktionsår = spiritusDto.Produktionsår
        };
    }
    //Vin
    public static Vin MapTilVinEntity(VinDTO vinDTO)
    {
        return new Vin
        {
      
            Pris = vinDTO.Pris,
            Navn = vinDTO.Navn,
            Beskrivelse = vinDTO.Beskrivelse,
            VinType = vinDTO.VinType,
            Liter = vinDTO.Liter


        };
    }
    public static VinDTO MapVinTilDTO(Vin vin)
    {
        return new VinDTO
        {
            
            Pris = vin.Pris,
            Navn = vin.Navn,
            Beskrivelse = vin.Beskrivelse,
            VinType = vin.VinType,
            Liter = vin.Liter,
        };
    }
    //ØL
    public static Øl MapØlTilEntity(ØlDTO ølDTO)
    {
        return new Øl
        {
            Id = ølDTO.Id,
            Pris = ølDTO.Pris,
            Navn = ølDTO.Navn,
            Beskrivelse = ølDTO.Beskrivelse,
            Udløbsdato = ølDTO.Udløbsdato,
            Liter = ølDTO.Liter
        };
        
    }

    public static ØlDTO MapØlTilDTO(Øl øl)
    {
        ØlDTO ølDTO =  new ØlDTO
        {
            Pris = øl.Pris,
            Navn = øl.Navn,
            Beskrivelse = øl.Beskrivelse,
            Udløbsdato = øl.Udløbsdato,
            Liter = øl.Liter
        };

        ølDTO.Id = øl.Id;
        return ølDTO;
    }


    

    
}

   

    
