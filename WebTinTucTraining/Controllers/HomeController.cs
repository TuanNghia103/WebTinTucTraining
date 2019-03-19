using System.Web.Mvc;
using WebTinTucTraining.Models;

namespace WebTinTucTraining.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}