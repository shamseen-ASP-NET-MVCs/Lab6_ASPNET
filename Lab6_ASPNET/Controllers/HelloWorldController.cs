using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            return View();
        }

        // 
        // Access by: /HelloWorld/Welcome/ 

        public /*string*/ ActionResult Welcome(string name, int numtimes = 1) //pass in two parameters in URL!!
        {
            //return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes: " + numtimes);

            ViewBag.Message = "Hey there, " + name; 
            ViewBag.numtimes = numtimes; 
           /* we don't want to directly put info on the browser from controller
                so we're passing info into ViewBag so it can go into the View and we can
                put info on browser by formatting cshtml. */

            return View();
        }
    }
}