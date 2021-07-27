using System;
using Escenarios;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            var Escenario = new Escenario01();
            var EscenarioControl = new EscenarioControl();
            EscenarioControl.Grabar(Escenario);
        }
    }
}
