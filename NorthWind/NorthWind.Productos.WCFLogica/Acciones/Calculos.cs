using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthWind.Productos.WCFLogica
{
    internal class Calculos
    {
        public bool LaFechaEsFeriada(DateTime laFecha)
        {
            var elResultado = false;
            var elDiaDeLaSemana = laFecha.DayOfWeek;
            if (elDiaDeLaSemana == DayOfWeek.Sunday || elDiaDeLaSemana == DayOfWeek.Saturday)
                elResultado = true;
            return elResultado;
        }
    }
}