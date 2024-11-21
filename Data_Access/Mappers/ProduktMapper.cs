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
                Antal = mad.Antal,
                Beskrivelse = mad.Beskrivelse,
                Udloebsdato = mad.Udloebsdato
            };
        madDTO.Id = mad.Id;
        madDTO.LagerId = mad.LagerId;
        return madDTO;
        }

        public static Mad MapTilMadEntity(MadDTO madDto)
        {
            return new Mad
            {
               
                Id = madDto.Id,
                Pris = madDto.Pris,
                Navn = madDto.Navn,
                Antal = madDto.Antal,
                Beskrivelse = madDto.Beskrivelse,
                Udloebsdato = madDto.Udloebsdato,
                LagerId = madDto.LagerId,
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
            Antal = nonfood.Antal,
            Beskrivelse = nonfood.Beskrivelse
            LagerId = nonfood.LagerId
        };
    }

    public static NonfoodDTO MapTilNonfoodDTO(Nonfood nonfood)
    {
        NonfoodDTO nonfoodDTO = new NonfoodDTO
        {
            Id = nonfood.Id,
            Pris = nonfood.Pris,
            Navn = nonfood.Navn,
            Antal = nonfood.Antal,
            Beskrivelse = nonfood.Beskrivelse
        };
        nonfoodDTO.Id=nonfood.Id;
        nonfoodDTO.LagerId = nonfood.LagerId;
        return nonfoodDTO;
    }

    //Spiritus

    public static SpiritusDTO MapTilSpiritusDTO(Spiritus spiritus)
    {
        SpiritusDTO spiritusDTO = new SpiritusDTO( spiritus.Pris, spiritus.Navn, spiritus.Antal, spiritus.Beskrivelse, spiritus.Alkoholprocent, spiritus.Liter, spiritus.Produktionsår, spiritus.SpiritusType);
        spiritusDTO.Id = spiritus.Id;
        spiritusDTO.LagerId=spiritus.LagerId;
        return spiritusDTO;
    }

    public static Spiritus MapTilSpiritusEntity(SpiritusDTO spiritusDto)
    {
        return new Spiritus
        {
            Id =spiritusDto.Id,
            Pris = spiritusDto.Pris,
            Navn = spiritusDto.Navn,
            Antal = spiritusDto.Antal,
            Beskrivelse = spiritusDto.Beskrivelse,
            Alkoholprocent = spiritusDto.Alkoholprocent,
            Liter = spiritusDto.Liter,
            Produktionsår = spiritusDto.Produktionsaar
            LagerId = spiritusDto.LagerId
        };
    }
    //Vin
    public static Vin MapTilVinEntity(VinDTO vinDTO)
    {
        return new Vin
        {
      
            Pris = vinDTO.Pris,
            Navn = vinDTO.Navn,
            Antal = vinDTO.Antal,
            Beskrivelse = vinDTO.Beskrivelse,
            VinType = vinDTO.VinType,
            Liter = vinDTO.Liter,
            Nationalitet = vinDTO.Nationalitet
            LagerId= vinDTO.LagerId


        };
    }
    public static VinDTO MapVinTilDTO(Vin vin)
    {
        VinDTO vinDTO = new VinDTO
        {
            
            Pris = vin.Pris,
            Navn = vin.Navn,
            Antal = vin.Antal,
            Beskrivelse = vin.Beskrivelse,
            VinType = vin.VinType,
            Liter = vin.Liter,
            Nationalitet = vin.Nationalitet
        };
        vinDTO.Id = vin.Id;
        vinDTO.LagerId = vin.LagerId;
        return vinDTO;
        
    }
    //ØL
    public static Oel MapØlTilEntity(OelDTO oelDto)
    {
        return new Oel
        {
            Id = oelDto.Id,
            Pris = oelDto.Pris,
            Navn = oelDto.Navn,
            Antal = oelDto.Antal,
            Beskrivelse = oelDto.Beskrivelse,
            Udloebsdato = oelDto.Udloebsdato,
            Liter = oelDto.Liter,
            LagerId = oelDTO.LagerId
        };
        
    }

    public static OelDTO MapØlTilDTO(Oel oel)
    {
        OelDTO oelDto =  new OelDTO
        {
            Pris = oel.Pris,
            Navn = oel.Navn,
            Antal = oel.Antal,
            Beskrivelse = oel.Beskrivelse,
            Udloebsdato = oel.Udloebsdato,
            Liter = oel.Liter
        };

        oelDto.Id = oel.Id;
        oelDto.LagerId = oel.LagerId;
        return oelDto;
    }


    

    
}

   

    
