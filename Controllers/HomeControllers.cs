using Microsoft.AspNetCore.Mvc;
using LabMasterSystem.Models;
namespace LabMasterSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       public IActionResult FAQ()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        } 
         public IActionResult Labs()
        {
            return View();
        } 
         public IActionResult BookNow()
        {
            return View();
        } 
    }
}