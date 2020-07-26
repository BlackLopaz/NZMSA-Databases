using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NZMSA_mkmu260_Databases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NZMSA_mkmu260_Databases.Data
{
    public class AddressContext : DbContext
    {
        // an empty constructor
        public AddressContext() { }

        // base(options) calls the base class's constructor,
        // in this case, our base class is DbContext
        public AddressContext(DbContextOptions<AddressContext> options) : base(options) { }

        // Use DbSet<Student> to query or read and 
        // write information about A Student
        public DbSet<Address> Address { get; set; }
        public static System.Collections.Specialized.NameValueCollection AppSettings { get; }

        // configure the database to be used by this context
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
           .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
           .AddJsonFile("appsettings.json")
           .Build();

            // schoolSIMSConnection is the name of the key that
            // contains the has the connection string as the value
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("schoolSIMSConnection"));
        }
    }
}
