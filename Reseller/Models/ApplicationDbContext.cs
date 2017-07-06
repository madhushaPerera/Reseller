using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Reseller.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("ResellerDb")
        {

        }

        public DbSet<ResellerItem> ResellerItems{ get; set; }
    }
}