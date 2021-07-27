using Modelo;

using System.Collections.Generic;


namespace Escenarios
{
    public class Escenario
    {
        public enum ListaTipo { 
            Afiliados, 
            //Configuracion, 
            Aportaciones, 
            Beneficiarios, 
            Discapacidades, 
            Pensiones, 
            Solicitudes
            //Cursos
        }

        public Dictionary<ListaTipo, IEnumerable<IDBEntity>> datos;        

        public Escenario()
        {
            datos = new();
        }
    }
}
