using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using HW04_u19206985.Models;

namespace HW04_u19206985.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            string[] files = Directory.GetFiles(Server.MapPath("~/Proposals"));

            List<FileModel> myFiles = new List<FileModel>();

            foreach (string file in files)
            {
                myFiles.Add(new FileModel { FileName = Path.GetFileName(file) });
            }
            return View(myFiles);
        }

        public FileResult DownloadFile(string filename)
        {
            string path = Server.MapPath("~/Proposals/") + filename;


            byte[] bytes = System.IO.File.ReadAllBytes(path);


            return File(bytes, "application/octet-stream", filename);
        }

        public ActionResult DeleteFile(string filename)
        {
            string path = Server.MapPath("~/Proposals/") + filename;
            FileInfo file = new FileInfo(path);

            if (file.Exists)
            {
                file.Delete();
            }


            return RedirectToAction("Index");

        }
    }
}