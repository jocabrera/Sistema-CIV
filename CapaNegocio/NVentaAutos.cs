using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NVentaAutos
    {
        //METODO DE ELIMINAR
        public static string eliminarAutos(int cua)
        {
            DVentaAutos Obj = new DVentaAutos();
            Obj.CUA = cua;
            return Obj.eliminarAutos(Obj);
        }

        //METODO PARA MOSTRAR LOS AUTOS A VENDER
        public static DataTable mostrarAutos()
        {
            return new DVentaAutos().mostrarAutos();
        }
    }
}
