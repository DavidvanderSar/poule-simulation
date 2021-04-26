using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace PouleSim.Controllers
{
    public class AboutController : Controller
    {
        // 
        // GET: /About/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /About/EasterEgg/ 

        public string EasterEgg()
        {
            return "This is an extra page...";
        }
    }
}