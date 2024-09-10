using Microsoft.AspNetCore.Mvc;

namespace CMCS.Controllers
{
    public class OrganizationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ViewUnapprovedClaims()
        {
            return View();
        }

        public ActionResult ViewVerifiedClaims()
        {
            return View();
        }

        public ActionResult ViewApprovedClaims()
        {
            return View();
        }
    }
}
