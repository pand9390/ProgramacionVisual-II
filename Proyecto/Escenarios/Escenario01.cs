using Modelo;
using Modelo.IEES;
using System;
using System.Collections.Generic;
using static Escenarios.Escenario;

namespace Escenarios
{
    public class Escenario01 : Escenario, IEscenario
    {
        public Dictionary<ListaTipo, IEnumerable<IDBEntity>> Carga()
        {
            // .- Creación de los Afiliados
            Afiliado Afiliado1 = new()
            {
                Nombre = "Jose",
                Sueldo = 356,
                Edad = 60
                
            };
            
            List<Afiliado> listaAfiliados = new() {Afiliado1 };
            datos.Add(ListaTipo.Afiliados, listaAfiliados);

            // .- Registro de Aportaciones
            Aportacion Apor_Afiliado1 = new() { 
                FechaInicio = new DateTime(2010, 5, 1),
                FechaFin = new DateTime(2020, 5, 1),
                Cantidad = 480,
                Afiliado = Afiliado1
            };
           
            List<Aportacion> lstAportaciones = new(){Apor_Afiliado1};
            datos.Add(ListaTipo.Aportaciones, lstAportaciones);

            // .- Registro de pensiones
            Pension JubilVejez = new()
            {
                Nombre = "jubilacion ordinaria vejez",
               
            };
            List<Pension> lstPensiones = new() { JubilVejez };
            datos.Add(ListaTipo.Pensiones, lstPensiones);

            // .- Registro de discapacidades
            Discapacidad Autismo = new()
            {
                Nombre = "Autismo",
                Grado = 60
            };
            List<Discapacidad> lstDiscapacidades = new() { Autismo };
            datos.Add(ListaTipo.Discapacidades, lstDiscapacidades);

            // .- Registro de beneficiarios
            Beneficiario Beneficiario1 = new()
            {
                Nombre= "Jose",
                discapacidad = Autismo
            };
            List<Beneficiario> lstBeneficiarios = new() { Beneficiario1 };
            datos.Add(ListaTipo.Beneficiarios, lstBeneficiarios);


            

            // Retorna el diccionario 
            return datos;
        }

    }
}
