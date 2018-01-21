using System;
using WebASCATUR.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebASCATUR.Data
{
    public class AdmWebASCATUR_Default_v1Context : DbContext
    {
        public DbSet<Comercio> Comercio { get; set; }
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<Exceptions> Exceptions { get; set; }
        public DbSet<Languages> Languages { get; set; }
        public DbSet<Oferta> Oferta { get; set; }
        public DbSet<Opinion> Opinion { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<RolePermissions> RolePermissions { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Servicio> Servicio { get; set; }
        public DbSet<UserPermissions> UserPermissions { get; set; }
        public DbSet<UserPreferences> UserPreferences { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<Users> Users { get; set; }

        // Unable to generate entity type for table 'dbo.VersionInfo'. Please see the warning messages.

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer(@"Server=MANUEL\SQLEXPRESS;Database=AdmWebASCATUR_Default_v1;Trusted_Connection=True;");
        //            }
        //        }
        public AdmWebASCATUR_Default_v1Context(DbContextOptions<AdmWebASCATUR_Default_v1Context> options)
    : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comercio>(entity =>
            {
                entity.Property(e => e.CantidadEmpleados).HasColumnName("Cantidad_Empleados");

                entity.Property(e => e.Canton).HasMaxLength(50);

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DescripcionIngles).HasColumnName("Descripcion_Ingles");

                entity.Property(e => e.DireccionRepresentante)
                    .HasColumnName("Direccion_Representante")
                    .HasMaxLength(400);

                entity.Property(e => e.Distrito).HasMaxLength(50);

                entity.Property(e => e.EstadoCivil)
                    .HasColumnName("Estado_Civil")
                    .HasMaxLength(50);

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("Fecha_ingreso")
                    .HasColumnType("date");

                entity.Property(e => e.GaleriaImagenes).HasColumnName("Galeria_Imagenes");

                entity.Property(e => e.IdentificacionRepresentante)
                    .IsRequired()
                    .HasColumnName("Identificacion_Representante")
                    .HasMaxLength(50);

                entity.Property(e => e.ImagenPrimaria)
                    .HasColumnName("Imagen_Primaria")
                    .HasMaxLength(100);

                entity.Property(e => e.Localidad).HasMaxLength(50);

                entity.Property(e => e.Mail).HasMaxLength(50);

                entity.Property(e => e.MailRepresentante)
                    .HasColumnName("Mail_Representante")
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NombreRepresentante)
                    .IsRequired()
                    .HasColumnName("Nombre_Representante")
                    .HasMaxLength(50);

                entity.Property(e => e.NumAfiliacion).HasColumnName("Num_Afiliacion");

                entity.Property(e => e.Ocupacion).HasMaxLength(50);

                entity.Property(e => e.Telefono).HasMaxLength(50);

                entity.Property(e => e.TelefonoRepresentante)
                    .HasColumnName("Telefono_Representante")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Eventos>(entity =>
            {
                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DetalleIngles)
                    .HasColumnName("Detalle_Ingles")
                    .HasMaxLength(200);

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("Fecha_Ingreso")
                    .HasColumnType("date");

                entity.Property(e => e.FechaRealizar)
                    .HasColumnName("Fecha_realizar")
                    .HasColumnType("date");

                entity.Property(e => e.GaleriaImagenes).HasColumnName("Galeria_Imagenes");

                entity.Property(e => e.IdComercio).HasColumnName("Id_Comercio");

                entity.Property(e => e.ImagenPrimaria)
                    .HasColumnName("Imagen_Primaria")
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdComercioNavigation)
                    .WithMany(p => p.Eventos)
                    .HasForeignKey(d => d.IdComercio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eventos_Comercio");
            });

            modelBuilder.Entity<Exceptions>(entity =>
            {
                entity.HasIndex(e => new { e.ApplicationName, e.DeletionDate, e.CreationDate })
                    .HasName("IX_Exceptions_App_Del_Cre");

                entity.HasIndex(e => new { e.ErrorHash, e.ApplicationName, e.CreationDate, e.DeletionDate })
                    .HasName("IX_Exceptions_Hash_App_Cre_Del");

                entity.HasIndex(e => new { e.Guid, e.ApplicationName, e.DeletionDate, e.CreationDate })
                    .HasName("IX_Exceptions_GUID_App_Del_Cre");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DeletionDate).HasColumnType("datetime");

                entity.Property(e => e.DuplicateCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Host).HasMaxLength(100);

                entity.Property(e => e.Httpmethod)
                    .HasColumnName("HTTPMethod")
                    .HasMaxLength(10);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(40);

                entity.Property(e => e.IsProtected).HasDefaultValueSql("((1))");

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Message).HasMaxLength(1000);

                entity.Property(e => e.Source).HasMaxLength(100);

                entity.Property(e => e.Sql).HasColumnName("SQL");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Url).HasMaxLength(500);
            });

            modelBuilder.Entity<Languages>(entity =>
            {
                entity.Property(e => e.LanguageId)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Oferta>(entity =>
            {
                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DetalleIngles)
                    .HasColumnName("Detalle_Ingles")
                    .HasMaxLength(200);

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("Fecha_Ingreso")
                    .HasColumnType("date");

                entity.Property(e => e.GaleriaImagenes).HasColumnName("Galeria_Imagenes");

                entity.Property(e => e.IdComercio).HasColumnName("Id_Comercio");

                entity.Property(e => e.ImagenPrimaria)
                    .HasColumnName("Imagen_Primaria")
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrecioIngles)
                    .HasColumnName("Precio_Ingles")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.IdComercioNavigation)
                    .WithMany(p => p.Oferta)
                    .HasForeignKey(d => d.IdComercio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Oferta_Comercio");
            });

            modelBuilder.Entity<Opinion>(entity =>
            {
                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("Fecha_Ingreso")
                    .HasColumnType("date");

                entity.Property(e => e.IdComercio).HasColumnName("Id_Comercio");

                entity.Property(e => e.NombreUsuario)
                    .HasColumnName("Nombre_Usuario")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdComercioNavigation)
                    .WithMany(p => p.Opinion)
                    .HasForeignKey(d => d.IdComercio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Opinion_Comercio");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DetalleIngles)
                    .HasColumnName("Detalle_Ingles")
                    .HasMaxLength(200);

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("Fecha_Ingreso")
                    .HasColumnType("date");

                entity.Property(e => e.GaleriaImagenes).HasColumnName("Galeria_Imagenes");

                entity.Property(e => e.IdComercio).HasColumnName("Id_Comercio");

                entity.Property(e => e.ImagenPrimaria)
                    .HasColumnName("Imagen_Primaria")
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrecioIngles)
                    .HasColumnName("Precio_Ingles")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.IdComercioNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.IdComercio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Producto_Comercio");
            });

            modelBuilder.Entity<RolePermissions>(entity =>
            {
                entity.HasKey(e => e.RolePermissionId);

                entity.HasIndex(e => new { e.RoleId, e.PermissionKey })
                    .HasName("UQ_RolePerm_RoleId_PermKey")
                    .IsUnique();

                entity.Property(e => e.PermissionKey)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolePermissions_RoleId");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DetalleIngles)
                    .HasColumnName("Detalle_Ingles")
                    .HasMaxLength(200);

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("Fecha_Ingreso")
                    .HasColumnType("date");

                entity.Property(e => e.GaleriaImagenes).HasColumnName("Galeria_Imagenes");

                entity.Property(e => e.IdComercio).HasColumnName("Id_Comercio");

                entity.Property(e => e.ImagenPrimaria)
                    .HasColumnName("Imagen_Primaria")
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrecioIngles)
                    .HasColumnName("Precio_Ingles")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.IdComercioNavigation)
                    .WithMany(p => p.Servicio)
                    .HasForeignKey(d => d.IdComercio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Servicio_Comercio");
            });

            modelBuilder.Entity<UserPermissions>(entity =>
            {
                entity.HasKey(e => e.UserPermissionId);

                entity.HasIndex(e => new { e.UserId, e.PermissionKey })
                    .HasName("UQ_UserPerm_UserId_PermKey")
                    .IsUnique();

                entity.Property(e => e.Granted).HasDefaultValueSql("((1))");

                entity.Property(e => e.PermissionKey)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPermissions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPermissions_UserId");
            });

            modelBuilder.Entity<UserPreferences>(entity =>
            {
                entity.HasKey(e => e.UserPreferenceId);

                entity.HasIndex(e => new { e.UserId, e.PreferenceType, e.Name })
                    .HasName("IX_UserPref_UID_PrefType_Name")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PreferenceType)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(e => e.UserRoleId);

                entity.HasIndex(e => new { e.RoleId, e.UserId });

                entity.HasIndex(e => new { e.UserId, e.RoleId })
                    .HasName("UQ_UserRoles_UserId_RoleId")
                    .IsUnique();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoles_UserId");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastDirectoryUpdate).HasColumnType("datetime");

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(86);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserImage).HasMaxLength(100);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100);
            });
        }
    }
}
