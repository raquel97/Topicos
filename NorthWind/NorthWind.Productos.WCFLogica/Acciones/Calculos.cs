using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthWind.Productos.WCFLogica.Acciones
{
    internal class Calculos
    {
        public bool ElProductoEs(string productName)
        {
            var elResult = false;
            var product = productName.DayOfWeek;
            if (product == DayOfWeek.Sunday || product == DayOfWeek.Saturday)
                elResult = true;
            return elResult;
        }
    }
}