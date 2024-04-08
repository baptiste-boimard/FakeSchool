using Microsoft.EntityFrameworkCore;
using SchoolRepository.DTO;
using SchoolRepository.Migration;
using SchoolRepository.Models;

namespace SchoolRepository.Data;

public partial class FakeschoolContext : DbContext
{
    public FakeschoolContext()
    {
    }

    public FakeschoolContext(DbContextOptions<FakeschoolContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }
    public virtual DbSet<Coursegroup> Coursegroups { get; set; }
    public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; }
    public virtual DbSet<Group> Groups { get; set; }
    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=localhost;database=fakeschool;user=root;password=password", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.36-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("courses");

            entity.Property(e => e.Id)
                .UseCollation("ascii_general_ci")
                .HasCharSet("ascii");
            entity.Property(e => e.Created).HasMaxLength(6);
            entity.Property(e => e.Date).HasMaxLength(6);
            entity.Property(e => e.Modified).HasMaxLength(6);
        });

        modelBuilder.Entity<Coursegroup>(entity =>
        {
            entity.HasKey(e => new { e.CoursesId, e.GroupsId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("coursegroup");

            entity.HasIndex(e => e.GroupsId, "IX_CourseGroup_GroupsId");

            entity.Property(e => e.CoursesId)
                .UseCollation("ascii_general_ci")
                .HasCharSet("ascii");
            entity.Property(e => e.GroupsId)
                .UseCollation("ascii_general_ci")
                .HasCharSet("ascii");
        });

        modelBuilder.Entity<Efmigrationshistory>(entity =>
        {
            entity.HasKey(e => e.MigrationId).HasName("PRIMARY");

            entity.ToTable("__efmigrationshistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("groups");

            entity.Property(e => e.Id)
                .UseCollation("ascii_general_ci")
                .HasCharSet("ascii");
            entity.Property(e => e.Created).HasMaxLength(6);
            entity.Property(e => e.Modified).HasMaxLength(6);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("students");

            entity.HasIndex(e => e.GroupId, "IX_Students_GroupId");

            entity.Property(e => e.Id)
                .UseCollation("ascii_general_ci")
                .HasCharSet("ascii");
            entity.Property(e => e.Birthday).HasMaxLength(6);
            entity.Property(e => e.Created).HasMaxLength(6);
            entity.Property(e => e.GroupId)
                .UseCollation("ascii_general_ci")
                .HasCharSet("ascii");
            entity.Property(e => e.Modified).HasMaxLength(6);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
