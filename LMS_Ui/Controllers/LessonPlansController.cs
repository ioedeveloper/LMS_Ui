﻿using System;
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

        public ActionResult ListModulesAndTopics()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateLessonPlan(string LessonPlanName, string LessonPlanDescription, string[] ModuleNames,string[] ModuleDescriptions)
        {

            return View();
        }

        [HttpPost]
        public ActionResult CreateModules(string ModuleName, string ModuleDescription,string[] topicNames, string[] topicDescriptions)
        {
            return View();
        }
    }
}