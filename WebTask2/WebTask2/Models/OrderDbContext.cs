using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WebTask2.Models
{
    public class OrderDbContext : DbContext
    {

        private IConfiguration _config;

        public OrderDbContext()
        {

        }

        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {

        }

        public OrderDbContext(IConfiguration configuration)
        {
            _config = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_config.GetConnectionString("ProductionDb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Confectionary_ClientOrder>().HasKey(cc => new { cc.IdClientOrder, cc.IdConfectionary });
            modelBuilder.Entity<Client>().HasData(
                new { IdClient =1 , FirstName = "string1", LastName = "String2"},
                new { IdClient = 2, FirstName = "string3", LastName = "String4" },
                new { IdClient = 3, FirstName = "string5", LastName = "String6" }
                );
            modelBuilder.Entity<Confectionery>().HasData(
                new { IdConfectionery = 1, Name = "string1", PricePerOne= 5.75F },
                new { IdConfectionery = 2, Name = "string2", PricePerOne = 5.75F },
                new { IdConfectionery = 3, Name = "string3", PricePerOne = 5.75F },
                new { IdConfectionery = 4, Name = "string4", PricePerOne = 5.75F }
                );
            modelBuilder.Entity<Employee>().HasData(
                new { IdEmployee = 1, FirstName = "string1", LastName = "String2" },
                new { IdEmployee = 2, FirstName = "string3", LastName = "String4" },
                new { IdEmployee = 3, FirstName = "string5", LastName = "String6" }
                );
            modelBuilder.Entity<ClientOrder>().HasData(
                new { IdClientOrder = 1, OrderDate =  DateTime.Now, CompletionDate = DateTime.Now.AddDays(1), Comments = "dadaczcz", IDClient = 1, IDEmployee =1 },
                new { IdClientOrder = 2, OrderDate = DateTime.Now, CompletionDate = DateTime.Now.AddDays(2), Comments = "dadaczdadadacz", IDClient = 2, IDEmployee = 2 },
                new { IdClientOrder = 3, OrderDate = DateTime.Now, CompletionDate = DateTime.Now.AddDays(3), Comments = "dadaczcdadadadddadaz", IDClient = 3, IDEmployee = 3 }
                );
            modelBuilder.Entity<Confectionary_ClientOrder>().HasData(
                new { IdClientOrder = 1, IdConfectionary = 1, Comments = "dadaczcz", Amount = 20},
                new { IdClientOrder = 2, IdConfectionary = 2, Comments = "dadacdadazcz", Amount = 30 },
                new { IdClientOrder = 3, IdConfectionary = 3, Comments = "dadacdadazdadacz", Amount = 40 },
                new { IdClientOrder = 3, IdConfectionary = 4, Comments = "dada1111dadazdadacz", Amount = 50 }
                );
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<ClientOrder> ClientOrders { get; set; }

        public DbSet<Confectionery> Confectioneries { get; set; }

        public DbSet<Confectionary_ClientOrder> Confectionary_ClientOrders { get; set; }


    }
}
