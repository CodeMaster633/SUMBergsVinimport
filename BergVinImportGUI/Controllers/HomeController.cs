using BergVinImportGUI.Models;
using Business_Logic.BLL;
using DTO_.Model;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BergVinImportGUI.Controllers
{
    public class HomeController : Controller
    {
        private LagerBLL lagerBll = new LagerBLL();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            MadDTO mad = new MadDTO(200, "Chokolade", "Dette er lækkert chokolade", new DateTime(2025, 11, 10));
            lagerBll.OpretProdukt(mad);
            ViewBag.Mad = lagerBll.GetMadProdukt(1).Navn;
            lagerBll.getLager(1);
            return View();
        }

        public IActionResult LagerIndex()
        {
            ViewBag.Lagre = lagerBll.getLagre();
            return View();
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
