using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SludinājumuWebApp.Models
{
    public class AdvertDb : DbContext
    {
        public DbSet<Sludinājums> Adverts { get; set; }
    }
}