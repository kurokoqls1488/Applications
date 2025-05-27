using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Applications_project;

public partial class ApplicationsContext : DbContext
{
    public ApplicationsContext()
    {
    }

    public ApplicationsContext(DbContextOptions<ApplicationsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Audience> Audiences { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<EducationalBuilding> EducationalBuildings { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Sender> Senders { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Task> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("host=localhost;port=5432;database=Applications;username=postgres;password=1234");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Audience>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("audience_pkey");

            entity.ToTable("audience");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AudienceName).HasColumnName("audience_name");
            entity.Property(e => e.AudienceNumber).HasColumnName("audience_number");
            entity.Property(e => e.IdAcademicBuilding)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_academic_building");

            entity.HasOne(d => d.IdAcademicBuildingNavigation).WithMany(p => p.Audiences)
                .HasForeignKey(d => d.IdAcademicBuilding)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("audience_id_academic_building_fkey");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("categories_pkey");

            entity.ToTable("categories");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameCategory).HasColumnName("name_category");
        });

        modelBuilder.Entity<EducationalBuilding>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("educational_buildings_pkey");

            entity.ToTable("educational_buildings");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AbbreviatedName).HasColumnName("abbreviated_name");
            entity.Property(e => e.FullName).HasColumnName("full_name");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("employees_pkey");

            entity.ToTable("employees");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.DateOfDismissal).HasColumnName("date_of_dismissal");
            entity.Property(e => e.DateOfReceipt).HasColumnName("date_of_receipt");
            entity.Property(e => e.FullName).HasColumnName("full_name");
        });

        modelBuilder.Entity<Sender>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sender_pkey");

            entity.ToTable("sender");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FullName).HasColumnName(" full_name");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("statuses_pkey");

            entity.ToTable("statuses");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StatusName).HasColumnName("status_name");
        });

        modelBuilder.Entity<Task>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tasks_pkey");

            entity.ToTable("tasks");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.IdAudience)
                .HasDefaultValueSql("nextval('\"tasks_id audience_seq\"'::regclass)")
                .HasColumnName("id_audience");
            entity.Property(e => e.IdCategory)
                .HasDefaultValueSql("nextval('\"tasks_id category_seq\"'::regclass)")
                .HasColumnName("id_category");
            entity.Property(e => e.IdEmployee)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_employee");
            entity.Property(e => e.IdSender)
                .HasDefaultValueSql("nextval('\"tasks_id sender_seq\"'::regclass)")
                .HasColumnName("id_sender");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");

            entity.HasOne(d => d.IdAudienceNavigation).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.IdAudience)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tasks_id_audience_fkey");

            entity.HasOne(d => d.IdCategoryNavigation).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.IdCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tasks_id_category_fkey");

            entity.HasOne(d => d.IdEmployeeNavigation).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.IdEmployee)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tasks_id_employee_fkey");

            entity.HasOne(d => d.IdSenderNavigation).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.IdSender)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tasks_id_sender_fkey");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.IdStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tasks_id_status_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
