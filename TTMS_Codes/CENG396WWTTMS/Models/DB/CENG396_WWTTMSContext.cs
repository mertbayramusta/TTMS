using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CENG396WWTTMS.Models.DB
{
    public partial class CENG396_WWTTMSContext : DbContext
    {
        public CENG396_WWTTMSContext()
        {
        }

        public CENG396_WWTTMSContext(DbContextOptions<CENG396_WWTTMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Crew> Crew { get; set; }
        public virtual DbSet<CrewMember> CrewMember { get; set; }
        public virtual DbSet<Mcc> Mcc { get; set; }
        public virtual DbSet<Trouble> Trouble { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.AbonNum);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Crew>(entity =>
            {
                entity.Property(e => e.CrewId)
                    .HasColumnName("Crew_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CrewName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CrewMember>(entity =>
            {
                entity.HasKey(e => e.MemberId);

                entity.Property(e => e.MemberId)
                    .HasColumnName("Member_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CrewId).HasColumnName("Crew_ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MemberName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewMember)
                    .HasForeignKey(d => d.CrewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Is_A_Member");
            });

            modelBuilder.Entity<Mcc>(entity =>
            {
                entity.ToTable("MCC");

                entity.Property(e => e.MccId)
                    .HasColumnName("MCC_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MccName)
                    .IsRequired()
                    .HasColumnName("MCC_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Trouble>(entity =>
            {
                entity.HasKey(e => e.TtNumber);

                entity.Property(e => e.TtNumber).HasColumnName("TT_Number");

                entity.Property(e => e.CrewAssignedId).HasColumnName("CrewAssigned_ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TicketState).HasMaxLength(50);

                entity.Property(e => e.TroubleDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.AbonNumNavigation)
                    .WithMany(p => p.Trouble)
                    .HasForeignKey(d => d.AbonNum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Creates");

                entity.HasOne(d => d.CrewAssigned)
                    .WithMany(p => p.Trouble)
                    .HasForeignKey(d => d.CrewAssignedId)
                    .HasConstraintName("Handles");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
