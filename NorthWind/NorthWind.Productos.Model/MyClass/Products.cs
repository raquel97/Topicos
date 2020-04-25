using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Productos.Model.MyClass
{
    public partial class Products
    {
        public string ReportsToName
        {
            get
            {
                var elResultado = "Unknown";
                if (ReportsTo != null)
                {
                    elResultado = this.Employees2.FullNameProduct;
                }
                return elResultado;
            }
            set
            { }
        }

        public string FullNameProduct
        {
            get
            {
                var elNombreCompleto = string.Empty;
                if (Title != null)
                    elNombreCompleto = string.Format("{0} {1} {2}", Title, FirstName, LastName);
                else
                    elNombreCompleto = string.Format("{0} {1}", FirstName, LastName);
                return elNombreCompleto;
            }
            set { }
        }
    }
}
