using HW04_u19206985.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW04_u19206985.Controllers
{
    public class IndustryAnalystController : Controller
    {
        // GET: IndustryAnalyst
        public ActionResult Index()
        {
            List<IndustryAnalyst> analysts = GetData();
            return View(analysts);
        }

        private List<IndustryAnalyst> GetData()
        {
            List<IndustryAnalyst> analysts = new List<IndustryAnalyst>();
            IndustryAnalyst analystone = new IndustryAnalyst("Industry Analyst Internship", "Position preferably based in Belgium, open to remote telework", "Flexible schedule - min. 25 hours/week", "The industry analyst intern will support WeForest's Accelerator team to further develop its knowledge and expertise on the industry", "Accelerator Director, based in Brussels", "Minimum 3 months, ideally 4 months.  Full time or part time – min. 25h/week");
            analysts.Add(analystone);

            return analysts;
        }
    } 
}