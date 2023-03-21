using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Models;

public partial class MatrimonyContext : DbContext
{
    public MatrimonyContext()
    {
    }

    public MatrimonyContext(DbContextOptions<MatrimonyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Cast> Casts { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<District> Districts { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<Photogallery> Photogalleries { get; set; }

    public virtual DbSet<Qualification> Qualifications { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Taluka> Talukas { get; set; }

    public virtual DbSet<UserInformation> UserInformations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=Matrimony;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.AddId).HasName("PK__Address__A0E1ADEE7334938C");

            entity.ToTable("Address");

            entity.Property(e => e.AddId).HasColumnName("AddID");
            entity.Property(e => e.Address1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Address");
            entity.Property(e => e.AddressType)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.City).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK__Address__CityId__44FF419A");
        });

        modelBuilder.Entity<Cast>(entity =>
        {
            entity.HasKey(e => e.CastId).HasName("PK__Cast__68A1293C5764C8DE");

            entity.ToTable("Cast");

            entity.Property(e => e.CastName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PK__City__F2D21A96A5551628");

            entity.ToTable("City");

            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CityName)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Tq).WithMany(p => p.Cities)
                .HasForeignKey(d => d.TqId)
                .HasConstraintName("FK__City__TqId__4222D4EF");
        });

        modelBuilder.Entity<District>(entity =>
        {
            entity.HasKey(e => e.DistId).HasName("PK__District__118299B89C40F1FF");

            entity.ToTable("District");

            entity.Property(e => e.DistName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StateId).HasColumnName("StateID");

            entity.HasOne(d => d.State).WithMany(p => p.Districts)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK__District__StateI__398D8EEE");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.LangId).HasName("PK__Language__A5F312DEE87F2C9D");

            entity.ToTable("Language");

            entity.Property(e => e.Language1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("language");
        });

        modelBuilder.Entity<Photogallery>(entity =>
        {
            entity.HasKey(e => e.PhotoId).HasName("PK__Photogal__21B7B5E210DE6442");

            entity.ToTable("Photogallery");

            entity.Property(e => e.ImgUrl)
                .HasMaxLength(20)
                .HasColumnName("ImgURL");

            entity.HasOne(d => d.User).WithMany(p => p.Photogalleries)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Photogall__UserI__4F7CD00D");
        });

        modelBuilder.Entity<Qualification>(entity =>
        {
            entity.HasKey(e => e.QualId).HasName("PK__Qualific__B8C90223D52D92D8");

            entity.ToTable("Qualification");

            entity.Property(e => e.Qualification1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("qualification");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.StateId).HasName("PK__State__3214EC07C8C04389");

            entity.ToTable("State");

            entity.Property(e => e.StateName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Taluka>(entity =>
        {
            entity.HasKey(e => e.TqId).HasName("PK__Taluka__FFB869498D747C89");

            entity.ToTable("Taluka");

            entity.Property(e => e.TqId).HasColumnName("TqID");
            entity.Property(e => e.TqName)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Dist).WithMany(p => p.Talukas)
                .HasForeignKey(d => d.DistId)
                .HasConstraintName("FK__Taluka__DistId__3F466844");
        });

        modelBuilder.Entity<UserInformation>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UserInfo__1788CCAC015C665F");

            entity.ToTable("UserInformation");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.MarrigeStatus)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ZodiacSign)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
