using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW04_u19206985.Models;

namespace HW04_u19206985.Controllers
{
    public class InvolvementController : Controller
    {
        // GET: Involvement
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase UploadedFile)
        {
            if (UploadedFile != null && UploadedFile.ContentLength > 0)
            {
                string filename = Path.GetFileName(UploadedFile.FileName);

                string FolderPath = Path.Combine(Server.MapPath("~/Proposals"), Path.GetFileName(filename));

                UploadedFile.SaveAs(FolderPath);
            }
            return View();
        }
    }
}