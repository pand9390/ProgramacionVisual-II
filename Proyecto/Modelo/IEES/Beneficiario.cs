using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.IEES
{
    public class Beneficiario : IDBEntity
    {
        public int BeneficiarioId {get; set;}
        public string Nombre { get; set; }

        public Discapacidad discapacidad { get; set; }

    }
}
