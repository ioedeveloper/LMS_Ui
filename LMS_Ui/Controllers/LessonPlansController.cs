using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMS_Ui.Controllers
{
    public class LessonPlansController : Controller
    {
        // GET: LessonPlans
        public ActionResult Index()
        {
            return View();
        }
    }
}