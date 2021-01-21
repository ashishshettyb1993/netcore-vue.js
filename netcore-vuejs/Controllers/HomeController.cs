using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netcore_vuejs.Models;
using netcorevuejs.Models;

namespace netcore_vuejs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            SmtpClient ss = new SmtpClient("sora-3.z-planet.co.jp");
            ss.Port = 25;
            ss.UseDefaultCredentials = true;
            ss.Send("s.vikrant@z-planet.co.jp", "s.ashish@z-planet.co.jp", "empty", "Nriildsj");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SubmitedForm([FromBody] FormViewModel form)
        {
            string message = "Api called";

            // Insert to database, send email, etc

            return Json(new { message });
        }
    }
}
