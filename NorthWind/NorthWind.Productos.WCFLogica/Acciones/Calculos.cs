using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthWind.Productos.WCFLogica.Acciones
{
    internal class Calculos
    {
        // metodo que permite devolver si un producto se sigue fabricando mediante condiciones
        public bool ProductoSeSigueFabricando(bool Descontin)
        {
            var elResultado = false;
            if (Descontin == true)
                elResultado = true;
            return elResultado;
        }
    }
}