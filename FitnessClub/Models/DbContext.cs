using System.Data.Entity;

namespace FitnessClub.Models
{
    public class FitnessDbContext :DbContext
    {
        public DbSet<Shifts> Shifts { get; set; }
        public DbSet<Member> Members { get; set; }

        public DbSet<Trainer> Trainers { get; set; }

        public DbSet<Admin> Admins { get; set; }

    }
}