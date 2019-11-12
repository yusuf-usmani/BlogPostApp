using System.Web.Mvc;

namespace BlogPostApp.Controllers
{
    [Authorize(Roles = "A")]
    public class ListUserController : Controller
    {
        // GET: ListUser
        public ActionResult Index()
        {
            return View();
        }
    }
}