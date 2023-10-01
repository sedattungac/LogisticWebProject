using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiLayer.EntityLayer;

namespace WebApiLayer.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-BUBEBSC; database=DbLogisticApi;integrated security=true");
            //optionsBuilder.UseSqlServer("Data Source=185.87.254.56;Initial Catalog=logistic;User ID=logistic;Password=A.sd12345678987654321;persist security info=True");
        }
        public DbSet<Activity> Activities { get; set; }
    }
}
