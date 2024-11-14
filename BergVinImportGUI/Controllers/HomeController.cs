using BergVinImportGUI.Models;
using Business_Logic.BLL;
using DTO_.Enums;
using DTO_.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;

namespace BergVinImportGUI.Controllers
{
    public class HomeController : Controller
    {
        LagerBLL lagerBll = new LagerBLL();

        private List<string> produktList = new List<string>();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {

            //MadDTO mad = new MadDTO( 200, "Chokolade", "DEtte er l�kkert chokolade", new DateTime(2025, 11, 10));
            //SpiritusDTO sp = new SpiritusDTO( 100, "DRINKS", "DETTE ER L�KKERT", 100.00, 20, 2020, DTO_.Enums.SpiritusType.Whiskey);
            //NonfoodDTO nonfoodDTO = new NonfoodDTO(200,"Glas","MEGET P�NT GLAS");
            //lagerBll.OpretProdukt(mad);
            //lagerBll.OpretProdukt(nonfoodDTO);
            //lagerBll.OpretProdukt(sp);
            //ViewBag.Mad = lagerBll.GetMadProdukt(2).Navn;
            List<IProdukt> produkter = lagerBll.GetAlleProdukt();
            lagerBll.getLager(1);
            //lagerBll.OpretProdukt(mad);
            ViewBag.Produkter = produkter;

            // lagerBll.OpretProdukt(mad);
            ViewBag.Mad = lagerBll.GetMadProdukt(1).Navn;

            return View();
        }

        public IActionResult LagerIndex()
        {
            ViewBag.Lagre = lagerBll.getLagre();
            return View();
        }

        public IActionResult OpretProdukt(IFormCollection formData = null)
        {
            PopulateProductList();
            TypeSpiritusList();
            TypeVinList();
            if (formData != null && formData.ContainsKey("OpretProdukt"))
            {
                string selectPropertyItem = formData["Produkters"];
                ViewBag.SelectedPropertyType = selectPropertyItem;
            }

            return View("OpretProdukt");
        }



        // Separate method to populate the product list
        private void PopulateProductList()
        {
            ViewBag.Produkters = new List<SelectListItem>
            {
                new SelectListItem { Text = "Mad", Value = "Mad" },
                new SelectListItem { Text = "NonFood", Value = "NonFood" },
                new SelectListItem { Text = "Spiritus", Value = "Spiritus" },
                new SelectListItem { Text = "Vin", Value = "Vin" },
                new SelectListItem { Text = "�l", Value = "�l" }
            };
        }

        private void TypeSpiritusList()
        {
            ViewBag.SpiritusType = new List<SelectListItem> {
                new SelectListItem { Text = "Whisky", Value = "0" },
                new SelectListItem { Text = "Rom", Value = "1" },
                new SelectListItem { Text = "Gin", Value = "2" },
                new SelectListItem { Text = "Vodka", Value = "3" },
                new SelectListItem { Text = "Tequila", Value = "4" }
            };
        }
        private void TypeVinList()
        {
            ViewBag.VinType = new List<SelectListItem> {
                new SelectListItem { Text = "R�dvin", Value = "0" },
                new SelectListItem { Text = "Hvidvin", Value = "1" },
                new SelectListItem { Text = "Rosevin", Value = "2" },
                new SelectListItem { Text = "Portvin", Value = "3" }
            };
        }

        public IActionResult GemProdukt(IFormCollection formData)
        {
            PopulateProductList();
            PopulateProductList();
            TypeSpiritusList();

            // Brug formData for at f� v�rdien
            string produktType = formData["Produkters"];
            string navn = formData["NavnFelt"];
            string prisString = formData["PrisFelt"];
            //bruger out til at kunne s�tte v�rdien parsedPris hvis parsing lykkes eller bliver den 0 hvis false
            int pris = int.TryParse(prisString, out int parsedPris) ? parsedPris : 0;
            string beskrivelse = formData["BeskrivelseFelt"];

            //Opretelse af DTO objekter der skal sendes til databsen 
            IProdukt? produktDTO = null;
            if (produktType == "Mad")
            {
                string udl�bsDatoString = formData["UdlobsdatoFelt"];
                DateTime udl�bsDato;
                if (!DateTime.TryParse(udl�bsDatoString, out udl�bsDato))
                {
                    ModelState.AddModelError("UdlobsdatoFelt", "Ugyldig dato");
                    return View("OpretProdukt");
                }
                produktDTO = new MadDTO()
                {
                    Navn = navn,
                    Pris = pris,
                    Beskrivelse = beskrivelse,
                    Udloebsdato = udl�bsDato
                };
            }
            else if (produktType == "NonFood")
            {
                produktDTO = new NonfoodDTO()
                {
                    Pris = pris,
                    Navn = navn,
                    Beskrivelse = beskrivelse
                };
            }
            else if (produktType == "Spiritus")
            {
                string literString = formData["LiterFelt"];
                int liter = int.TryParse(literString, out int parsedLiter) ? parsedLiter : 0;

                string alkoholString = formData["AlkProcentFelt"];
                int alkoholprocent = int.TryParse(alkoholString, out int parsedProcent) ? parsedProcent : 0;

                string produktions�rString = formData["Pro�rFelt"];
                int produktions�r = int.TryParse(produktions�rString, out int parsedProduktions�r) ? parsedProduktions�r : 0;

                string spiritusString = formData["SpiritusType"];
                int spiritusType = int.TryParse(spiritusString, out int parsedType) ? parsedType : 0;

                produktDTO = new SpiritusDTO()
                {
                    Pris = pris,
                    Navn = navn,
                    Beskrivelse = beskrivelse,
                    Liter = liter,
                    Alkoholprocent = alkoholprocent,
                    Produktions�r = produktions�r,
                    SpiritusType = (SpiritusType)spiritusType
                };
            }
            else if (produktType == "Vin")
            {
                string literString = formData["LiterFelt"];
                int liter = int.TryParse(literString, out int parsedLiter) ? parsedLiter : 0;

                string vinString = formData["VinType"];
                int vinType = int.TryParse(vinString, out int parsedType) ? parsedType : 0;

                produktDTO = new VinDTO()
                {
                    Pris = pris,
                    Navn = navn,
                    Beskrivelse = beskrivelse,
                    VinType = (VinType)vinType,
                    Liter = liter
                };
            }
            else if (produktType == "�l")
            {
                string literString = formData["LiterFelt"];
                int liter = int.TryParse(literString, out int parsedLiter) ? parsedLiter : 0;

                string udl�bsDatoString = formData["UdlobsdatoFelt"];
                DateTime udl�bsDato;
                if (!DateTime.TryParse(udl�bsDatoString, out udl�bsDato))
                {
                    ModelState.AddModelError("UdlobsdatoFelt", "Ugyldig dato");
                    return View("OpretProdukt");
                }

                produktDTO = new �lDTO()
                {
                    Pris = pris,
                    Navn = navn,
                    Beskrivelse = beskrivelse,
                    Udloebsdato = udl�bsDato,
                    Liter = liter
                };
            }

            Console.WriteLine("Kig her " + produktDTO.Navn);
            lagerBll.OpretProdukt(produktDTO);

            PopulateProductList();

            return View("OpretProdukt");
        }




        //[HttpPost]
        public ActionResult AddLager(IFormCollection formData)
        {
            lagerBll.AddLager(new LagerDTO(formData["Navn"], formData["Adresse"], formData["Kontaktperson"]));
            ViewBag.Lagre = lagerBll.getLagre();

            return View("OpretLager");
        }

        public IActionResult OpretLager()
        {
            ViewBag.Lagre = lagerBll.getLagre();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}
