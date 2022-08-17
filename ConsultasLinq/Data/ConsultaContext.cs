﻿using crud_wisej_prototipe;
using Microsoft.EntityFrameworkCore;

namespace ConsultasLinq.Data
{
    internal class ConsultaContext: DbContext
    {
        public ConsultaContext(DbSet<Luck> lucks)
        {
            Lucks = lucks;
        }

        public DbSet<Luck> Lucks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
            optionsBuilder.UseSqlServer("server=localhost;database=mydb;uid=root;password=123456;port=3306;");
        }
    }
}
