namespace COMP229GameProject.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TeamContext : DbContext
    {
        public TeamContext()
            : base("name=TeamConnection1")
        {
        }

        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<SecondTeam> SecondTeam { get; set; }
        public virtual DbSet<ThirdTeam> ThirdTeam { get; set; }
        public virtual DbSet<FourthTeam> FourthTeam { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>()
                .Property(e => e.Team1)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.Team2)
                .IsUnicode(false);
        }
    }
}
