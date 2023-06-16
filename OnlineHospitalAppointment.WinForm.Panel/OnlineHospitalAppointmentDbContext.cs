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

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Expert> Experts { get; set; }

    public virtual DbSet<LoginLog> LoginLogs { get; set; }

    public virtual DbSet<Province> Provinces { get; set; }

    public virtual DbSet<ReservationLog> ReservationLogs { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SpecialistType> SpecialistTypes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<AppointmentChart> AppointmentCharts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.;Database=OnlineHospitalAppointmentDB;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminActivityLog>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(225);

            entity.HasOne(d => d.User).WithMany(p => p.AdminActivityLogs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdminActivityLogs_Users");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cities__3214EC070E8C6E28");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            entity.HasOne(d => d.Province).WithMany(p => p.Cities)
                .HasForeignKey(d => d.ProvinceId)
                .HasConstraintName("FK_Cities_Provinces");
        });

        modelBuilder.Entity<Expert>(entity =>
        {
            entity.Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(150);

            entity.HasOne(d => d.User).WithMany(p => p.Experts)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Experts_Provinces");
        });

        modelBuilder.Entity<LoginLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Login");

            entity.Property(e => e.Password).IsRequired();
            entity.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<Province>(entity =>
        {
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<ReservationLog>(entity =>
        {
            entity.Property(e => e.Description).HasMaxLength(225);
            entity.Property(e => e.TrackingCode)
                .IsRequired()
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Expert).WithMany(p => p.ReservationLogs)
                .HasForeignKey(d => d.ExpertId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReservationLogs_Experts");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SpecialistType>(entity =>
        {
            entity.Property(e => e.Specialist)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
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

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_Roles");
        });

        modelBuilder.Entity<AppointmentChart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_AppointmentChart");

            entity.Property(e => e.UserId)
            .IsRequired(false);

            entity.Property(e => e.ExpertId)
            .IsRequired();

            entity.Property(e => e.AppointmentDate)
            .IsRequired();

            entity.Property(e => e.IsReserved)
            .IsRequired();
        });
    }
}