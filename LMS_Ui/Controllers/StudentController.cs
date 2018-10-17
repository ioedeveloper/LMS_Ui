using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMS_Ui.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewLessonPlan()
        {
            return View();
        }

        public ActionResult ViewContent()
        {
            return View();
        }
    }
}