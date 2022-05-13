using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Provaider_phone
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Adre> Adres { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Phone_info> Phone_info { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adre>()
                .Property(e => e.contry)
                .IsUnicode(false);

            modelBuilder.Entity<Adre>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<Adre>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<Adre>()
                .Property(e => e.house)
                .IsUnicode(false);

            modelBuilder.Entity<Adre>()
                .Property(e => e.apartment)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.make)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.reg_number)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.company_name)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.position)
                .IsUnicode(false);

            modelBuilder.Entity<Phone_info>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Phone_info>()
                .Property(e => e.surname)
                .IsUnicode(false);

            modelBuilder.Entity<Phone_info>()
                .Property(e => e.patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<Phone_info>()
                .Property(e => e.date_of_birth)
                .IsUnicode(false);

            modelBuilder.Entity<Phone_info>()
                .Property(e => e.phone_number)
                .IsUnicode(false);
        }
    }
}
