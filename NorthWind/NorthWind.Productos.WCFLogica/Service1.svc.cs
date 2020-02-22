﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NorthWind.Productos.WCFLogica
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IProductos
    {

        public double CalcularSalarioPorHora(int elNumeroDeEmpleado)
        {
            throw new NotImplementedException();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public bool LaFechaEsFeriada(DateTime laFecha)
        {
            var laAccion = new Acciones.CalculoDeFechas();
            var elResultado = laAccion.LaFechaEsFeriada(laFecha);
            return elResultado;
        }

        public double ObtenerHorasLaboradas(int elNumeroDeEmpleado, DateTime fechaInicial, DateTime fechaFinal)
        {
            throw new NotImplementedException();
        }
    }
}
