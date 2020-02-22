using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NorthWind.Productos.WCFLogica.IProductos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IProductos
    {

        public double PrecioPorUnidad(decimal UnitPrice)
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

        public bool ElProductoEs(string productName)
        {
            var laAccion = new Acciones.Calculos();
            var elResult = laAccion.ElProductoEs(productName);
            return elResult;
        }

        double IProductos.Producto(int productID, string productName, string categoryName, string description, decimal unitPrice)
        {
            throw new NotImplementedException();
        }

        public bool LaCategoriaEs(string categoryName)
        {
            var laAccion = new Acciones.CalculoCategoria();
            var elResult = laAccion.LaCategoriaEs(categoryName);
            return elResult;
        }
        double ICategorias.Categoria(int CategoryID, string CategoryName, string Description)
        {
            throw new NotImplementedException();
        }
    }
}
