using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW04_u19206985.Models;

namespace HW04_u19206985.Controllers
{
    public class JobsController : Controller
    {
        // GET: OpenPositions
        public ActionResult Index()
        {

            List<Jobs> jobs = new List<Jobs>();
            DataScientist scientist = new DataScientist("Data Scientist", "Position based Europe remotely or Office in Brussels", "Full-time contract");
            DataAnalyst analyst = new DataAnalyst("Data Analyst Internship", "Position preferably based in Belgium, open to remote telework", "Flexible schedule", "The data analyst intern will support WeForest's programmes team to facilitate HQ access to data to further develop  knowledge, understanding and use of it by the teams", "M&E Manager, based in Brussels", "Minimum 3 months, ideally 4-6 months.  Exact starting period in 2022/23 is flexible. Full time or part time.");
            IndustryAnalyst analystone = new IndustryAnalyst("Industry Analyst Internship", "Position preferably based in Belgium, open to remote telework", "Flexible schedule - min. 25 hours/week", "The industry analyst intern will support WeForest's Accelerator team to further develop its knowledge and expertise on the industry", "Accelerator Director, based in Brussels", "Minimum 3 months, ideally 4 months.  Full time or part time – min. 25h/week");
            SeniorManager manager = new SeniorManager("Senior Marketing Manager", "Benelux or UK, or remote", "as employee or consultant depending on country of residence. Open to flexible and part-time options", "ASAP, job will remain open until a suitable candidate is found", "for a small size NGO", "In this position you will report to the Director of Partnerships and Communications based in London, and work closely with the team, as well as with operational staff");
            
            jobs.Add(analyst);
            jobs.Add(analystone);
            jobs.Add(scientist);
            jobs.Add(manager);

            return View(jobs);
        }
    }
}