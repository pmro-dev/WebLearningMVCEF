using Microsoft.AspNetCore.Mvc;

namespace WebLearningMVCEF.Controllers
{
    public class AdminPanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
