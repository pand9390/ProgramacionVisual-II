using System;
using System.Collections.Generic;
using Escenarios;
using Modelo.IEES;
using Persistencia;
using static Escenarios.Escenario;

namespace Proyecto
{
    public class EscenarioControl
    {
        public void Grabar( IEscenario escenario)
        {
            var datos = escenario.Carga();

            using (var db = new ProyectoContext())
            {
                //reinicio la base de datos
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

               // Ingresamos los datos

                db.afiliados.AddRange((List<Afiliado>)datos[ListaTipo.Afiliados]);
                db.aportaciones.AddRange((List<Aportacion>)datos[ListaTipo.Aportaciones]);
                db.beneficiarios.AddRange((List<Beneficiario>)datos[ListaTipo.Beneficiarios]);
                db.discapacidades.AddRange((List<Discapacidad>)datos[ListaTipo.Discapacidades]);
                db.pensioness.AddRange((List<Pension>)datos[ListaTipo.Pensiones]);

                db.SaveChanges();


            }


            
        }
    }
}
