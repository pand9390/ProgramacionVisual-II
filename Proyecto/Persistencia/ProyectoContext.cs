using Microsoft.EntityFrameworkCore;
using Modelo.IEES;

namespace Persistencia

{
    public class ProyectoContext: DbContext
    {
        public DbSet<Afiliado> afiliados { get; set; }
        public DbSet<Aportacion> aportaciones { get; set; }
        public DbSet<Beneficiario> beneficiarios { get; set; }
        public DbSet<Discapacidad> discapacidades { get; set; }
        public DbSet<Pension> pensioness { get; set; }
        public DbSet<Solicitud> solicitudes { get; set; }
        

        // Constructor vacio
        public ProyectoContext():base() 
        { 

        }

        // Constructor para pasar la conexión al padre
        public ProyectoContext(DbContextOptions<ProyectoContext> opciones) 
            : base(opciones) 
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                switch (ProyectoConfig.PersistenciaDestino)
                {
                    case "SqlServerEscuela":
                        optionsBuilder.UseSqlServer(ProyectoConfig.connectionString);
                        break;
                    case "PostgresEscuela":
                        optionsBuilder.UseNpgsql(ProyectoConfig.connectionString);
                        break;
                    case "memoriaEscuela":
                        optionsBuilder.UseInMemoryDatabase(ProyectoConfig.connectionString);
                        break;

                }
            }

        }

        

        // Modelado
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            // Relación uno a muchos; un Afiliado tiene muchas Aportaciones

            modelBuilder.Entity<Aportacion>()
                .HasOne(apor => apor.Afiliado)
                .WithMany(afil => afil.Aportaciones)
                .HasForeignKey(apor => apor.AfiliadoId);

            // Relación uno a muchos; un Beneficiario puede tener varias pensiones
            //modelBuilder.Entity<Pension>()
            //    .HasOne(pen => pen.Beneficiario)
            //    .WithOne(ben => ben.Pensione)
            //    .HasForeignKey(pen => pen.BeneficiarioId);

          

           
           


        }
       
       

    }
}
