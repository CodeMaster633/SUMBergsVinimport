using Data_Access.Enums;
using Data_Access.Model;
using DTO_.Model;

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
    
}