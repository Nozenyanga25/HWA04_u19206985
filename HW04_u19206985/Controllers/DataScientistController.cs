using HW04_u19206985.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW04_u19206985.Controllers
{
    public class DataScientistController : Controller
    {
        // GET: DataScientist
        public ActionResult Index()
        {
            List<DataScientist> scientists = GetData();
            return View(scientists);
        }

        private List<DataScientist> GetData()
        {
            List<DataScientist> scientists = new List<DataScientist>();
            DataScientist scientist = new DataScientist("Data Scientist", "Position based Europe remotely or Office in Brussels", "Full-time contract");
            scientists.Add(scientist);

            return scientists;
        }
    }
}