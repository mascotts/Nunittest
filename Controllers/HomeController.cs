using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace Nunittest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyService _myService;

        public HomeController(IMyService myService)
        {
            _myService = myService;
        }

        public ActionResult Index()
        {
            var data = _myService.GetData();
            return View(data);
        }
    }
}
