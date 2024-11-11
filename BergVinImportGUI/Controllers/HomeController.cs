using BergVinImportGUI.Models;
using Business_Logic.BLL;
using DTO_.Model;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BergVinImportGUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            LagerBLL lagerBll = new LagerBLL();
            MadDTO mad = new MadDTO( 200, "Chokolade", "DEtte er lækkert chokolade", new DateTime(2025, 11, 10));
            //SpiritusDTO sp = new SpiritusDTO( 100, "DRINKS", "DETTE ER LÆKKERT", 100.00, 20, 2020, DTO_.Enums.SpiritusType.Whiskey);
            //NonfoodDTO nonfoodDTO = new NonfoodDTO(200,"Glas","MEGET PÆNT GLAS");
            lagerBll.OpretProdukt(mad);
            //lagerBll.OpretProdukt(nonfoodDTO);
            //lagerBll.OpretProdukt(sp);
            ViewBag.Mad = lagerBll.GetMadProdukt(2).Navn;
            lagerBLL.getLager(1);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
