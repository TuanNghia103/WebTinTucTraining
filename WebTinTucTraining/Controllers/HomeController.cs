using System.Web.Mvc;
using WebTinTucTraining.Models;

namespace WebTinTucTraining.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Hello = "Xin chào các bạn";
            ViewData["XinChao"] = "Xin chào nữa nè";

            var model = new HelloModel();
            model.LastName = "Trình";
            model.LastName = "Lê Hoàng";

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}