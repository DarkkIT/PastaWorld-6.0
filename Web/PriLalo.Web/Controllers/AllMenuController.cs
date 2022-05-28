using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriLalo.Web.Controllers
{
    public class AllMenuController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
