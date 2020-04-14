using System;
using System.Collections.Generic;
using System.Data.Entity;
    using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1ListaPrzebojów
{
    class TPCContextDBHitsList : DbContext
    {
        public TPCContextDBHitsList() : base()
        {
            Database.SetInitializer<TPCContextDBHitsList>(new CreateDatabaseIfNotExists<TPCContextDBHitsList>());
        }
        public DbSet<Tracks> Utwory { get; set; }
        public DbSet<Albums> Albumy { get; set; }
        public DbSet<Awards> Nagrody { get; set; }
        //public DbSet<AwardsReceive> OtrzymaneNagrody { get; set; }
        public DbSet<Geners> Gatunki { get; set; }
        //public DbSet<GenersBelonging> NalezyDoGatunku { get; set; }
        public DbSet<Grades> Oceny { get; set; }
        public DbSet<Performers> Wykonawcy { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Albums>().Map(map =>
        //    {
        //        map.ToTable("Albumy");
        //    });
        //    modelBuilder.Entity<Awards>().Map(map =>
        //    {
        //        map.ToTable("Nagrody");
        //    });
        //    modelBuilder.Entity<Geners>().Map(map =>
        //    {
        //        map.ToTable("Gatunki");
        //    });
        //    modelBuilder.Entity<Grades>().Map(map =>
        //    {
        //        map.ToTable("Oceny");
        //    });
        //    modelBuilder.Entity<Performers>().Map(map =>
        //    {
        //        map.ToTable("Wykonawca");
        //    });
        //    modelBuilder.Entity<Tracks>().Map(map =>
        //    {
        //        map.ToTable("Utwory");
        //    });
        //}

    }
}
