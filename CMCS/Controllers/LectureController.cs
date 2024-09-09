using Microsoft.AspNetCore.Mvc;

namespace CMCS.Controllers
{
    public class LectureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult UploadDocuments()
        {
            return View();
        }

        public ActionResult TrackClaim()
        {
            return View();
        }

    }
}
