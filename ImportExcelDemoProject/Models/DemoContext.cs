using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ImportExcelDemoProject.Models
{
    public class DemoContext :DbContext
    {
        public DemoContext():base("Db")
        {

        }
        public DbSet<Employee> employees { get; set; }
    }
}