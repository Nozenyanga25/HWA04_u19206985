using HW04_u19206985.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW04_u19206985.Controllers
{
    public class SeniorManagerController : Controller
    {
        // GET: SeniorManager
        public ActionResult Index()
        {
            List<SeniorManager> managers = GetData();
            return View(managers);
        }

        private List<SeniorManager> GetData()
        {
            List<SeniorManager> managers = new List<SeniorManager>();
            SeniorManager manager = new SeniorManager("Senior Marketing Manager", "Benelux or UK, or remote", "as employee or consultant depending on country of residence. Open to flexible and part-time options", "ASAP, job will remain open until a suitable candidate is found", "for a small size NGO", "In this position you will report to the Director of Partnerships and Communications based in London, and work closely with the team, as well as with operational staff");
            managers.Add(manager);

            return managers;
        }
    }
}