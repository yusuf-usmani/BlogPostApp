using System.Web.Mvc;

namespace BlogPostApp.Controllers
{
    [Authorize(Roles = "A")]
    public class ChangePostStatusController : Controller
    {
        // GET: ApproveRejectPost
        public ActionResult Index()
        {
            return View();
        }
    }
}