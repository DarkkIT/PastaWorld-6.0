namespace PriLalo.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class AllMenuController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
