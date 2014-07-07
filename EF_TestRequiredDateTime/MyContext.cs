using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace EF_TestRequiredDateTime
{
    public class MyContext : DbContext
    {
        public DbSet<User>  Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public MyContext() : base("MyConnectionString")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(t => t.CreatedAt)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            base.OnModelCreating(modelBuilder);
        }
    }

}