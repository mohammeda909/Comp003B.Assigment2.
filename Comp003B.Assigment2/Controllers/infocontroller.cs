using Microsoft.AspNetCore.Mvc;

namespace comp003B.assigment2.Controllers
{
    public class InfoController : Controller
    {
        // GET: Info/About
        public ActionResult About()
        {
            
            ViewBag.ApplicationPurpose = "This is a sample application.";
            ViewBag.DevelopersName = "mohammed ali";

            return View();
        }

        // GET: Info/Hobbies
        public ActionResult Hobbies()
        {
            // list of hobbies
            var hobbies = new List<string>
            {
                "working out",
                "working",
                "driving"
            };

            return View(hobbies);
        }
    }
}
