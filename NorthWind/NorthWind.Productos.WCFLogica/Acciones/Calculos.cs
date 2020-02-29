using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthWind.Productos.WCFLogica.Acciones
{
    internal class Calculos
    {
        // metodo que permite devolver si un producto existe mediante condiciones
        public bool ElProductoEs(string productName)
        {
            var elResult = false;
            var product = productName.Categoria;
            if (product == Categoria.Seafood || product == Categoria.Grains || product == Categoria.Produce || product == Categoria.Meat || product == Categoria.Confections || product == Categoria.Dairy_Products || product == Categoria.Condiments || product == Categoria.Beverages)
                elResult = true;
            return elResult;
        }

        public string CiudadDeProcedenciaDeProducto(string productName)
        {
            var elResult = null;
            if (productName)
            {
            
            }
            return elResult;
        }

        public int ProductoEnStock(string NameProudct)
        {
            var elResult = null;
            var producto = NameProudct.Products;
            if(producto == ProductName.Products)
                elResult = true;
            return elResult;
        }

        public bool LaCompaniaDelProducto(string CompaniaName)
        {
            var elResult = false;
            var compania = CompaniaName.Suppliers;
            return elResult;

        }
    }
}