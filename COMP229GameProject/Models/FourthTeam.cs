
namespace COMP229GameProject.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FourthTeam : DbContext
    {
        public FourthTeam()
            : base("name=FourthTeam")
        {
        }

        public virtual DbSet<SecondTeam> SecondTeams { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<ThirdTeam> ThirdTeams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SecondTeam>()
                .Property(e => e.Team1)
                .IsUnicode(false);

            modelBuilder.Entity<SecondTeam>()
                .Property(e => e.Team2)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.Team1)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.Team2)
                .IsUnicode(false);

            modelBuilder.Entity<ThirdTeam>()
                .Property(e => e.Team1)
                .IsUnicode(false);

            modelBuilder.Entity<ThirdTeam>()
                .Property(e => e.Team2)
                .IsUnicode(false);
        }
    }
}
