using Devon4Net.WebAPI.Implementation.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devon4Net.WebAPI.Implementation.Domain.Database
{
    public partial class AelContext : DbContext
    {
        public AelContext()
        {
        }

        public AelContext(DbContextOptions<AelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Town> Towns { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserTown> UserTowns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5902;Database=AEL;Username=postgres;Password=changeme");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.utf8");

            modelBuilder.Entity<Town>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Community)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("DNI");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<UserTown>(entity =>
            {
                entity.ToTable("User_Town");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RegisterDate).HasColumnType("date");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.UserTowns)
                    .HasForeignKey(d => d.TownId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_town_fk_1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTowns)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_town_fk");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
