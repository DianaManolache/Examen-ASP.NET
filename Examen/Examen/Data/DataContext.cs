using Examen.Models;
using Microsoft.EntityFrameworkCore;

namespace Examen.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Eveniment> Eveniments { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<ParticipantEveniment> ParticipantsEveniment { get; set;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParticipantEveniment>()
                    .HasKey(pe => new { pe.ParticipantId, pe.EvenimentId });
            modelBuilder.Entity<ParticipantEveniment>()
                    .HasOne(p => p.Participant)
                    .WithMany(pe => pe.ParticipantEveniments)
                    .HasForeignKey(p => p.ParticipantId);
            modelBuilder.Entity<ParticipantEveniment>()
                    .HasOne(p => p.Eveniment)
                    .WithMany(pe => pe.ParticipantEveniments)
                    .HasForeignKey(e => e.EvenimentId);
        }
    }
}
