using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.IEES
{
    public class Pension : IDBEntity 
    {
        public int PensionId { get; set; }
        public string Nombre { get; set; }
        //public Beneficiario Beneficiario { get; set; }
        //public int BeneficiarioId { get; set; }

    }
}
