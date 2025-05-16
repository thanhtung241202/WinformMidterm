using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Phan2.Models;
using Phan2;
namespace Phan2
{
    class BankDbContext : DbContext
    {
            public DbSet<Bank_account> Bank_account { get; set; }
            public DbSet<Transactions> Transactions { get; set; }
            public string DbPath { get; }
            public BankDbContext()
            {
                var folder = Environment.SpecialFolder.LocalApplicationData;
                var path = Environment.GetFolderPath(folder);
                DbPath = System.IO.Path.Join(path, "banksystem.db");
            }
        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }

    }
    
}
