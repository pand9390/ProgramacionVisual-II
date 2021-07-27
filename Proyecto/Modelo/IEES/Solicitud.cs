using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.IEES
{
    public class Solicitud : IDBEntity
    {
        public int SolicitudId { get; set; }
        public DateTime Fecha { get; set; }
        public Pension Pension { get; set; }
        public string Estado { get; set; }
        public Beneficiario Beneficiario { get; set; }
    }
}
