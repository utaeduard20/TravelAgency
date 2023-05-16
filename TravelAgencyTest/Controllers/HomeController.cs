using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using TravelAgencyTest.Data;
using TravelAgencyTest.Models;

namespace TravelAgencyTest.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private IServiceWrapper _repoWrapper;

        public HomeController(IServiceWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper ?? throw new ArgumentNullException(nameof(repoWrapper));
        }

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult Index()
        {

            //    _repoWrapper.AirlineCompanyService.Create(new AirlineCompany() { Name = "CEva", Tickets = null });
            //    ViewBag.whatever = "ceva";
            // _repoWrapper.AirlineCompanyService.Save();
            return View();
        }
        [Route("Home/About")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        [Route("Home/Contact")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
