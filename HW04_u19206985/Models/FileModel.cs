using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.IO;
using HW04_u19206985.Models;

namespace HW04_u19206985.Models
{
    public class FileModel
    {
        [DisplayName("File Name")]
        public string FileName { get; set; }
    }
}