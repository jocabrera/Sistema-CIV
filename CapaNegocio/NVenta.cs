using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NVenta
    {
        //METODO PARA REALIZAR LA CONSULTA DE AUTO PARA LA VENTA DE PARTES
        public static DataTable ConsultaAutoVenta(string marca, string modelo, int anioInicial, int anioFinal, string tipoAuto, string cantidadCilindros)
        {
            DVenta Obj = new DVenta();
            Obj.Marca = marca;
            Obj.Modelo = modelo;
            Obj.AnioInicial = anioInicial;
            Obj.AnioFinal = anioFinal;
            Obj.TipoAuto = tipoAuto;
            Obj.CantidadCilindros = cantidadCilindros;
            return Obj.ConsultaAutoVenta(Obj);
        }

        //INSERTAR EN LA TABLA PUENTE DE LA COTIZACION LA VENTA
        public static String insertarCotizacion(int id)
        {
            DVenta Obj = new DVenta();
            Obj.Id_Buscar = id;
            return Obj.insertarCotizacion(Obj);
        }

        //METODO ConsultaCotizacion QUE LLAMA AL METODO ConsultaCotizacion DE LA CLASE DVenta DE LA CapaDatos
        public static DataTable ConsultaCotizacion()
        {
            return new DVenta().ConsultaCotizacion();
        }

        //METODO PARA ELIMINAR COTIZACÓIN
        public static String EliminarCotizacion()
        {
            DVenta Obj = new DVenta();
            return Obj.EliminarCotizacion(Obj);
        } 

        //METODO PARA INSERTAR LA VENTA 
        public static string insertarVenta(int id_cotizacion,int cuc, string nombreCliente, string fecha, string parte, string marca, 
            string modelo, int anio, string precio, float cantRecibida, float cambio, float montoTotal, float descuento, float pagoTotal,float ahorro)
        {
            DVenta Obj = new DVenta();
            Obj.Id_Cotizacion = id_cotizacion;
            Obj.CUC = cuc;
            Obj.Nombre = nombreCliente;
            Obj.Fecha = fecha;
            Obj.Parte = parte;
            Obj.Marca = marca;
            Obj.Modelo = modelo;
            Obj.Anio = anio;
            Obj.Precio = precio;
            Obj.CantidadRecibida = cantRecibida;
            Obj.Cambio = cambio;
            Obj.MontoTotal = montoTotal;
            Obj.Descuento = descuento;
            Obj.PagoTotal = pagoTotal;
            Obj.Ahorro = ahorro;

            return Obj.insertarVenta(Obj);
        }

        //METODO PARA ELIMINAR PARTES DEL INVENTARIO DESPUES DE SU VENTA
        public static string EliminarParte(int id_buscar)
        {
            DVenta Obj = new DVenta();
            Obj.Id_Buscar = id_buscar;
            return Obj.EliminarPartes(Obj);
        }

        public static string EliminarParteFull(int id_buscar)
        {
            DVenta Obj = new DVenta();
            Obj.Id_Buscar = id_buscar;
            return Obj.EliminarPartesFull(Obj);
        }

        //METODO PARA MODIFICAR LA FECHA DE ÚLTIMA COMPRA DEL CLIENTE
        public static string ModificarFechaUltimaCompra(int cuc, string fecha)
        {
            DVenta Obj = new DVenta();
            Obj.CUC = cuc;
            Obj.Fecha = fecha;
            return Obj.ModificarFechaUltimaCompra(Obj);
        }

        //METODO PARA INSERTAR EN EL PRESUPUESTO
        public static string insertarPresupuesto(int folio, int id_item, string parte, string marca, string modelo, int anio, string precio)
        {
            DVenta Obj = new DVenta();
            Obj.Folio = folio;
            Obj.Id_Item = id_item;
            Obj.Parte = parte;
            Obj.Marca = marca;
            Obj.Modelo = modelo;
            Obj.Anio = anio;
            Obj.Precio = precio;
            return Obj.insertarPresupuesto(Obj);
        }
    
        //METODO PARA ELIMINAR PRESUPUESTO
        public static string EliminarPresupuesto(int folio)
        {
            DVenta Obj = new DVenta();
            Obj.Folio = folio;
            return Obj.EliminarPresupuesto(Obj);
        }

        //CONSULTA DE PRESUPUESTO POR FOLIO 
        public static DataTable ConsultaEspPresupuesto(int folio)
        {
            DVenta Obj = new DVenta();
            Obj.Folio=folio;
            return Obj.ConsultaEspPresupuesto(Obj);
        }

        ////EXTRAER EL FOLIO DEL ULTIMO REGISTRO 
        public static int folioPresupuesto()
        {
            int folio=0;
            try
            {

                SqlConnection conexion = new SqlConnection("Data Source=CABRERA\\SQLEXPRESS; Initial Catalog=BDSistemaCIV; Integrated Security=true");
                conexion.Open();
                SqlCommand _comando = new SqlCommand("select MAX(folio) from Presupuesto", conexion);
                folio = (int)_comando.ExecuteScalar();
                conexion.Close();
            }
            catch (Exception ex)
            {
                folio = 1;
            }
            return folio;
        }

        //METODO PARA ELIMINAR PARTES DEL PRESUPUESTO GUARDADO
        public static string EliminarPartePresupuesto(int id_buscar)
        {
            DVenta Obj = new DVenta();
            Obj.Id_Buscar = id_buscar;
            return Obj.EliminarPartesPresupuesto(Obj);
        }
    }
}
