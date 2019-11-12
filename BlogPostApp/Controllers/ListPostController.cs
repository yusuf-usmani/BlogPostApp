using System.Web.Mvc;

namespace BlogPostApp.Controllers
{
    public class ListPostController : Controller
    {
        // GET: ListPost
        public ActionResult Index()
        {
            return View();
        }
    }
}