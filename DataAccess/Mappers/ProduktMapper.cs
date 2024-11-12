using DataAccess.Enums;
using DataAccess.Model;
using DTO.Model;

namespace DataAccess.Mappers;

public class ProduktMapper
{
    //Mad
    
    public static MadDTO MapTilMadDTO(Mad mad)
    {
        return new MadDTO(mad.Id, mad.Pris, mad.Navn, mad.Beskrivelse, mad.Udløbsdato);
    }
    
    //Nonfood
    
    public static NonfoodDTO MapTilNonfoodDTO(Nonfood nonfood)
    {
        return new NonfoodDTO(nonfood.Id, nonfood.Pris, nonfood.Navn, nonfood.Beskrivelse);
    }
    
    //Spiritus
    
    public static SpiritusDTO MapTilSpiritusDTO(Spiritus spiritus)
    {
        return new SpiritusDTO(spiritus.Id, spiritus.Pris, spiritus.Navn, spiritus.Beskrivelse, spiritus.Alkoholprocent, spiritus.Liter, spiritus.Produktionsår, spiritus.SpiritusType);
    }
    
    //Vin

    public static VinDTO MapTilVinDTO(Vin vin)
    {
        return new VinDTO(vin.Id, vin.Pris, vin.Navn, vin.Beskrivelse, vin.VinType, vin.Liter);
    }
    
    //Øl

    public static ØlDTO MapTilØlDTO(Øl øl)
    {
        return new ØlDTO(øl.Id, øl.Pris, øl.Navn, øl.Beskrivelse, øl.Udløbsdato, øl.Liter);
    }
}