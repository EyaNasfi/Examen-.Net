using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class AMContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var _connectionString = @"server=localhost;database=RemboursementNasfiEya;uid=root;password=;";
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BulletinConfig());
            modelBuilder.ApplyConfiguration(new TraitementConfig());
            //modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            //modelBuilder.Entity<Staff>().ToTable("Staffs");
            //modelBuilder.Entity<Traveller>().ToTable("Travellers");
            //modelBuilder.Entity<Plane>().HasKey(p => p.PlaneId);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //configurationBuilder.Properties<DateTime>()
            //    .HaveColumnType("date");
        }


        public DbSet<Remboursement> Remboursements { get; set; }
        public DbSet<Traitement> Traitements { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Intervenant> Intervenants { get; set; }
        public DbSet<BulletinSoin> BulletinSoins { get; set; }
        //public DbSet<Passenger> Passengers { get; set; }
        //public DbSet<Plane> Planes { get; set; }
        //public DbSet<Traveller> Travellers { get; set; }
        //public DbSet<Staff> Staff { get; set; }

    }
}
