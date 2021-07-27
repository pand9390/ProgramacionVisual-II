using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.IEES
{
    public class Aportacion : IDBEntity
    {
        public int AportacionId { get; set; }
        public DateTime FechaInicio { get; set; }
        
        public DateTime FechaFin { get; set; }
        public double Cantidad { get; set; }
        public Afiliado Afiliado { get; set; }
        public int AfiliadoId { get; set; }

    }
}
