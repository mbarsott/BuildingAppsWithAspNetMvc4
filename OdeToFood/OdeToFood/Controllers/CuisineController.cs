using OdeToFood.Filters;
using System;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    //    [Authorize]
    public class CuisineController : Controller
    {
        // GET: Cuisine
        //        [HttpPost]
        //        [Authorize(Roles="Admin")]
//        [Authorize]
[Log]
        public ActionResult Search(string name = "french")
        {
            throw new Exception("Something terrible has happened");
            var message = Server.HtmlEncode(name);
            return Content(message);
//            return RedirectToAction("Index", "Home", new {name = message});
//            return RedirectToRoute("Default", new {controller="Home", action="About"});
//            return File(Server.MapPath("~/Content/site.css"), "text/css");
//            return Json(new {Message = message, Name = "Marcelo"}, JsonRequestBehavior.AllowGet);
        }

//        [HttpGet]
//        public ActionResult Search()
//        {
//            return Content("Search");
//        }
    }
}