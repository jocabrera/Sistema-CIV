using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NCliente
    {
        //METODO Insertar QUE LLAMA AL METODO Insertar DE LA CLASE DatCliente de la CapaDatos
        public static string Insertar(string nombre, string direccion, string telefono, string descuento, string fecha_ultima_compra)
        {
            DCliente obj = new DCliente();
            obj.Nombre = nombre;
            obj.Direccion = direccion;
            obj.Telefono = telefono;
            obj.Descuento = descuento;
            obj.Fecha_Ultima_Compra = fecha_ultima_compra;
            return obj.Insertar(obj);
        }

        //METODO Modificar QUE LLAMA AL METODO Modificar DE LA CLASE DatCliente de la CapaDatos
        public static string Modificar(int cuc, string nombre, string direccion, string telefono, string descuento, string fecha_ultima_compra)
        {
            DCliente obj = new DCliente();
            obj.CUC = cuc;
            obj.Nombre = nombre;
            obj.Direccion = direccion;
            obj.Telefono = telefono;
            obj.Descuento = descuento;
            obj.Fecha_Ultima_Compra = fecha_ultima_compra;
            return obj.Modificar(obj);
        }

        //METODO Eliminar QUE LLAMA AL METODO Eliminar DE LA CLASE DatCliente DE LA CapaDatos
        public static string Eliminar(int cuc)
        {
            DCliente obj = new DCliente();
            obj.CUCbuscar = cuc;
            return obj.Eliminar(obj);
        }

        //METODO ConsultaGral QUE LLAMA AL METODO ConsultaGral DE LA CLASE DatCliente DE LA CapaDatos
        public static DataTable ConsultaGral()
        {
            return new DCliente().ConsultaGral();
        }

        //METODO ConsultaEsp QUE LLAMA AL METODO ConsultaEsp DE LA CLASE DatCliente DE LA CapaDatos
        public static DataTable ConsultaEsp(int cuc)
        {
            DCliente obj = new DCliente();
            obj.CUCbuscar = cuc;
            return obj.ConsultaEsp(obj);
        }
    }
}
