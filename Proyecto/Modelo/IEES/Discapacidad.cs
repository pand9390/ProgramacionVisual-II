using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.IEES
{
    public class Discapacidad : IDBEntity
    {
        public int DiscapacidadId { get; set; }
        public string Nombre { get; set; }
        public int Grado { get; set; }
        
    }
}
