using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NReportes
    {
        public static DataTable MostrarCompras()
        {
            return new DReportes().MostrarCompras();
        }

        public static DataTable MostrarVentas()
        {
            return new DReportes().MostrarVentas();
        }

        public static DataTable BuscarCompras(string fechainiciocompra, string fechafinalcompra)
        {
            DReportes Obj = new DReportes();
            Obj.FechaInicioCompra = fechainiciocompra;
            Obj.FechaFinalCompra = fechafinalcompra;
            return Obj.BuscarCompras(Obj);
        }

        public static DataTable BuscarVentas(string fechainicioventa, string fechafinalventa)
        {
            DReportes Obj = new DReportes();
            Obj.FechaInicioVenta = fechainicioventa;
            Obj.FechaFinalVenta = fechafinalventa;
            return Obj.BuscarVentas(Obj);
        }
    }
}
