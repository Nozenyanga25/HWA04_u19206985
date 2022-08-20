using HW04_u19206985.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW04_u19206985.Controllers
{
    public class DataAnalystController : Controller
    {
        // GET: DataAnalyst
        public ActionResult Index()
        {
            List<DataAnalyst> analysts = GetData();
            return View(analysts);
        }

        private List<DataAnalyst> GetData()
        {
            List<DataAnalyst> analysts = new List<DataAnalyst>();
            DataAnalyst analyst = new DataAnalyst("Data Analyst Internship", "Position preferably based in Belgium, open to remote telework", "Flexible schedule", "The data analyst intern will support WeForest's programmes team to facilitate HQ access to data to further develop  knowledge, understanding and use of it by the teams", "M&E Manager, based in Brussels", "Minimum 3 months, ideally 4-6 months.  Exact starting period in 2022/23 is flexible. Full time or part time.");
            analysts.Add(analyst);

            return analysts;
        }
    }
}