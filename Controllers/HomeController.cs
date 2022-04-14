using MVCTables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MVCTables.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var projects = new List<ProjectData>
            {
                new ProjectData
                {
                    Id = 1,
                    ProjectContent = "Admin portal contents",
                    ProjectFolder = "Web",
                    ProjectName = "Admin Portal"
                },
                new ProjectData
                {
                    Id = 2,
                    ProjectContent = "CIB Api",
                    ProjectFolder = "Api",
                    ProjectName = "CIB Api"
                },
                new ProjectData
                {
                    Id = 3,
                    ProjectContent = "Web Api",
                    ProjectFolder = "Api",
                    ProjectName = "Web Api"
                },
                new ProjectData
                {
                    Id = 4,
                    ProjectContent = "Corporate Website",
                    ProjectFolder = "Web",
                    ProjectName = "Corporate Website"
                },
                new ProjectData
                {
                    Id = 5,
                    ProjectContent = "e-Commerce Portal",
                    ProjectFolder = "Web",
                    ProjectName = "e-Commerce Portal"
                },
                new ProjectData
                {
                    Id = 6,
                    ProjectContent = "Shopping Api",
                    ProjectFolder = "Api",
                    ProjectName = "Shopping Api"
                },
                new ProjectData
                {
                    Id = 7,
                    ProjectContent = "Purchase Api",
                    ProjectFolder = "Api",
                    ProjectName = "Purchase Api"
                }
            };
            //JavaScriptSerializer serializer = new JavaScriptSerializer();
            //ViewBag.Data = serializer.Serialize(projects);
            ViewBag.Data = projects;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}