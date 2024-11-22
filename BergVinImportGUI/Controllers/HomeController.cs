using BergVinImportGUI.Models;
using Business_Logic.BLL;
using DTO_.Enums;
using DTO_.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.SqlServer.Server;
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
        public IActionResult Index(IFormCollection formData)
        {

            ViewBag.Lagre = lagerBll.getLagre().Select(l => new SelectListItem
            {
                Value = l.LagerId.ToString(),
                Text = l.Navn
            });

            ViewBag.LagerProdukter = lagerBll.getLagre();

            if (formData.ContainsKey("Lagre"))
            {
                string selectedLager = formData["Lagre"];
                ViewBag.SelectedPropertyType = selectedLager;
            }

            return View();
        }

        public IActionResult LagerIndex()
        {
            ViewBag.lagre = lagerBll.getLagre();
            return View();
        }

        public IActionResult OpretProdukt(IFormCollection formData = null)
        {
            PopulateProductList();
            TypeSpiritusList();
            TypeVinList();
            LagerList();

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
                new SelectListItem { Text = "Oel", Value = "Oel" }
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
                new SelectListItem { Text = "Roedvin", Value = "0" },
                new SelectListItem { Text = "Hvidvin", Value = "1" },
                new SelectListItem { Text = "Rosevin", Value = "2" },
                new SelectListItem { Text = "Portvin", Value = "3" }
            };
        }

        private void LagerList()
        {
            ViewBag.Lagre = lagerBll.getLagre().Select(l => new SelectListItem
            {
                Value = l.LagerId.ToString(),
                Text = l.Navn
            }); 
               
        }
        public IActionResult GemProdukt(IFormCollection formData)
        {
            PopulateProductList();
            PopulateProductList();
            TypeSpiritusList();
            LagerList();

            // Brug formData for at få værdien
            string produktType = formData["Produkters"];
            string navn = formData["NavnFelt"];
            string prisString = formData["PrisFelt"];
            //bruger out til at kunne sætte værdien parsedPris hvis parsing lykkes eller bliver den 0 hvis false
            int pris = int.TryParse(prisString, out int parsedPris) ? parsedPris : 0;
            string beskrivelse = formData["BeskrivelseFelt"];
            string lagerString = formData["Lagre"];
            int lagerID = int.TryParse(lagerString, out int parsedID) ? parsedID : 0;

            //Opretelse af DTO objekter der skal sendes til databsen 
            IProdukt? produktDTO = null;
            if (produktType == "Mad")
            {
                string udloebsDatoString = formData["UdlobsdatoFelt"];
                DateTime udloebsDato;
                if (!DateTime.TryParse(udloebsDatoString, out udloebsDato))
                {
                    ModelState.AddModelError("UdlobsdatoFelt", "Ugyldig dato");
                    return View("OpretProdukt");
                }
                produktDTO = new MadDTO()
                {
                    Navn = navn,
                    Pris = pris,
                    Beskrivelse = beskrivelse,
                    Udloebsdato = udloebsDato
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

                string produktionsaarString = formData["ProAarFelt"];
                int produktionsaar = int.TryParse(produktionsaarString, out int parsedProduktionsAar) ? parsedProduktionsAar : 0;

                string spiritusString = formData["SpiritusType"];
                int spiritusType = int.TryParse(spiritusString, out int parsedType) ? parsedType : 0;

                produktDTO = new SpiritusDTO()
                {
                    Pris = pris,
                    Navn = navn,
                    Beskrivelse = beskrivelse,
                    Liter = liter,
                    Alkoholprocent = alkoholprocent,
                    Produktionsaar = produktionsaar,
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
            else if (produktType == "Oel")
            {
                string literString = formData["LiterFelt"];
                int liter = int.TryParse(literString, out int parsedLiter) ? parsedLiter : 0;

                string udloebsDatoString = formData["UdlobsdatoFelt"];
                DateTime udloebsDato;
                if (!DateTime.TryParse(udloebsDatoString, out udloebsDato))
                {
                    ModelState.AddModelError("UdlobsdatoFelt", "Ugyldig dato");
                    return View("OpretProdukt");
                }

                produktDTO = new OelDTO()
                {
                    Pris = pris,
                    Navn = navn,
                    Beskrivelse = beskrivelse,
                    Udloebsdato = udloebsDato,
                    Liter = liter
                };
            }

            Console.WriteLine("Kig her " + produktDTO.Navn);
            LagerDTO lager = lagerBll.getLager(lagerID);
            lagerBll.OpretProdukt(produktDTO,lager);

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
