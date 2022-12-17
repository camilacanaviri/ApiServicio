using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiServicio.Modelos.Dato
{
    public partial class EmpresaVelmotorContext : DbContext
    {
        public EmpresaVelmotorContext()
        {
        }

        public EmpresaVelmotorContext(DbContextOptions<EmpresaVelmotorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Compra> Compras { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<FichajeCitum> FichajeCita { get; set; }
        public virtual DbSet<Registro> Registros { get; set; }
        public virtual DbSet<Servicio> Servicios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
              //  optionsBuilder.UseSqlServer("server =DESKTOP-AUA202P ; database = EmpresaVelmotor; Trusted_Connection = true; user=sa ;password=camila123; Encrypt=false");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK_Cliente_1");

                entity.ToTable("Cliente");

                entity.Property(e => e.IdCliente)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ApellidoCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido_cliente");

                entity.Property(e => e.DireccionCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion_cliente");

                entity.Property(e => e.Institución)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_cliente");

                entity.Property(e => e.TelefonoCliente).HasColumnName("telefono_cliente");
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.HasKey(e => e.IdCompra)
                    .HasName("PK_Compra_1");

                entity.ToTable("Compra");

                entity.Property(e => e.IdCompra)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_compra");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.IdCliente)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("id_cliente");

                entity.Property(e => e.IdPlaca)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_placa");

                entity.Property(e => e.IdServicio)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_Servicio");

                entity.Property(e => e.PrecioTotal).HasColumnName("Precio_total");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PK_Empleado_1");

                entity.ToTable("Empleado");

                entity.Property(e => e.IdEmpleado)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Cargo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Disponible)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreEmpleado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_empleado");
            });

            modelBuilder.Entity<FichajeCitum>(entity =>
            {
                entity.HasKey(e => e.IdFichaje)
                    .HasName("PK_Fichaje_Cita_1");

                entity.ToTable("Fichaje_Cita");

                entity.Property(e => e.IdFichaje)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_fichaje");

                entity.Property(e => e.CambioKms).HasColumnName("Cambio_Kms");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Placa)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProximaFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("Proxima_Fecha");
            });

            modelBuilder.Entity<Registro>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Registro_1");

                entity.ToTable("Registro");

                entity.Property(e => e.IdRegistro)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_Registro");

                entity.Property(e => e.Contraseña).HasColumnName("contraseña");

                entity.Property(e => e.IdCliente)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("id_Cliente");

                entity.Property(e => e.IngresoDeApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ingreso_de_Apellido");

                entity.Property(e => e.IngresoDeNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ingreso_de_Nombre");
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.HasKey(e => e.IdServicio);

                entity.ToTable("Servicio");

                entity.Property(e => e.IdServicio)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Items)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Seccion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK_usuario_1");

                entity.ToTable("usuario");

                entity.Property(e => e.IdUsuario)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id_usuario");

                entity.Property(e => e.Usuario1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Usuario");
            });

            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.HasKey(e => e.IdVehiculo)
                    .HasName("PK_Vehiculo_1");

                entity.ToTable("Vehiculo");

                entity.Property(e => e.IdVehiculo)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idVehiculo");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ColorAuto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("color_auto");

                entity.Property(e => e.Marca)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("marca");

                entity.Property(e => e.ModeloAuto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("modelo_auto");

                entity.Property(e => e.Placa)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
