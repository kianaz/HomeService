using Azure.Core;
using Homeservise.Domain.core.Account.Entiti;
using Homeservise.Domain.core.Action.Entiti;
using Homeservise.Domain.core.Servises.Entiti;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.Infra.DBcontaxt.EF.SQL.DBcontextSet
{
   public class HomeServiceDbcontaxt: DbContext
   {
        public HomeServiceDbcontaxt(DbContextOptions<HomeServiceDbcontaxt> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new Configuration.Admin_Configuration());
            modelBuilder.ApplyConfiguration(new Configuration.RateConfiguration());
            modelBuilder.ApplyConfiguration(new Configuration.ServisesConfiguration());
            modelBuilder.ApplyConfiguration(new Configuration.SubserviseConfiguration());
            modelBuilder.ApplyConfiguration(new Configuration.CategoriConfiguration());
            modelBuilder.ApplyConfiguration(new Configuration.CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new Configuration.ExpertConfiguration());
            modelBuilder.ApplyConfiguration(new Configuration.RequestConfiguration());

        }
        public DbSet<Admin> Admin{ get; set; }
        public DbSet<Expert> Experts  { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Servise> servises { get; set; }
        public DbSet<Category> categories{ get; set; }
        public DbSet<Subservises> subservises { get; set; }

        public DbSet<Homeservise.Domain.core.Action.Entiti.Request> Requests  { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public DbSet<Sugestion> Sugestions{ get; set; }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Picture> Pictures { get; set; }





    }
}
