using Microsoft.EntityFrameworkCore;
using OnlineHospitalAppointment.WinForm.Panel.Models;

namespace OnlineHospitalAppointment.WinForm.Panel;

public partial class OnlineHospitalAppointmentDbContext : DbContext
{
    public OnlineHospitalAppointmentDbContext()
    {
    }

    public OnlineHospitalAppointmentDbContext(DbContextOptions<OnlineHospitalAppointmentDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminActivityLog> AdminActivityLogs { get; set; }

    public virtual DbSet<AppointmentChart> AppointmentCharts { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Expert> Experts { get; set; }

    public virtual DbSet<LoginLog> LoginLogs { get; set; }

    public virtual DbSet<Province> Provinces { get; set; }

    public virtual DbSet<ReservationLog> ReservationLogs { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SpecialistType> SpecialistTypes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.;Database=OnlineHospitalAppointmentDB;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminActivityLog>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Description)
            .HasMaxLength(225);

            entity.HasOne(d => d.User).WithMany(p => p.AdminActivityLogs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<AppointmentChart>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.Property(x => x.IsReserved)
            .HasColumnType<bool>("tinyint");

            entity.HasOne(d => d.Expert).WithMany(p => p.AppointmentCharts)
                .HasForeignKey(d => d.ExpertId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.AppointmentCharts)
                .HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            entity.HasOne(d => d.Province).WithMany(p => p.Cities)
                .HasForeignKey(d => d.ProvinceId);
        });

        modelBuilder.Entity<Expert>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(150);

            entity.Property(x => x.IsDeleted)
            .HasColumnType<bool>("tinyint");

            entity.Property(x => x.IsSuspended)
            .HasColumnType<bool>("tinyint");

            entity.HasOne(d => d.User).WithMany(p => p.Experts)
                .HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<LoginLog>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Password).IsRequired();

            entity.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<Province>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<ReservationLog>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Description)
            .HasMaxLength(225);

            entity.Property(e => e.TrackingCode)
                .IsRequired()
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();

            entity.Property(x => x.IsCanceled)
            .HasColumnType<bool>("tinyint");

            entity.HasOne(d => d.AppointmentChart).WithMany(p => p.ReservationLogs)
                .HasForeignKey(d => d.AppointmentChartId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Expert).WithMany(p => p.ReservationLogs)
                .HasForeignKey(d => d.ExpertId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SpecialistType>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Specialist)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.BirthDay)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength();

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.NationalCode)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PhoneNumber)
                .IsRequired()
                .HasMaxLength(11)
                .IsUnicode(false);

            entity.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(x => x.IsMale)
            .HasColumnType<bool>("tinyint");

            entity.Property(x => x.IsDeleted)
            .HasColumnType<bool>("tinyint");

            entity.Property(x => x.IsSuspended)
            .HasColumnType<bool>("tinyint");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });
    }
}