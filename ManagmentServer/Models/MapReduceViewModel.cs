using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ManagmentServer.Models
{
    public class DataViewModel
    {
        public string FileName { get; set; }
        public string FileUpload { get; set; }
    }
    public class MapReduceViewModel
    {
        public IFormFile FileUpload { get; set; }
    }
}
