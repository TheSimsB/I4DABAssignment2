using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace I4DAB___Assignment_2
{
    public class Context : DbContext
    {
        protected override void
        OnConfiguring(DbContextOptionsBuilder ob)
        {
            //Husk at tilføje rigtige database til Stringen nedenfor.
            ob.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=xxxxx;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

        }

        //public DbSet<Author> Authors { get; set; }


    }
}
