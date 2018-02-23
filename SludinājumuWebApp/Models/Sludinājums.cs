using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SludinājumuWebApp.Models
{
    public class Sludinājums
    {
        [Key]
        public int AdvertId { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string AdvertText { get; set; }
        public DateTime CreationTime { get; set; }
    }
}