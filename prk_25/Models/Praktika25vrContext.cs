using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace prk_25.Models;

public partial class Praktika25vrContext : DbContext
{
    public Praktika25vrContext()
    {
    }

    public Praktika25vrContext(DbContextOptions<Praktika25vrContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<MaterialOrder> MaterialOrders { get; set; }

    public virtual DbSet<Oborud> Oboruds { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Otdel> Otdels { get; set; }

    public virtual DbSet<Partner> Partners { get; set; }

    public virtual DbSet<Personal> Personals { get; set; }

    public virtual DbSet<PersonalUserDatum> PersonalUserData { get; set; }

    public virtual DbSet<Proccese> Procceses { get; set; }

    public virtual DbSet<Provider> Providers { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<TypeMaterial> TypeMaterials { get; set; }

    public virtual DbSet<TypeProcce> TypeProcces { get; set; }

    public virtual DbSet<Zayavki> Zayavkis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Praktika_25vr;Username=postgres;Password=qazwsxedc12");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.IdMat).HasName("Materials_pkey");

            entity.Property(e => e.IdMat)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_mat");
            entity.Property(e => e.Dencity).HasColumnName("dencity");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ProviderId).HasColumnName("provider_id");
            entity.Property(e => e.TypeMatId).HasColumnName("type_mat_id");

            entity.HasOne(d => d.Provider).WithMany(p => p.Materials)
                .HasForeignKey(d => d.ProviderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_2");

            entity.HasOne(d => d.TypeMat).WithMany(p => p.Materials)
                .HasForeignKey(d => d.TypeMatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_1");
        });

        modelBuilder.Entity<MaterialOrder>(entity =>
        {
            entity.HasKey(e => new { e.IdOrder, e.IdMat }).HasName("MaterialOrder_pkey");

            entity.ToTable("MaterialOrder");

            entity.Property(e => e.IdOrder).HasColumnName("id_order");
            entity.Property(e => e.IdMat).HasColumnName("id_mat");
            entity.Property(e => e.Value)
                .HasMaxLength(50)
                .HasColumnName("value");

            entity.HasOne(d => d.IdMatNavigation).WithMany(p => p.MaterialOrders)
                .HasForeignKey(d => d.IdMat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_2");

            entity.HasOne(d => d.IdOrderNavigation).WithMany(p => p.MaterialOrders)
                .HasForeignKey(d => d.IdOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_1");
        });

        modelBuilder.Entity<Oborud>(entity =>
        {
            entity.HasKey(e => e.IdOborud).HasName("Oborud_pkey");

            entity.ToTable("Oborud");

            entity.Property(e => e.IdOborud)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_oborud");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.IdOrder).HasName("Orders_pkey");

            entity.Property(e => e.IdOrder)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_order");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.OtdelId).HasColumnName("otdel_id");
            entity.Property(e => e.PartnerId).HasColumnName("partner_id");
            entity.Property(e => e.ProccesId).HasColumnName("procces_id");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Otdel).WithMany(p => p.Orders)
                .HasForeignKey(d => d.OtdelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_1");

            entity.HasOne(d => d.Partner).WithMany(p => p.Orders)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_3");

            entity.HasOne(d => d.Procces).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ProccesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_2");
        });

        modelBuilder.Entity<Otdel>(entity =>
        {
            entity.HasKey(e => e.IdOtdel).HasName("Otdels_pkey");

            entity.Property(e => e.IdOtdel)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_otdel");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.IdPartner).HasName("Partners_pkey");

            entity.Property(e => e.IdPartner)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_partner");
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .HasColumnName("lname");
            entity.Property(e => e.ManagerId).HasColumnName("manager_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.Sname)
                .HasMaxLength(50)
                .HasColumnName("sname");

            entity.HasOne(d => d.Manager).WithMany(p => p.Partners)
                .HasForeignKey(d => d.ManagerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_1");
        });

        modelBuilder.Entity<Personal>(entity =>
        {
            entity.HasKey(e => e.IdPersonal).HasName("Personal_pkey");

            entity.ToTable("Personal");

            entity.Property(e => e.IdPersonal)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_personal");
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .HasColumnName("lname");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.OtdelId).HasColumnName("otdel_id");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.Sname)
                .HasMaxLength(50)
                .HasColumnName("sname");

            entity.HasOne(d => d.IdPersonalNavigation).WithOne(p => p.Personal)
                .HasForeignKey<Personal>(d => d.IdPersonal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_1");

            entity.HasOne(d => d.Otdel).WithMany(p => p.Personals)
                .HasForeignKey(d => d.OtdelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_3");

            entity.HasOne(d => d.Role).WithMany(p => p.Personals)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_2");
        });

        modelBuilder.Entity<PersonalUserDatum>(entity =>
        {
            entity.HasKey(e => e.IdPersonal).HasName("PersonalUserData_pkey");

            entity.Property(e => e.IdPersonal)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_personal");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(250)
                .HasColumnName("password");
        });

        modelBuilder.Entity<Proccese>(entity =>
        {
            entity.HasKey(e => e.IdProcces).HasName("Procceses_pkey");

            entity.Property(e => e.IdProcces)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_procces");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Time)
                .HasMaxLength(50)
                .HasColumnName("time");
            entity.Property(e => e.TypeId).HasColumnName("type_id");
            entity.Property(e => e.Volume)
                .HasMaxLength(50)
                .HasColumnName("volume");

            entity.HasOne(d => d.Type).WithMany(p => p.Procceses)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_1");

            entity.HasMany(d => d.IdOboruds).WithMany(p => p.IdProcs)
                .UsingEntity<Dictionary<string, object>>(
                    "OborudProcce",
                    r => r.HasOne<Oborud>().WithMany()
                        .HasForeignKey("IdOborud")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_2"),
                    l => l.HasOne<Proccese>().WithMany()
                        .HasForeignKey("IdProc")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_1"),
                    j =>
                    {
                        j.HasKey("IdProc", "IdOborud").HasName("OborudProcces_pkey");
                        j.ToTable("OborudProcces");
                        j.IndexerProperty<int>("IdProc").HasColumnName("id_proc");
                        j.IndexerProperty<int>("IdOborud").HasColumnName("id_oborud");
                    });
        });

        modelBuilder.Entity<Provider>(entity =>
        {
            entity.HasKey(e => e.IdProvider).HasName("Providers_pkey");

            entity.Property(e => e.IdProvider)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_provider");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("address");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRole).HasName("Roles_pkey");

            entity.Property(e => e.IdRole)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_role");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<TypeMaterial>(entity =>
        {
            entity.HasKey(e => e.IdType).HasName("TypeMaterial_pkey");

            entity.ToTable("TypeMaterial");

            entity.Property(e => e.IdType)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_type");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<TypeProcce>(entity =>
        {
            entity.HasKey(e => e.IdType).HasName("TypeProcces_pkey");

            entity.Property(e => e.IdType)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_type");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Zayavki>(entity =>
        {
            entity.HasKey(e => e.IdApl).HasName("Applications_pkey");

            entity.ToTable("Zayavki");

            entity.Property(e => e.IdApl)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_apl");
            entity.Property(e => e.DescС)
                .HasMaxLength(250)
                .HasColumnName("desc_с");
            entity.Property(e => e.IdPersonal).HasColumnName("id_personal");

            entity.HasOne(d => d.IdPersonalNavigation).WithMany(p => p.Zayavkis)
                .HasForeignKey(d => d.IdPersonal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
