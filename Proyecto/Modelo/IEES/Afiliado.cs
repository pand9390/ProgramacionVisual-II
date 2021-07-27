using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.IEES
{
    public class Afiliado :IDBEntity
    {
        public int AfiliadoId { get; set; }
        public string Nombre { get; set; }
        public double Sueldo { get; set; }
        public int Edad { get; set; }
        public List<Aportacion> Aportaciones { get; set; }
        
    }
}
