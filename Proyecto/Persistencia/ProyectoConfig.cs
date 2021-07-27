using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;


namespace Persistencia

{
    public class ProyectoConfig
    {
        public enum DestinoTipo { SQLServerEscuela,PostgresEscuela,MemoriaEscuela };

        static public string PersistenciaDestino;
        static public string connectionString;
        static public bool modoVirtual;


        static ProyectoConfig()
        {
            // Lectura de los parámetros del sistema
            
            PersistenciaDestino = ConfigurationManager.AppSettings["PersistenciaDestino"].ToString();
            connectionString = ConfigurationManager.ConnectionStrings[PersistenciaDestino].ToString();
            //Debug
            Console.WriteLine(PersistenciaDestino+" "+connectionString);

       
        }

        static public DbContextOptions<ProyectoContext> ContextOptions()
        {
            DbContextOptions<ProyectoContext> opciones = null;
            modoVirtual = true;
            switch (PersistenciaDestino)
            {
                case "SqlServerEscuela":
                    opciones = new DbContextOptionsBuilder<ProyectoContext>()
                        .UseSqlServer(connectionString)
                        .Options;
                    break;
                case "PostgresEscuela":
                    opciones = new DbContextOptionsBuilder<ProyectoContext>()
                        .UseNpgsql(connectionString)
                        .Options;
                    break;

                case "memoriaEscuela":
                    if (modoVirtual)
                    {
                        opciones = new DbContextOptionsBuilder<ProyectoContext>()
                            .UseInMemoryDatabase(connectionString)
                            .Options;
                    }
                    break;
                default:
                    break;

            }
            return opciones;

        }




    }
}
